namespace TrabajoPractico1
{
    partial class Ejercicio3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio3));
            this.gboxSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.gboxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.chkLbOficios = new System.Windows.Forms.CheckedListBox();
            this.gboxSexo.SuspendLayout();
            this.gboxEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSexo
            // 
            this.gboxSexo.AutoSize = true;
            this.gboxSexo.BackColor = System.Drawing.SystemColors.Menu;
            this.gboxSexo.Controls.Add(this.rbMasculino);
            this.gboxSexo.Controls.Add(this.rbFemenino);
            this.gboxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSexo.Location = new System.Drawing.Point(43, 34);
            this.gboxSexo.Name = "gboxSexo";
            this.gboxSexo.Size = new System.Drawing.Size(104, 83);
            this.gboxSexo.TabIndex = 0;
            this.gboxSexo.TabStop = false;
            this.gboxSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 42);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(86, 20);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Location = new System.Drawing.Point(6, 19);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(85, 20);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // gboxEstadoCivil
            // 
            this.gboxEstadoCivil.Controls.Add(this.rbSoltero);
            this.gboxEstadoCivil.Controls.Add(this.rbCasado);
            this.gboxEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxEstadoCivil.Location = new System.Drawing.Point(318, 34);
            this.gboxEstadoCivil.Name = "gboxEstadoCivil";
            this.gboxEstadoCivil.Size = new System.Drawing.Size(104, 83);
            this.gboxEstadoCivil.TabIndex = 1;
            this.gboxEstadoCivil.TabStop = false;
            this.gboxEstadoCivil.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(6, 42);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(68, 20);
            this.rbSoltero.TabIndex = 1;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(6, 19);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(73, 20);
            this.rbCasado.TabIndex = 0;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // chkLbOficios
            // 
            this.chkLbOficios.CheckOnClick = true;
            this.chkLbOficios.FormattingEnabled = true;
            this.chkLbOficios.Items.AddRange(new object[] {
            "Data Enty",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.chkLbOficios.Location = new System.Drawing.Point(137, 133);
            this.chkLbOficios.Name = "chkLbOficios";
            this.chkLbOficios.Size = new System.Drawing.Size(189, 94);
            this.chkLbOficios.TabIndex = 2;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.chkLbOficios);
            this.Controls.Add(this.gboxEstadoCivil);
            this.Controls.Add(this.gboxSexo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio3_FormClosed);
            this.gboxSexo.ResumeLayout(false);
            this.gboxSexo.PerformLayout();
            this.gboxEstadoCivil.ResumeLayout(false);
            this.gboxEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.GroupBox gboxEstadoCivil;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.CheckedListBox chkLbOficios;
    }
}