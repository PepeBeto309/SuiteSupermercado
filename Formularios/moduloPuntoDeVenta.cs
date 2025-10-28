using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using CrystalDecisions.CrystalReports.Engine;


namespace SuiteSupermercado
{
    public partial class moduloPuntoDeVenta : Form
    {
        Datos datos = new Datos();
        private Dictionary<int, string> mapaClientes = new Dictionary<int, string>();
        private Dictionary<int, string> mapaVendedores = new Dictionary<int, string>();
        private BindingList<LineaVenta> detallesVenta = new BindingList<LineaVenta>();
        int idProductoActual = 0;

        public moduloPuntoDeVenta()
        {
            InitializeComponent();
            rbClienteNom.Checked = true;
            rbEmpleadoNom.Checked = true;

            CargarListaClientes();
            CargarListaVendedores();

            dgvDetallesVenta.AutoGenerateColumns = true;
            dgvDetallesVenta.DataSource = detallesVenta;
        }

        private void CargarListaClientes()
        {
            string query = "SELECT id, nombre || ' ' || apellido AS nombre_completo FROM clientes ORDER BY id;";

            DataSet ds = datos.getAllData(query);

            if (ds != null && ds.Tables.Count > 0)
            {
                mapaClientes.Clear();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int idCliente = Convert.ToInt32(row["id"]);
                    string nombreCompleto = row["nombre_completo"].ToString();

                    mapaClientes.Add(idCliente, nombreCompleto);
                }

                ActualizarComboClientes();
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los datos de los clientes.",
                                "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaVendedores()
        {
            string query = "SELECT id, nombre || ' ' || apellido AS nombre_completo FROM empleados WHERE cargo = 'Cajero' OR cargo = 'Cajera' ORDER BY id;";

            DataSet ds = datos.getAllData(query);

            if (ds != null && ds.Tables.Count > 0)
            {
                mapaVendedores.Clear();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int idVendedor = Convert.ToInt32(row["id"]);
                    string nombreCompleto = row["nombre_completo"].ToString();

                    mapaVendedores.Add(idVendedor, nombreCompleto);
                }

                ActualizarComboVendedores();
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los datos de los vendedores (cajeros).",
                                "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarComboClientes()
        {
            cbListaClientes.Items.Clear();

            if (rbClienteId.Checked)
            {
                foreach (int id in mapaClientes.Keys)
                {
                    cbListaClientes.Items.Add(id);
                }
            }
            else
            {
                foreach (string nombre in mapaClientes.Values)
                {
                    cbListaClientes.Items.Add(nombre);
                }
            }

            if (cbListaClientes.Items.Count > 0)
            {
                cbListaClientes.SelectedIndex = 0;
            }
        }

        private void ActualizarComboVendedores()
        {
            cbListaVendedores.Items.Clear();
            if (rbEmpleadoId.Checked)
            {
                foreach (int id in mapaVendedores.Keys)
                {
                    cbListaVendedores.Items.Add(id);
                }
            }
            else
            {
                foreach (string nombre in mapaVendedores.Values)
                {
                    cbListaVendedores.Items.Add(nombre);
                }
            }
            if (cbListaVendedores.Items.Count > 0)
            {
                cbListaVendedores.SelectedIndex = 0;
            }
        }

        private void rbClienteNom_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ActualizarComboClientes();
            }
        }

