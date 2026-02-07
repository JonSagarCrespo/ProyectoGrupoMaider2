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
            this.SuspendLayout();
            // 
            // tlpPrincipalPrestamo
            // 
            this.tlpPrincipalPrestamo.ColumnCount = 2;
            this.tlpPrincipalPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipalPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipalPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipalPrestamo.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipalPrestamo.Name = "tlpPrincipalPrestamo";
            this.tlpPrincipalPrestamo.RowCount = 2;
            this.tlpPrincipalPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipalPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipalPrestamo.Size = new System.Drawing.Size(800, 450);
            this.tlpPrincipalPrestamo.TabIndex = 0;
            // 
            // FormularioPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpPrincipalPrestamo);
            this.Name = "FormularioPrestamo";
            this.Text = "FormularioPrestamo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipalPrestamo;
    }
}