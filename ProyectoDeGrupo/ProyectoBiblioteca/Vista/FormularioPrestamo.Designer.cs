namespace ProyectoBiblioteca.Vista
{
    partial class FormularioPrestamo
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
            this.tlpPrincipalPrestamo = new System.Windows.Forms.TableLayoutPanel();
            this.cbbUsuario = new System.Windows.Forms.ComboBox();
            this.tlpFecha_Fin = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.tlpFecha_Inicio = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cbLibro = new System.Windows.Forms.ComboBox();
            this.btAgregarPrestamo = new System.Windows.Forms.Button();
            this.tlpPrestamo = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrincipalPrestamo.SuspendLayout();
            this.tlpFecha_Fin.SuspendLayout();
            this.tlpFecha_Inicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipalPrestamo
            // 
            this.tlpPrincipalPrestamo.ColumnCount = 2;
            this.tlpPrincipalPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipalPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipalPrestamo.Controls.Add(this.cbbUsuario, 1, 1);
            this.tlpPrincipalPrestamo.Controls.Add(this.tlpFecha_Fin, 1, 0);
            this.tlpPrincipalPrestamo.Controls.Add(this.tlpFecha_Inicio, 0, 0);
            this.tlpPrincipalPrestamo.Controls.Add(this.cbLibro, 0, 1);
            this.tlpPrincipalPrestamo.Controls.Add(this.btAgregarPrestamo, 0, 2);
            this.tlpPrincipalPrestamo.Controls.Add(this.tlpPrestamo, 0, 3);
            this.tlpPrincipalPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipalPrestamo.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipalPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.tlpPrincipalPrestamo.Name = "tlpPrincipalPrestamo";
            this.tlpPrincipalPrestamo.RowCount = 4;
            this.tlpPrincipalPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipalPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipalPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipalPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipalPrestamo.Size = new System.Drawing.Size(784, 492);
            this.tlpPrincipalPrestamo.TabIndex = 0;
            // 
            // cbbUsuario
            // 
            this.cbbUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbUsuario.FormattingEnabled = true;
            this.cbbUsuario.Location = new System.Drawing.Point(396, 53);
            this.cbbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cbbUsuario.Name = "cbbUsuario";
            this.cbbUsuario.Size = new System.Drawing.Size(384, 24);
            this.cbbUsuario.TabIndex = 4;
            this.cbbUsuario.Text = "Seleccionar Usuario";
            this.cbbUsuario.SelectedIndexChanged += new System.EventHandler(this.cbbUsuario_SelectedIndexChanged);
            // 
            // tlpFecha_Fin
            // 
            this.tlpFecha_Fin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.tlpFecha_Fin.ColumnCount = 2;
            this.tlpFecha_Fin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.79696F));
            this.tlpFecha_Fin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.20305F));
            this.tlpFecha_Fin.Controls.Add(this.label2, 0, 0);
            this.tlpFecha_Fin.Controls.Add(this.dtpFin, 1, 0);
            this.tlpFecha_Fin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFecha_Fin.Location = new System.Drawing.Point(396, 4);
            this.tlpFecha_Fin.Margin = new System.Windows.Forms.Padding(4);
            this.tlpFecha_Fin.Name = "tlpFecha_Fin";
            this.tlpFecha_Fin.RowCount = 1;
            this.tlpFecha_Fin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFecha_Fin.Size = new System.Drawing.Size(384, 41);
            this.tlpFecha_Fin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Fin: ";
            // 
            // dtpFin
            // 
            this.dtpFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFin.Location = new System.Drawing.Point(80, 4);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(300, 22);
            this.dtpFin.TabIndex = 1;
            // 
            // tlpFecha_Inicio
            // 
            this.tlpFecha_Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.tlpFecha_Inicio.ColumnCount = 2;
            this.tlpFecha_Inicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.05076F));
            this.tlpFecha_Inicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.94924F));
            this.tlpFecha_Inicio.Controls.Add(this.label1, 0, 0);
            this.tlpFecha_Inicio.Controls.Add(this.dtpInicio, 1, 0);
            this.tlpFecha_Inicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFecha_Inicio.Location = new System.Drawing.Point(4, 4);
            this.tlpFecha_Inicio.Margin = new System.Windows.Forms.Padding(4);
            this.tlpFecha_Inicio.Name = "tlpFecha_Inicio";
            this.tlpFecha_Inicio.RowCount = 1;
            this.tlpFecha_Inicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFecha_Inicio.Size = new System.Drawing.Size(384, 41);
            this.tlpFecha_Inicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio: ";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInicio.Location = new System.Drawing.Point(80, 4);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(300, 22);
            this.dtpInicio.TabIndex = 1;
            // 
            // cbLibro
            // 
            this.cbLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLibro.FormattingEnabled = true;
            this.cbLibro.Location = new System.Drawing.Point(4, 53);
            this.cbLibro.Margin = new System.Windows.Forms.Padding(4);
            this.cbLibro.Name = "cbLibro";
            this.cbLibro.Size = new System.Drawing.Size(384, 24);
            this.cbLibro.TabIndex = 3;
            this.cbLibro.Text = "Seleccionar Libro";
            this.cbLibro.SelectedIndexChanged += new System.EventHandler(this.cbLibro_SelectedIndexChanged);
            // 
            // btAgregarPrestamo
            // 
            this.btAgregarPrestamo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tlpPrincipalPrestamo.SetColumnSpan(this.btAgregarPrestamo, 2);
            this.btAgregarPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAgregarPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btAgregarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarPrestamo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btAgregarPrestamo.Location = new System.Drawing.Point(4, 85);
            this.btAgregarPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btAgregarPrestamo.Name = "btAgregarPrestamo";
            this.btAgregarPrestamo.Size = new System.Drawing.Size(776, 28);
            this.btAgregarPrestamo.TabIndex = 1;
            this.btAgregarPrestamo.Text = "Crear Prestamo";
            this.btAgregarPrestamo.UseVisualStyleBackColor = false;
            this.btAgregarPrestamo.Click += new System.EventHandler(this.btAgregarPrestamo_Click);
            // 
            // tlpPrestamo
            // 
            this.tlpPrestamo.ColumnCount = 1;
            this.tlpPrincipalPrestamo.SetColumnSpan(this.tlpPrestamo, 2);
            this.tlpPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrestamo.Location = new System.Drawing.Point(4, 121);
            this.tlpPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.tlpPrestamo.Name = "tlpPrestamo";
            this.tlpPrestamo.RowCount = 1;
            this.tlpPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrestamo.Size = new System.Drawing.Size(776, 367);
            this.tlpPrestamo.TabIndex = 5;
            // 
            // FormularioPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 492);
            this.Controls.Add(this.tlpPrincipalPrestamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioPrestamo";
            this.Text = "FormularioPrestamo";
            this.Load += new System.EventHandler(this.FormularioPrestamo_Load_1);
            this.tlpPrincipalPrestamo.ResumeLayout(false);
            this.tlpFecha_Fin.ResumeLayout(false);
            this.tlpFecha_Fin.PerformLayout();
            this.tlpFecha_Inicio.ResumeLayout(false);
            this.tlpFecha_Inicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipalPrestamo;
        private System.Windows.Forms.TableLayoutPanel tlpFecha_Inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btAgregarPrestamo;
        private System.Windows.Forms.TableLayoutPanel tlpFecha_Fin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.ComboBox cbbUsuario;
        private System.Windows.Forms.ComboBox cbLibro;
        private System.Windows.Forms.TableLayoutPanel tlpPrestamo;
    }
}