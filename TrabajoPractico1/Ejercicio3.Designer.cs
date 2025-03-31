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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEstCivil = new System.Windows.Forms.Label();
            this.lblOficio = new System.Windows.Forms.Label();
            this.lbOficios = new System.Windows.Forms.ListBox();
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
            this.gboxSexo.Location = new System.Drawing.Point(57, 42);
            this.gboxSexo.Margin = new System.Windows.Forms.Padding(4);
            this.gboxSexo.Name = "gboxSexo";
            this.gboxSexo.Padding = new System.Windows.Forms.Padding(4);
            this.gboxSexo.Size = new System.Drawing.Size(139, 103);
            this.gboxSexo.TabIndex = 0;
            this.gboxSexo.TabStop = false;
            this.gboxSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(8, 52);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(106, 24);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Location = new System.Drawing.Point(8, 23);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(103, 24);
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
            this.gboxEstadoCivil.Location = new System.Drawing.Point(424, 42);
            this.gboxEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.gboxEstadoCivil.Name = "gboxEstadoCivil";
            this.gboxEstadoCivil.Padding = new System.Windows.Forms.Padding(4);
            this.gboxEstadoCivil.Size = new System.Drawing.Size(139, 102);
            this.gboxEstadoCivil.TabIndex = 1;
            this.gboxEstadoCivil.TabStop = false;
            this.gboxEstadoCivil.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(8, 52);
            this.rbSoltero.Margin = new System.Windows.Forms.Padding(4);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(97, 24);
            this.rbSoltero.TabIndex = 1;
            this.rbSoltero.Text = "Soltero/a";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(8, 23);
            this.rbCasado.Margin = new System.Windows.Forms.Padding(4);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(101, 24);
            this.rbCasado.TabIndex = 0;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado/a";
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
            this.chkLbOficios.Location = new System.Drawing.Point(183, 164);
            this.chkLbOficios.Margin = new System.Windows.Forms.Padding(4);
            this.chkLbOficios.Name = "chkLbOficios";
            this.chkLbOficios.Size = new System.Drawing.Size(251, 106);
            this.chkLbOficios.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(199, 308);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 25, 4, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(215, 28);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar lo que se seleccionó";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.Location = new System.Drawing.Point(60, 364);
            this.lblMostrar.Margin = new System.Windows.Forms.Padding(4, 25, 4, 0);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(0, 25);
            this.lblMostrar.TabIndex = 4;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(60, 399);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 25, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(0, 25);
            this.lblSexo.TabIndex = 5;
            // 
            // lblEstCivil
            // 
            this.lblEstCivil.AutoSize = true;
            this.lblEstCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstCivil.Location = new System.Drawing.Point(60, 431);
            this.lblEstCivil.Margin = new System.Windows.Forms.Padding(4, 25, 4, 0);
            this.lblEstCivil.Name = "lblEstCivil";
            this.lblEstCivil.Size = new System.Drawing.Size(0, 25);
            this.lblEstCivil.TabIndex = 6;
            // 
            // lblOficio
            // 
            this.lblOficio.AutoSize = true;
            this.lblOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOficio.Location = new System.Drawing.Point(60, 465);
            this.lblOficio.Margin = new System.Windows.Forms.Padding(4, 25, 4, 0);
            this.lblOficio.Name = "lblOficio";
            this.lblOficio.Size = new System.Drawing.Size(0, 25);
            this.lblOficio.TabIndex = 7;
            // 
            // lbOficios
            // 
            this.lbOficios.BackColor = System.Drawing.SystemColors.Control;
            this.lbOficios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbOficios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOficios.FormattingEnabled = true;
            this.lbOficios.ItemHeight = 25;
            this.lbOficios.Location = new System.Drawing.Point(80, 506);
            this.lbOficios.Name = "lbOficios";
            this.lbOficios.Size = new System.Drawing.Size(325, 150);
            this.lbOficios.TabIndex = 8;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 688);
            this.Controls.Add(this.lbOficios);
            this.Controls.Add(this.lblOficio);
            this.Controls.Add(this.lblEstCivil);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.chkLbOficios);
            this.Controls.Add(this.gboxEstadoCivil);
            this.Controls.Add(this.gboxSexo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEstCivil;
        private System.Windows.Forms.Label lblOficio;
        private System.Windows.Forms.ListBox lbOficios;
    }
}