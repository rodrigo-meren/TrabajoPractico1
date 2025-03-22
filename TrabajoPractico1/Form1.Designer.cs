namespace TrabajoPractico1
{
    partial class inicio
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
            this.btnEj1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEj1
            // 
            this.btnEj1.BackColor = System.Drawing.SystemColors.Window;
            this.btnEj1.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnEj1.FlatAppearance.BorderSize = 2;
            this.btnEj1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEj1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEj1.Location = new System.Drawing.Point(150, 123);
            this.btnEj1.Name = "btnEj1";
            this.btnEj1.Size = new System.Drawing.Size(142, 58);
            this.btnEj1.TabIndex = 0;
            this.btnEj1.Text = "Ejercicio 1";
            this.btnEj1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Integrantes:";
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEj1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEj1;
        private System.Windows.Forms.Label label1;
    }
}

