namespace ProyectoBiblioteca
{
    partial class FormularioLibros
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
            this.tlpPrincipalUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEncabezadoLibros = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBuscarLibro = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tlpSecundarioUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.btAgregar = new System.Windows.Forms.Button();
            this.tableLayoutPanelLibros = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrincipalUsuarios.SuspendLayout();
            this.tlpEncabezadoLibros.SuspendLayout();
            this.tlpSecundarioUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipalUsuarios
            // 
            this.tlpPrincipalUsuarios.ColumnCount = 1;
            this.tlpPrincipalUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipalUsuarios.Controls.Add(this.tlpEncabezadoLibros, 0, 0);
            this.tlpPrincipalUsuarios.Controls.Add(this.tlpSecundarioUsuarios, 1, 1);
            this.tlpPrincipalUsuarios.Controls.Add(this.tableLayoutPanelLibros, 0, 2);
            this.tlpPrincipalUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipalUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipalUsuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpPrincipalUsuarios.Name = "tlpPrincipalUsuarios";
            this.tlpPrincipalUsuarios.RowCount = 3;
            this.tlpPrincipalUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpPrincipalUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipalUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipalUsuarios.Size = new System.Drawing.Size(1200, 703);
            this.tlpPrincipalUsuarios.TabIndex = 4;
            // 
            // tlpEncabezadoLibros
            // 
            this.tlpEncabezadoLibros.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tlpEncabezadoLibros.ColumnCount = 3;
            this.tlpEncabezadoLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEncabezadoLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.52514F));
            this.tlpEncabezadoLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.47486F));
            this.tlpEncabezadoLibros.Controls.Add(this.label1, 0, 0);
            this.tlpEncabezadoLibros.Controls.Add(this.txbBuscarLibro, 1, 0);
            this.tlpEncabezadoLibros.Controls.Add(this.btBuscar, 2, 0);
            this.tlpEncabezadoLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEncabezadoLibros.Location = new System.Drawing.Point(4, 3);
            this.tlpEncabezadoLibros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpEncabezadoLibros.Name = "tlpEncabezadoLibros";
            this.tlpEncabezadoLibros.RowCount = 1;
            this.tlpEncabezadoLibros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEncabezadoLibros.Size = new System.Drawing.Size(1192, 86);
            this.tlpEncabezadoLibros.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 31, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Libro: ";
            // 
            // txbBuscarLibro
            // 
            this.txbBuscarLibro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbBuscarLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBuscarLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbBuscarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarLibro.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbBuscarLibro.Location = new System.Drawing.Point(193, 31);
            this.txbBuscarLibro.Margin = new System.Windows.Forms.Padding(4, 31, 4, 31);
            this.txbBuscarLibro.Name = "txbBuscarLibro";
            this.txbBuscarLibro.Size = new System.Drawing.Size(589, 34);
            this.txbBuscarLibro.TabIndex = 1;
            this.txbBuscarLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.IndianRed;
            this.btBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(806, 20);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(366, 75);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Search";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tlpSecundarioUsuarios
            // 
            this.tlpSecundarioUsuarios.ColumnCount = 3;
            this.tlpSecundarioUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSecundarioUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSecundarioUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSecundarioUsuarios.Controls.Add(this.btAgregar, 2, 0);
            this.tlpSecundarioUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSecundarioUsuarios.Location = new System.Drawing.Point(4, 95);
            this.tlpSecundarioUsuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpSecundarioUsuarios.Name = "tlpSecundarioUsuarios";
            this.tlpSecundarioUsuarios.RowCount = 1;
            this.tlpSecundarioUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tlpSecundarioUsuarios.Size = new System.Drawing.Size(1192, 114);
            this.tlpSecundarioUsuarios.TabIndex = 1;
            // 
            // btAgregar
            // 
            this.btAgregar.AutoSize = true;
            this.btAgregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAgregar.Location = new System.Drawing.Point(814, 20);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAgregar.Size = new System.Drawing.Size(358, 74);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Añadir";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // tableLayoutPanelLibros
            // 
            this.tableLayoutPanelLibros.ColumnCount = 1;
            this.tableLayoutPanelLibros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLibros.Location = new System.Drawing.Point(6, 218);
            this.tableLayoutPanelLibros.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanelLibros.Name = "tableLayoutPanelLibros";
            this.tableLayoutPanelLibros.RowCount = 1;
            this.tableLayoutPanelLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLibros.Size = new System.Drawing.Size(1188, 479);
            this.tableLayoutPanelLibros.TabIndex = 2;
            this.tableLayoutPanelLibros.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelLibros_Paint);
            // 
            // FormularioLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.tlpPrincipalUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormularioLibros";
            this.Text = "FormularioLibros";
            this.Load += new System.EventHandler(this.FormularioLibros_Load);
            this.tlpPrincipalUsuarios.ResumeLayout(false);
            this.tlpEncabezadoLibros.ResumeLayout(false);
            this.tlpEncabezadoLibros.PerformLayout();
            this.tlpSecundarioUsuarios.ResumeLayout(false);
            this.tlpSecundarioUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipalUsuarios;
        private System.Windows.Forms.TableLayoutPanel tlpSecundarioUsuarios;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLibros;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezadoLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBuscarLibro;
        private System.Windows.Forms.Button btBuscar;
    }
}