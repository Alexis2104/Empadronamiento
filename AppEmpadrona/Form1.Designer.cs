namespace AppEmpadrona
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
            this.btnEmpadronar = new System.Windows.Forms.Button();
            this.btnEmpadronados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpadronar
            // 
            this.btnEmpadronar.Location = new System.Drawing.Point(62, 91);
            this.btnEmpadronar.Name = "btnEmpadronar";
            this.btnEmpadronar.Size = new System.Drawing.Size(201, 159);
            this.btnEmpadronar.TabIndex = 0;
            this.btnEmpadronar.Text = "Empadronar";
            this.btnEmpadronar.UseVisualStyleBackColor = true;
            this.btnEmpadronar.Click += new System.EventHandler(this.btnEmpadronar_Click);
            // 
            // btnEmpadronados
            // 
            this.btnEmpadronados.Location = new System.Drawing.Point(296, 91);
            this.btnEmpadronados.Name = "btnEmpadronados";
            this.btnEmpadronados.Size = new System.Drawing.Size(186, 159);
            this.btnEmpadronados.TabIndex = 1;
            this.btnEmpadronados.Text = "Empadronados";
            this.btnEmpadronados.UseVisualStyleBackColor = true;
            this.btnEmpadronados.Click += new System.EventHandler(this.btnEmpadronados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmpadronados);
            this.Controls.Add(this.btnEmpadronar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpadronar;
        private System.Windows.Forms.Button btnEmpadronados;
    }
}

