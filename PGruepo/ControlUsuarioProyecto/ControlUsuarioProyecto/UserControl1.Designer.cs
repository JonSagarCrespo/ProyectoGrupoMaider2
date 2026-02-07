namespace ControlUsuarioProyecto
{
    partial class ControlUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuario));
            this.tblpPricipal = new System.Windows.Forms.TableLayoutPanel();
            this.ckSeleccionar = new System.Windows.Forms.CheckBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.tblpPricipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpPricipal
            // 
            this.tblpPricipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblpPricipal.ColumnCount = 7;
            this.tblpPricipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tblpPricipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpPricipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpPricipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpPricipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblpPricipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblpPricipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblpPricipal.Controls.Add(this.ckSeleccionar, 1, 0);
            this.tblpPricipal.Controls.Add(this.btAgregar, 4, 0);
            this.tblpPricipal.Controls.Add(this.btEliminar, 5, 0);
            this.tblpPricipal.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tblpPricipal.Controls.Add(this.tableLayoutPanel2, 3, 0);
            this.tblpPricipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpPricipal.Location = new System.Drawing.Point(0, 0);
            this.tblpPricipal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tblpPricipal.Name = "tblpPricipal";
            this.tblpPricipal.RowCount = 1;
            this.tblpPricipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpPricipal.Size = new System.Drawing.Size(497, 60);
            this.tblpPricipal.TabIndex = 0;
            // 
            // ckSeleccionar
            // 
            this.ckSeleccionar.AutoSize = true;
            this.ckSeleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckSeleccionar.Location = new System.Drawing.Point(17, 2);
            this.ckSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.ckSeleccionar.Name = "ckSeleccionar";
            this.ckSeleccionar.Size = new System.Drawing.Size(15, 56);
            this.ckSeleccionar.TabIndex = 0;
            this.ckSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btAgregar.Image")));
            this.btAgregar.Location = new System.Drawing.Point(388, 2);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(41, 56);
            this.btAgregar.TabIndex = 3;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click_1);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btEliminar.Image")));
            this.btEliminar.Location = new System.Drawing.Point(433, 2);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(41, 56);
            this.btEliminar.TabIndex = 4;
            this.btEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(172, 56);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Location = new System.Drawing.Point(2, 22);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtApellido, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(212, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(172, 56);
            this.tableLayoutPanel2.TabIndex = 6;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // txtApellido
            // 
            this.txtApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApellido.Location = new System.Drawing.Point(2, 22);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(168, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // ControlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblpPricipal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ControlUsuario";
            this.Size = new System.Drawing.Size(497, 60);
            this.tblpPricipal.ResumeLayout(false);
            this.tblpPricipal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpPricipal;
        private System.Windows.Forms.CheckBox ckSeleccionar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtApellido;
    }
}
