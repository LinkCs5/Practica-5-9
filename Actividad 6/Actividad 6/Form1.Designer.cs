namespace Actividad_6
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPalabraInvertida = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalabraInvertida
            // 
            this.lblPalabraInvertida.AutoSize = true;
            this.lblPalabraInvertida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPalabraInvertida.Location = new System.Drawing.Point(472, 90);
            this.lblPalabraInvertida.Name = "lblPalabraInvertida";
            this.lblPalabraInvertida.Size = new System.Drawing.Size(35, 13);
            this.lblPalabraInvertida.TabIndex = 0;
            this.lblPalabraInvertida.Text = "label1";
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(110, 83);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(100, 20);
            this.txtPalabra.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Invertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(613, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.lblPalabraInvertida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalabraInvertida;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button button1;
    }
}

