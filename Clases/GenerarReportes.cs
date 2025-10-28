using CrystalDecisions.CrystalReports.Engine;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiteSupermercado
{
    public class GenerarReporte
    {
        private string connectionString = "Host=localhost;Port=5432;Database=db_supermercado;Username=admin;Password=postgres;";

        public ReportDocument CrearTicket(int idFactura)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                        SELECT 
                            e.nombre AS nombre_empleado,
                            e.apellido AS apellido_empleado,
                            c.nombre AS nombre_cliente,
                            c.apellido AS apellido_cliente,
                            vp.cantidad,
                            p.nombre AS producto,
                            p.precio_unidad AS precio_unitario,
                            (vp.cantidad * p.precio_unidad) AS total
                        FROM ventas v
                        JOIN empleados e ON e.id = v.id_empleado
                        JOIN facturas f ON f.id = v.id_factura
                        JOIN compras_clientes cc ON cc.id_venta = v.id
                        JOIN clientes c ON c.id = cc.id_cliente
                        JOIN ventas_productos vp ON vp.id_venta = v.id
                        JOIN productos p ON p.id = vp.id_producto
                        WHERE f.id = @idFactura;";


                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@idFactura", idFactura);

                    DataSetApp ds = new DataSetApp();
                    dataAdapter.Fill(ds, "ticketReporte");

                    ReportDocument reporte = new ReportDocument();
                    reporte.Load(@"C:\Users\Jose Luis\source\repos\SuiteSupermercado\SuiteSupermercado\TicketVenta.rpt");
                    reporte.SetDataSource(ds.Tables["ticketReporte"]);

                    return reporte;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al generar el ticket: " + ex.Message);
                }
            }
        }
    }
}
