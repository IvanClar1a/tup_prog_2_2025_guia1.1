namespace Sistema_de_peaje
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVerResumen = new System.Windows.Forms.Button();
            this.btnRegistrarPeaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 280);
            this.textBox1.TabIndex = 0;
            // 
            // btnVerResumen
            // 
            this.btnVerResumen.Location = new System.Drawing.Point(325, 139);
            this.btnVerResumen.Name = "btnVerResumen";
            this.btnVerResumen.Size = new System.Drawing.Size(138, 42);
            this.btnVerResumen.TabIndex = 1;
            this.btnVerResumen.Text = "Ver Resumen";
            this.btnVerResumen.UseVisualStyleBackColor = true;
            this.btnVerResumen.Click += new System.EventHandler(this.btnVerResumen_Click);
            // 
            // btnRegistrarPeaje
            // 
            this.btnRegistrarPeaje.Location = new System.Drawing.Point(325, 47);
            this.btnRegistrarPeaje.Name = "btnRegistrarPeaje";
            this.btnRegistrarPeaje.Size = new System.Drawing.Size(138, 46);
            this.btnRegistrarPeaje.TabIndex = 2;
            this.btnRegistrarPeaje.Text = "Registrar Peaje";
            this.btnRegistrarPeaje.UseVisualStyleBackColor = true;
            this.btnRegistrarPeaje.Click += new System.EventHandler(this.btnRegistrarPeaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 358);
            this.Controls.Add(this.btnRegistrarPeaje);
            this.Controls.Add(this.btnVerResumen);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVerResumen;
        private System.Windows.Forms.Button btnRegistrarPeaje;
    }
}

