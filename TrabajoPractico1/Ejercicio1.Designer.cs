namespace TrabajoPractico1
{
    partial class Ejercicio1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIngreseUnNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbxIzquierda = new System.Windows.Forms.ListBox();
            this.lbxDerecha = new System.Windows.Forms.ListBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(476, 52);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(20, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIngreseUnNombre
            // 
            this.lblIngreseUnNombre.AutoSize = true;
            this.lblIngreseUnNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseUnNombre.Location = new System.Drawing.Point(59, 59);
            this.lblIngreseUnNombre.Margin = new System.Windows.Forms.Padding(50, 50, 2, 0);
            this.lblIngreseUnNombre.Name = "lblIngreseUnNombre";
            this.lblIngreseUnNombre.Size = new System.Drawing.Size(163, 18);
            this.lblIngreseUnNombre.TabIndex = 1;
            this.lblIngreseUnNombre.Text = "Ingrese un nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(226, 57);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lbxIzquierda
            // 
            this.lbxIzquierda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxIzquierda.FormattingEnabled = true;
            this.lbxIzquierda.Location = new System.Drawing.Point(62, 127);
            this.lbxIzquierda.Margin = new System.Windows.Forms.Padding(50);
            this.lbxIzquierda.Name = "lbxIzquierda";
            this.lbxIzquierda.Size = new System.Drawing.Size(196, 277);
            this.lbxIzquierda.TabIndex = 3;
            // 
            // lbxDerecha
            // 
            this.lbxDerecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxDerecha.FormattingEnabled = true;
            this.lbxDerecha.Location = new System.Drawing.Point(400, 127);
            this.lbxDerecha.Margin = new System.Windows.Forms.Padding(50);
            this.lbxDerecha.Name = "lbxDerecha";
            this.lbxDerecha.Size = new System.Drawing.Size(196, 277);
            this.lbxDerecha.TabIndex = 4;
            // 
            // btnUno
            // 
            this.btnUno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUno.Location = new System.Drawing.Point(293, 209);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(75, 23);
            this.btnUno.TabIndex = 5;
            this.btnUno.Text = ">";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTodos.Location = new System.Drawing.Point(293, 296);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 6;
            this.btnTodos.Text = ">>";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 445);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.lbxDerecha);
            this.Controls.Add(this.lbxIzquierda);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIngreseUnNombre);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(671, 800);
            this.MinimumSize = new System.Drawing.Size(671, 242);
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIngreseUnNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lbxIzquierda;
        private System.Windows.Forms.ListBox lbxDerecha;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnTodos;
    }
}