namespace SuiteSupermercado
{
    partial class MenuPrinicpal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTipMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbPuntoDeVenta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPuntoDeVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SuiteSupermercado.Properties.Resources.bolsa_de_la_compra;
            this.pictureBox4.Location = new System.Drawing.Point(82, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.toolTipMensaje.SetToolTip(this.pictureBox4, "Inventarios");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SuiteSupermercado.Properties.Resources.perfil;
            this.pictureBox3.Location = new System.Drawing.Point(152, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.toolTipMensaje.SetToolTip(this.pictureBox3, "Clientes");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SuiteSupermercado.Properties.Resources.transferencia_de_dinero;
            this.pictureBox2.Location = new System.Drawing.Point(222, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.toolTipMensaje.SetToolTip(this.pictureBox2, "Cuentas");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbPuntoDeVenta
            // 
            this.pbPuntoDeVenta.Image = global::SuiteSupermercado.Properties.Resources.recibo;
            this.pbPuntoDeVenta.Location = new System.Drawing.Point(12, 12);
            this.pbPuntoDeVenta.Name = "pbPuntoDeVenta";
            this.pbPuntoDeVenta.Size = new System.Drawing.Size(64, 64);
            this.pbPuntoDeVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPuntoDeVenta.TabIndex = 0;
            this.pbPuntoDeVenta.TabStop = false;
            this.toolTipMensaje.SetToolTip(this.pbPuntoDeVenta, "Punto De Venta");
            this.pbPuntoDeVenta.Click += new System.EventHandler(this.pbPuntoDeVenta_Click);
            // 
            // MenuPrinicpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 86);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbPuntoDeVenta);
            this.Name = "MenuPrinicpal";
            this.Text = "MicroCHEAT - Modulos";
            this.Load += new System.EventHandler(this.MenuPrinicpal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPuntoDeVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPuntoDeVenta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolTip toolTipMensaje;
    }
}

