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
            this.btnVerResumen = new System.Windows.Forms.Button();
            this.btnRegistrarPeaje = new System.Windows.Forms.Button();
            this.lsbVerResumen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVerResumen
            // 
            this.btnVerResumen.Location = new System.Drawing.Point(412, 137);
            this.btnVerResumen.Name = "btnVerResumen";
            this.btnVerResumen.Size = new System.Drawing.Size(138, 42);
            this.btnVerResumen.TabIndex = 1;
            this.btnVerResumen.Text = "Ver Resumen";
            this.btnVerResumen.UseVisualStyleBackColor = true;
            this.btnVerResumen.Click += new System.EventHandler(this.btnVerResumen_Click);
            // 
            // btnRegistrarPeaje
            // 
            this.btnRegistrarPeaje.Location = new System.Drawing.Point(412, 48);
            this.btnRegistrarPeaje.Name = "btnRegistrarPeaje";
            this.btnRegistrarPeaje.Size = new System.Drawing.Size(138, 46);
            this.btnRegistrarPeaje.TabIndex = 2;
            this.btnRegistrarPeaje.Text = "Registrar Peaje";
            this.btnRegistrarPeaje.UseVisualStyleBackColor = true;
            this.btnRegistrarPeaje.Click += new System.EventHandler(this.btnRegistrarPeaje_Click);
            // 
            // lsbVerResumen
            // 
            this.lsbVerResumen.FormattingEnabled = true;
            this.lsbVerResumen.Location = new System.Drawing.Point(27, 39);
            this.lsbVerResumen.Name = "lsbVerResumen";
            this.lsbVerResumen.Size = new System.Drawing.Size(379, 264);
            this.lsbVerResumen.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 358);
            this.Controls.Add(this.lsbVerResumen);
            this.Controls.Add(this.btnRegistrarPeaje);
            this.Controls.Add(this.btnVerResumen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVerResumen;
        private System.Windows.Forms.Button btnRegistrarPeaje;
        public System.Windows.Forms.ListBox lsbVerResumen;
    }
}

