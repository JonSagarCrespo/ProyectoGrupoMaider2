namespace ProyectoBiblioteca.Vista
{
    partial class formularioEditarLibro
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lEidLibro = new System.Windows.Forms.Label();
            this.tbEscritor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.lEscritor = new System.Windows.Forms.Label();
            this.lAno_edicion = new System.Windows.Forms.Label();
            this.tbSinopsis = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbAno_edicion = new System.Windows.Forms.TextBox();
            this.tbSinop = new System.Windows.Forms.TextBox();
            this.disponible = new System.Windows.Forms.Label();
            this.chbDisponible = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tlpBotones, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbEscritor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTitulo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lEscritor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lAno_edicion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbSinopsis, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbTitulo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbAno_edicion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbSinop, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.disponible, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.chbDisponible, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tlpBotones, 2);
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btCancelar, 0, 0);
            this.tlpBotones.Controls.Add(this.btEditar, 1, 0);
            this.tlpBotones.Location = new System.Drawing.Point(17, 270);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(738, 26);
            this.tlpBotones.TabIndex = 18;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelar.Location = new System.Drawing.Point(2, 2);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(365, 22);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click_1);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btEditar.Location = new System.Drawing.Point(371, 2);
            this.btEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(365, 22);
            this.btEditar.TabIndex = 10;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lEidLibro, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(180, 100);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lEidLibro
            // 
            this.lEidLibro.AutoSize = true;
            this.lEidLibro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lEidLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lEidLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEidLibro.Location = new System.Drawing.Point(34, 40);
            this.lEidLibro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEidLibro.Name = "lEidLibro";
            this.lEidLibro.Size = new System.Drawing.Size(144, 20);
            this.lEidLibro.TabIndex = 3;
            this.lEidLibro.Text = "---";
            this.lEidLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbEscritor
            // 
            this.tbEscritor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEscritor.Location = new System.Drawing.Point(273, 177);
            this.tbEscritor.Margin = new System.Windows.Forms.Padding(2);
            this.tbEscritor.Name = "tbEscritor";
            this.tbEscritor.Size = new System.Drawing.Size(511, 20);
            this.tbEscritor.TabIndex = 9;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(16, 151);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(253, 24);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.Text = "Titulo";
            this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lEscritor
            // 
            this.lEscritor.AutoSize = true;
            this.lEscritor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lEscritor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lEscritor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEscritor.Location = new System.Drawing.Point(16, 175);
            this.lEscritor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEscritor.Name = "lEscritor";
            this.lEscritor.Size = new System.Drawing.Size(253, 24);
            this.lEscritor.TabIndex = 2;
            this.lEscritor.Text = "Escritor";
            this.lEscritor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lAno_edicion
            // 
            this.lAno_edicion.AutoSize = true;
            this.lAno_edicion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lAno_edicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAno_edicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAno_edicion.Location = new System.Drawing.Point(16, 199);
            this.lAno_edicion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAno_edicion.Name = "lAno_edicion";
            this.lAno_edicion.Size = new System.Drawing.Size(253, 24);
            this.lAno_edicion.TabIndex = 3;
            this.lAno_edicion.Text = "Año edicion";
            this.lAno_edicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSinopsis
            // 
            this.tbSinopsis.AutoSize = true;
            this.tbSinopsis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbSinopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSinopsis.Location = new System.Drawing.Point(16, 223);
            this.tbSinopsis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tbSinopsis.Name = "tbSinopsis";
            this.tbSinopsis.Size = new System.Drawing.Size(253, 24);
            this.tbSinopsis.TabIndex = 4;
            this.tbSinopsis.Text = "Sinopsis";
            this.tbSinopsis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitulo.Location = new System.Drawing.Point(273, 153);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(511, 20);
            this.tbTitulo.TabIndex = 6;
            // 
            // tbAno_edicion
            // 
            this.tbAno_edicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAno_edicion.Location = new System.Drawing.Point(273, 201);
            this.tbAno_edicion.Margin = new System.Windows.Forms.Padding(2);
            this.tbAno_edicion.Name = "tbAno_edicion";
            this.tbAno_edicion.Size = new System.Drawing.Size(511, 20);
            this.tbAno_edicion.TabIndex = 7;
            // 
            // tbSinop
            // 
            this.tbSinop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSinop.Location = new System.Drawing.Point(273, 225);
            this.tbSinop.Margin = new System.Windows.Forms.Padding(2);
            this.tbSinop.Name = "tbSinop";
            this.tbSinop.Size = new System.Drawing.Size(511, 20);
            this.tbSinop.TabIndex = 8;
            // 
            // disponible
            // 
            this.disponible.AutoSize = true;
            this.disponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponible.Location = new System.Drawing.Point(16, 247);
            this.disponible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.disponible.Name = "disponible";
            this.disponible.Size = new System.Drawing.Size(253, 20);
            this.disponible.TabIndex = 12;
            this.disponible.Text = "dispobible";
            // 
            // chbDisponible
            // 
            this.chbDisponible.AutoSize = true;
            this.chbDisponible.Location = new System.Drawing.Point(274, 250);
            this.chbDisponible.Name = "chbDisponible";
            this.chbDisponible.Size = new System.Drawing.Size(15, 14);
            this.chbDisponible.TabIndex = 19;
            this.chbDisponible.UseVisualStyleBackColor = true;
            // 
            // formularioEditarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formularioEditarLibro";
            this.Text = "formularioEditarLibro";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lEidLibro;
        public System.Windows.Forms.TextBox tbEscritor;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label lEscritor;
        private System.Windows.Forms.Label lAno_edicion;
        private System.Windows.Forms.Label tbSinopsis;
        public System.Windows.Forms.TextBox tbTitulo;
        public System.Windows.Forms.TextBox tbAno_edicion;
        public System.Windows.Forms.TextBox tbSinop;
        private System.Windows.Forms.Label disponible;
        public System.Windows.Forms.CheckBox chbDisponible;
    }
}