namespace Sistema_de_peaje
{
    partial class CargarPeaje
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
            this.btnaceptas = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.tbCantidadAutos = new System.Windows.Forms.TextBox();
            this.tbDias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaceptas
            // 
            this.btnaceptas.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnaceptas.Location = new System.Drawing.Point(29, 172);
            this.btnaceptas.Name = "btnaceptas";
            this.btnaceptas.Size = new System.Drawing.Size(75, 23);
            this.btnaceptas.TabIndex = 0;
            this.btnaceptas.Text = "Aceptar";
            this.btnaceptas.UseVisualStyleBackColor = true;
            // 
            // bntCancelar
            // 
            this.bntCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntCancelar.Location = new System.Drawing.Point(149, 172);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 1;
            this.bntCancelar.Text = "Cerrar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // tbCantidadAutos
            // 
            this.tbCantidadAutos.Location = new System.Drawing.Point(124, 106);
            this.tbCantidadAutos.Name = "tbCantidadAutos";
            this.tbCantidadAutos.Size = new System.Drawing.Size(100, 20);
            this.tbCantidadAutos.TabIndex = 2;
            // 
            // tbDias
            // 
            this.tbDias.Location = new System.Drawing.Point(124, 58);
            this.tbDias.Name = "tbDias";
            this.tbDias.Size = new System.Drawing.Size(100, 20);
            this.tbDias.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad de autos:";
            // 
            // CargarPeaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDias);
            this.Controls.Add(this.tbCantidadAutos);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.btnaceptas);
            this.Name = "CargarPeaje";
            this.Text = "CargarPeaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptas;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbCantidadAutos;
        public System.Windows.Forms.TextBox tbDias;
    }
}