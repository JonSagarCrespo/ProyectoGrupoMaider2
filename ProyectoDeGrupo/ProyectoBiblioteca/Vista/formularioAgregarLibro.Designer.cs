namespace ProyectoBiblioteca.Vista
{
    partial class formularioAgregarLibro
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbEscritor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.lEscritor = new System.Windows.Forms.Label();
            this.lAno_edicion = new System.Windows.Forms.Label();
            this.lbSinosis = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbAno_edicion = new System.Windows.Forms.TextBox();
            this.tbSinopsis = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.lbDisponible = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.ckDisponible = new System.Windows.Forms.CheckBox();
            this.tlpPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(800, 450);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tbEscritor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTitulo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lEscritor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lAno_edicion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbSinosis, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbTitulo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbAno_edicion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbSinopsis, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btGuardar, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbDisponible, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btLimpiar, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btCancelar, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ckDisponible, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(19, 16, 19, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(19, 16, 19, 16);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 418);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tbEscritor
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbEscritor, 2);
            this.tbEscritor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEscritor.Location = new System.Drawing.Point(203, 154);
            this.tbEscritor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEscritor.Name = "tbEscritor";
            this.tbEscritor.Size = new System.Drawing.Size(537, 22);
            this.tbEscritor.TabIndex = 9;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(22, 126);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(175, 26);
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
            this.lEscritor.Location = new System.Drawing.Point(22, 152);
            this.lEscritor.Name = "lEscritor";
            this.lEscritor.Size = new System.Drawing.Size(175, 26);
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
            this.lAno_edicion.Location = new System.Drawing.Point(22, 178);
            this.lAno_edicion.Name = "lAno_edicion";
            this.lAno_edicion.Size = new System.Drawing.Size(175, 26);
            this.lAno_edicion.TabIndex = 3;
            this.lAno_edicion.Text = "Año edicion";
            this.lAno_edicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSinosis
            // 
            this.lbSinosis.AutoSize = true;
            this.lbSinosis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSinosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSinosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSinosis.Location = new System.Drawing.Point(22, 204);
            this.lbSinosis.Name = "lbSinosis";
            this.lbSinosis.Size = new System.Drawing.Size(175, 26);
            this.lbSinosis.TabIndex = 4;
            this.lbSinosis.Text = "Sinopsis";
            this.lbSinosis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTitulo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbTitulo, 2);
            this.tbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitulo.Location = new System.Drawing.Point(203, 128);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(537, 22);
            this.tbTitulo.TabIndex = 6;
            // 
            // tbAno_edicion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbAno_edicion, 2);
            this.tbAno_edicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAno_edicion.Location = new System.Drawing.Point(203, 180);
            this.tbAno_edicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAno_edicion.Name = "tbAno_edicion";
            this.tbAno_edicion.Size = new System.Drawing.Size(537, 22);
            this.tbAno_edicion.TabIndex = 7;
            // 
            // tbSinopsis
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbSinopsis, 2);
            this.tbSinopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSinopsis.Location = new System.Drawing.Point(203, 206);
            this.tbSinopsis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSinopsis.Name = "tbSinopsis";
            this.tbSinopsis.Size = new System.Drawing.Size(537, 22);
            this.tbSinopsis.TabIndex = 8;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btGuardar.Location = new System.Drawing.Point(203, 255);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(356, 35);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // lbDisponible
            // 
            this.lbDisponible.AutoSize = true;
            this.lbDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisponible.Location = new System.Drawing.Point(22, 230);
            this.lbDisponible.Name = "lbDisponible";
            this.lbDisponible.Size = new System.Drawing.Size(175, 23);
            this.lbDisponible.TabIndex = 12;
            this.lbDisponible.Text = "dispobible";
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLimpiar.Location = new System.Drawing.Point(565, 255);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(175, 34);
            this.btLimpiar.TabIndex = 13;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelar.Location = new System.Drawing.Point(22, 255);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(175, 34);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ckDisponible
            // 
            this.ckDisponible.AutoSize = true;
            this.ckDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckDisponible.Location = new System.Drawing.Point(203, 233);
            this.ckDisponible.Name = "ckDisponible";
            this.ckDisponible.Size = new System.Drawing.Size(356, 17);
            this.ckDisponible.TabIndex = 15;
            this.ckDisponible.UseVisualStyleBackColor = true;
            this.ckDisponible.CheckedChanged += new System.EventHandler(this.ckDisponible_CheckedChanged);
            // 
            // formularioAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formularioAgregarLibro";
            this.Text = "formularioAgregarLibro";
            this.Load += new System.EventHandler(this.formularioAgregarLibro_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbEscritor;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label lEscritor;
        private System.Windows.Forms.Label lAno_edicion;
        private System.Windows.Forms.Label lbSinosis;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbAno_edicion;
        private System.Windows.Forms.TextBox tbSinopsis;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label lbDisponible;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.CheckBox ckDisponible;
    }
}