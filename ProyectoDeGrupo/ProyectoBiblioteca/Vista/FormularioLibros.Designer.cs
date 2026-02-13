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
<<<<<<< HEAD
            this.tlpPrincipalUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.tlpPrincipalUsuarios.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> d3570de (actualizar libro y eliminar prestamo)
            this.tlpPrincipalUsuarios.Name = "tlpPrincipalUsuarios";
            this.tlpPrincipalUsuarios.RowCount = 3;
            this.tlpPrincipalUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tlpPrincipalUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipalUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipalUsuarios.Size = new System.Drawing.Size(800, 450);
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
<<<<<<< HEAD
            this.tlpEncabezadoLibros.Location = new System.Drawing.Point(3, 2);
            this.tlpEncabezadoLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.tlpEncabezadoLibros.Location = new System.Drawing.Point(2, 2);
            this.tlpEncabezadoLibros.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> d3570de (actualizar libro y eliminar prestamo)
            this.tlpEncabezadoLibros.Name = "tlpEncabezadoLibros";
            this.tlpEncabezadoLibros.RowCount = 1;
            this.tlpEncabezadoLibros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEncabezadoLibros.Size = new System.Drawing.Size(794, 55);
            this.tlpEncabezadoLibros.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Libro: ";
            // 
            // txbBuscarLibro
            // 
            this.txbBuscarLibro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbBuscarLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBuscarLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbBuscarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarLibro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txbBuscarLibro.Location = new System.Drawing.Point(125, 20);
            this.txbBuscarLibro.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.txbBuscarLibro.Name = "txbBuscarLibro";
            this.txbBuscarLibro.Size = new System.Drawing.Size(394, 21);
            this.txbBuscarLibro.TabIndex = 1;
            this.txbBuscarLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.BackColor = System.Drawing.Color.IndianRed;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(535, 14);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(246, 33);
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
<<<<<<< HEAD
            this.tlpSecundarioUsuarios.Location = new System.Drawing.Point(3, 61);
            this.tlpSecundarioUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.tlpSecundarioUsuarios.Location = new System.Drawing.Point(2, 50);
            this.tlpSecundarioUsuarios.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> d3570de (actualizar libro y eliminar prestamo)
            this.tlpSecundarioUsuarios.Name = "tlpSecundarioUsuarios";
            this.tlpSecundarioUsuarios.RowCount = 1;
            this.tlpSecundarioUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlpSecundarioUsuarios.Size = new System.Drawing.Size(794, 73);
            this.tlpSecundarioUsuarios.TabIndex = 1;
            // 
            // btAgregar
            // 
            this.btAgregar.AutoSize = true;
            this.btAgregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAgregar.Location = new System.Drawing.Point(541, 14);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.btAgregar.Name = "btAgregar";
<<<<<<< HEAD
            this.btAgregar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAgregar.Size = new System.Drawing.Size(240, 45);
=======
            this.btAgregar.Padding = new System.Windows.Forms.Padding(2);
            this.btAgregar.Size = new System.Drawing.Size(180, 37);
>>>>>>> d3570de (actualizar libro y eliminar prestamo)
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
            this.tableLayoutPanelLibros.Location = new System.Drawing.Point(4, 140);
            this.tableLayoutPanelLibros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelLibros.Name = "tableLayoutPanelLibros";
            this.tableLayoutPanelLibros.RowCount = 1;
            this.tableLayoutPanelLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLibros.Size = new System.Drawing.Size(792, 306);
            this.tableLayoutPanelLibros.TabIndex = 2;
            // 
            // FormularioLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpPrincipalUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> d3570de (actualizar libro y eliminar prestamo)
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