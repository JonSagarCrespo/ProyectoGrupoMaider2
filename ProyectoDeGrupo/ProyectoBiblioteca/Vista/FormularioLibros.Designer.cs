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
            this.tlpEncabezadoUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBuscarLibro = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tlpSecundarioUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.btAgregar = new System.Windows.Forms.Button();
            this.tableLayoutPanelLibros = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrincipalUsuarios.SuspendLayout();
            this.tlpEncabezadoUsuarios.SuspendLayout();
            this.tlpSecundarioUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipalUsuarios
            // 
            this.tlpPrincipalUsuarios.ColumnCount = 1;
            this.tlpPrincipalUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipalUsuarios.Controls.Add(this.tlpEncabezadoUsuarios, 0, 0);
            this.tlpPrincipalUsuarios.Controls.Add(this.tlpSecundarioUsuarios, 1, 1);
            this.tlpPrincipalUsuarios.Controls.Add(this.tableLayoutPanelLibros, 0, 2);
            this.tlpPrincipalUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipalUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipalUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.tlpPrincipalUsuarios.Name = "tlpPrincipalUsuarios";
            this.tlpPrincipalUsuarios.RowCount = 3;
            this.tlpPrincipalUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpPrincipalUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.81132F));
            this.tlpPrincipalUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.18868F));
            this.tlpPrincipalUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipalUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipalUsuarios.Size = new System.Drawing.Size(600, 366);
            this.tlpPrincipalUsuarios.TabIndex = 4;
            // 
            // tlpEncabezadoUsuarios
            // 
            this.tlpEncabezadoUsuarios.ColumnCount = 3;
            this.tlpEncabezadoUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEncabezadoUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpEncabezadoUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlpEncabezadoUsuarios.Controls.Add(this.label1, 0, 0);
            this.tlpEncabezadoUsuarios.Controls.Add(this.txbBuscarLibro, 1, 0);
            this.tlpEncabezadoUsuarios.Controls.Add(this.btBuscar, 2, 0);
            this.tlpEncabezadoUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEncabezadoUsuarios.Location = new System.Drawing.Point(2, 2);
            this.tlpEncabezadoUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.tlpEncabezadoUsuarios.Name = "tlpEncabezadoUsuarios";
            this.tlpEncabezadoUsuarios.RowCount = 1;
            this.tlpEncabezadoUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEncabezadoUsuarios.Size = new System.Drawing.Size(596, 44);
            this.tlpEncabezadoUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 16, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Libro : ";
            // 
            // txbBuscarLibro
            // 
            this.txbBuscarLibro.BackColor = System.Drawing.SystemColors.InfoText;
            this.txbBuscarLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBuscarLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbBuscarLibro.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbBuscarLibro.Location = new System.Drawing.Point(81, 16);
            this.txbBuscarLibro.Margin = new System.Windows.Forms.Padding(2, 16, 2, 16);
            this.txbBuscarLibro.Name = "txbBuscarLibro";
            this.txbBuscarLibro.Size = new System.Drawing.Size(168, 13);
            this.txbBuscarLibro.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btBuscar.Location = new System.Drawing.Point(262, 12);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(323, 21);
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
            this.tlpSecundarioUsuarios.Location = new System.Drawing.Point(2, 50);
            this.tlpSecundarioUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.tlpSecundarioUsuarios.Name = "tlpSecundarioUsuarios";
            this.tlpSecundarioUsuarios.RowCount = 1;
            this.tlpSecundarioUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpSecundarioUsuarios.Size = new System.Drawing.Size(596, 58);
            this.tlpSecundarioUsuarios.TabIndex = 1;
            // 
            // btAgregar
            // 
            this.btAgregar.AutoSize = true;
            this.btAgregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAgregar.Location = new System.Drawing.Point(398, 2);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(196, 54);
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
            this.tableLayoutPanelLibros.Location = new System.Drawing.Point(3, 113);
            this.tableLayoutPanelLibros.Name = "tableLayoutPanelLibros";
            this.tableLayoutPanelLibros.RowCount = 1;
            this.tableLayoutPanelLibros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLibros.Size = new System.Drawing.Size(594, 250);
            this.tableLayoutPanelLibros.TabIndex = 2;
            // 
            // FormularioLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tlpPrincipalUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioLibros";
            this.Text = "FormularioLibros";
            this.Load += new System.EventHandler(this.FormularioLibros_Load);
            this.tlpPrincipalUsuarios.ResumeLayout(false);
            this.tlpEncabezadoUsuarios.ResumeLayout(false);
            this.tlpEncabezadoUsuarios.PerformLayout();
            this.tlpSecundarioUsuarios.ResumeLayout(false);
            this.tlpSecundarioUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipalUsuarios;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezadoUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBuscarLibro;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TableLayoutPanel tlpSecundarioUsuarios;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLibros;
    }
}