        private void rbClienteId_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ActualizarComboClientes();
            }
        }

        private void rbEmpleadoId_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ActualizarComboVendedores();
            }
        }

        private void rbEmpleadoNom_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ActualizarComboVendedores();
            }
        }

        private async void tbClaveProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                e.SuppressKeyPress = true;

                string codigo = tbClaveProducto.Text.Trim();
                if (string.IsNullOrEmpty(codigo))
                {
                    tbProducto.Text = "";
                    tbPrecioUnitario.Text = "";
                    pbProducto.Image = null;
                    return;
                }

                string query = $"SELECT id, nombre, precio_unidad, imagen FROM productos WHERE codigo = '{codigo}';";

                DataSet ds = datos.getAllData(query);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    string nombreProducto = row["nombre"].ToString();
                    decimal precioVenta = Convert.ToDecimal(row["precio_unidad"]);
                    idProductoActual = Convert.ToInt32(row["id"]);
                    tbProducto.Text = nombreProducto;
                    tbPrecioUnitario.Text = precioVenta.ToString("F2");

                    string urlImagen = row["imagen"].ToString();

                    if (!string.IsNullOrEmpty(urlImagen))
                    {
                        await CargarImagen(urlImagen, pbProducto);
                    }
                    else
                    {
                        pbProducto.Image = null;
                    }
                }
                else
                {
                    tbProducto.Text = "";
                    tbPrecioUnitario.Text = "";
                    pbProducto.Image = null;
                    MessageBox.Show($"Producto con código '{codigo}' no encontrado.", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async Task CargarImagen(string urlImagen, PictureBox pictureBox)
        {
            pictureBox.Image = null;

            if (string.IsNullOrWhiteSpace(urlImagen) || !Uri.IsWellFormedUriString(urlImagen, UriKind.Absolute))
            {
                Console.WriteLine($"URL no válida: {urlImagen}");
                return;
            }

            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromSeconds(15);

                    httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozila/5.0");

                    byte[] imagenBytes = await httpClient.GetByteArrayAsync(urlImagen);

                    using (var ms = new MemoryStream(imagenBytes))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"Error de red al descargar {urlImagen}: {httpEx.Message}");
                pictureBox.Image = null;
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine($"Tiempo de espera agotado para la URL: {urlImagen}");
                pictureBox.Image = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general al cargar la imagen: {ex.Message}");
                pictureBox.Image = null;
            }
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas() || idProductoActual == 0)
            {
                MessageBox.Show("Busque un producto válido primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string clave = tbClaveProducto.Text.Trim();
            string nombre = tbProducto.Text.Trim();

            decimal precioUnitario = Convert.ToDecimal(tbPrecioUnitario.Text);

            if (!decimal.TryParse(tbCantidad.Text, out decimal cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida y mayor a cero.", "Error de Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCantidad.Focus();
                return;
            }

            LineaVenta nuevaLinea = new LineaVenta
            {
                IdProducto = idProductoActual,
                Clave = clave,
                Producto = nombre,
                Cantidad = cantidad,
                PrecioUnitario = precioUnitario,
                Subtotal = cantidad * precioUnitario
            };

            detallesVenta.Add(nuevaLinea);

            CalcularTotal();
            LimpiarCamposDespuesDeAgregar();
            idProductoActual = 0;

        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (var linea in detallesVenta)
            {
                total += linea.Subtotal;
            }

            labTotal.Text = total.ToString("C2");
        }

        private bool ValidarEntradas()
        {
            if (string.IsNullOrWhiteSpace(tbClaveProducto.Text) || string.IsNullOrWhiteSpace(tbProducto.Text))
            {
                MessageBox.Show("Debe seleccionar o ingresar un producto válido primero.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(tbPrecioUnitario.Text, out _))
            {
                MessageBox.Show("El precio unitario no es válido.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LimpiarCamposDespuesDeAgregar()
        {
            tbClaveProducto.Clear();
            tbProducto.Clear();
            tbPrecioUnitario.Clear();
            tbCantidad.Text = "";
            pbProducto.Image = null;
            tbClaveProducto.Focus();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetallesVenta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila del detalle de venta para eliminar.",
                                "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea eliminar la línea de producto seleccionada?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int rowIndex = dgvDetallesVenta.SelectedRows[0].Index;

                if (rowIndex >= 0 && rowIndex < detallesVenta.Count)
                {
                    detallesVenta.RemoveAt(rowIndex);

                    CalcularTotal();
                }
                else
                {
                    MessageBox.Show("Error al obtener el índice de la fila seleccionada.",
                                    "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void butFinalizarCompara_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();

            using (var conexion = datos.GetConnections())
            using (var trans = conexion.BeginTransaction())
            {
                int idFacturaGenerada = 0;
                int idVentaGenerada = 0;

                try
                {
                    // ===================== FACTURA =====================
                    string sqlFactura = @"
        INSERT INTO facturas (numero, codigo, fecha, hora, importe_total)
        VALUES (@numero, @codigo, @fecha, @hora, @importe_total)
        RETURNING id;";

                    using (var cmdFactura = new NpgsqlCommand(sqlFactura, conexion, trans))
                    {
                        cmdFactura.Parameters.AddWithValue("@numero", "00001");
                        cmdFactura.Parameters.AddWithValue("@codigo", Guid.NewGuid().ToString().Substring(0, 8));
                        cmdFactura.Parameters.AddWithValue("@fecha", DateTime.Now.Date);
                        cmdFactura.Parameters.AddWithValue("@hora", DateTime.Now.TimeOfDay);
                        cmdFactura.Parameters.AddWithValue("@importe_total", Convert.ToDecimal(labTotal.Text.Replace("$", "")));

                        idFacturaGenerada = Convert.ToInt32(cmdFactura.ExecuteScalar());
                    }

                    // ===================== DETALLE FACTURA =====================
                    string sqlDetalle = @"
        INSERT INTO facturas_detalles (id_factura, tipo, descr_factura, costo_asoc, iva, medio_de_pago, descr_pago)
        VALUES (@id_factura, @tipo::tipo_factura_enum, @descr_factura, @costo_asoc, @iva, @medio_de_pago::tipo_pago_enum, @descr_pago);";

                    using (var cmdDetalle = new NpgsqlCommand(sqlDetalle, conexion, trans))
                    {
                        cmdDetalle.Parameters.AddWithValue("@id_factura", idFacturaGenerada);
                        cmdDetalle.Parameters.AddWithValue("@tipo", "B");
                        cmdDetalle.Parameters.AddWithValue("@descr_factura", "Factura de compra");
                        cmdDetalle.Parameters.AddWithValue("@costo_asoc", Convert.ToDecimal(labTotal.Text.Replace("$", "")));
                        cmdDetalle.Parameters.AddWithValue("@iva", Convert.ToDecimal(labTotal.Text.Replace("$", "")) * 0.16m);
                        cmdDetalle.Parameters.AddWithValue("@medio_de_pago", "EFECTIVO");
                        cmdDetalle.Parameters.AddWithValue("@descr_pago", "Pago en efectivo");
                        cmdDetalle.ExecuteNonQuery();
                    }

                    // ===================== VENTA =====================
                    int idVendedor = obtenerIdVendedorSeleccionado();
                    string sqlVenta = @"
        INSERT INTO ventas (id_empleado, id_factura)
        VALUES (@id_empleado, @id_factura)
        RETURNING id;";

                    using (var cmdVenta = new NpgsqlCommand(sqlVenta, conexion, trans))
                    {
                        cmdVenta.Parameters.AddWithValue("@id_empleado", idVendedor);
                        cmdVenta.Parameters.AddWithValue("@id_factura", idFacturaGenerada);
                        idVentaGenerada = Convert.ToInt32(cmdVenta.ExecuteScalar());
                    }

                    // ===================== PRODUCTOS DE LA VENTA =====================
                    string sqlVentaProd = @"
        INSERT INTO ventas_productos (id_venta, id_producto, cantidad)
        VALUES (@id_venta, @id_producto, @cantidad);";

                    foreach (DataGridViewRow row in dgvDetallesVenta.Rows)
                    {
                        if (row.IsNewRow) continue;

                        using (var cmdVP = new NpgsqlCommand(sqlVentaProd, conexion, trans))
                        {
                            cmdVP.Parameters.AddWithValue("@id_venta", idVentaGenerada);
                            cmdVP.Parameters.AddWithValue("@id_producto", Convert.ToInt32(row.Cells["IdProducto"].Value));
                            cmdVP.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells["Cantidad"].Value));
                            cmdVP.ExecuteNonQuery();
                        }
                    }

                    // ===================== CLIENTE =====================
                    int idCliente = obtenerIdClienteSeleccionado();
                    string sqlCompraCliente = @"
        INSERT INTO compras_clientes (id_venta, id_cliente)
        VALUES (@id_venta, @id_cliente);";

                    using (var cmdCC = new NpgsqlCommand(sqlCompraCliente, conexion, trans))
                    {
                        cmdCC.Parameters.AddWithValue("@id_venta", idVentaGenerada);
                        cmdCC.Parameters.AddWithValue("@id_cliente", idCliente);
                        cmdCC.ExecuteNonQuery();
                    }

                    // Confirmar transacción
                    trans.Commit();

                    // ===================== GENERAR TICKET Y GUARDAR PDF =====================
                    try
                    {
                        ReportDocument rpt = new ReportDocument();
                        string rutaReporte = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TicketVenta.rpt");

                        if (!File.Exists(rutaReporte))
                        {
                            MessageBox.Show($"No se encontró el reporte en: {rutaReporte}", "Ruta inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        rpt.Load(rutaReporte);

                        // Verificar y asignar parámetro ID_FACTURA
                        if (rpt.DataDefinition.ParameterFields.Cast<ParameterFieldDefinition>()
                            .Any(p => p.Name.Equals("ID_FACTURA", StringComparison.OrdinalIgnoreCase)))
                        {
                            rpt.SetParameterValue("ID_FACTURA", idFacturaGenerada);
                        }

                        // === 📄 Exportar como PDF ===
                        string carpetaDestino = "C:\\Users\\josea\\Documents\\Tickets";
                        Directory.CreateDirectory(carpetaDestino);

                        string nombreArchivo = $"Ticket_{idFacturaGenerada}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                        string rutaPDF = Path.Combine(carpetaDestino, nombreArchivo);

                        rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, rutaPDF);

                        MessageBox.Show($"Ticket guardado correctamente en:\n{rutaPDF}", "Ticket generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Si también deseas imprimir el ticket físicamente, descomenta la siguiente línea:
                        // rpt.PrintToPrinter(1, false, 0, 0);
                    }
                    catch (Exception reportEx)
                    {
                        MessageBox.Show($"Error al generar o guardar el ticket: {reportEx.Message}", "Error de Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // ===================== LIMPIEZA =====================
                    dgvDetallesVenta.Rows.Clear();
                    detallesVenta.Clear();
                    labTotal.Text = "";

                    MessageBox.Show("Compra finalizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show($"Error al consolidar la compra: {ex.Message}", "Error de Transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int obtenerIdClienteSeleccionado()
        {
            if (rbClienteId.Checked)
            {
                return Convert.ToInt32(cbListaClientes.SelectedItem);
            }
            else
            {
                string nombreSeleccionado = cbListaClientes.SelectedItem.ToString();
                return mapaClientes.FirstOrDefault(x => x.Value == nombreSeleccionado).Key;
            }
        }

        private int obtenerIdVendedorSeleccionado()
        {
            if (rbEmpleadoId.Checked)
            {
                return Convert.ToInt32(cbListaVendedores.SelectedItem);
            }
            else
            {
                string nombreSeleccionado = cbListaVendedores.SelectedItem.ToString();
                return mapaVendedores.FirstOrDefault(x => x.Value == nombreSeleccionado).Key;
            }
        }
    }
}
