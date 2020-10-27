namespace CesarM
{
    partial class Form1
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
            this.txtlistas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesifrar = new System.Windows.Forms.Button();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtlistas
            // 
            this.txtlistas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlistas.FormattingEnabled = true;
            this.txtlistas.Location = new System.Drawing.Point(25, 241);
            this.txtlistas.Name = "txtlistas";
            this.txtlistas.Size = new System.Drawing.Size(252, 91);
            this.txtlistas.TabIndex = 12;
            this.txtlistas.SelectedIndexChanged += new System.EventHandler(this.txtlistas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cifrado";
            // 
            // btnDesifrar
            // 
            this.btnDesifrar.Location = new System.Drawing.Point(25, 136);
            this.btnDesifrar.Name = "btnDesifrar";
            this.btnDesifrar.Size = new System.Drawing.Size(75, 23);
            this.btnDesifrar.TabIndex = 10;
            this.btnDesifrar.Text = "Desifrar";
            this.btnDesifrar.UseVisualStyleBackColor = true;
            this.btnDesifrar.Click += new System.EventHandler(this.btnDesifrar_Click);
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(25, 90);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(75, 23);
            this.btnCifrar.TabIndex = 9;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(103, 5);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(79, 24);
            this.Label.TabIndex = 8;
            this.Label.Text = "Cifrado";
            this.Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(53, 32);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(193, 39);
            this.txtCadena.TabIndex = 7;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(188, 90);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 13;
            this.buttonLimpiar.Text = "Eliminar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.Eliminar);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Salir);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Limpiar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(336, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.txtlistas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDesifrar);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.txtCadena);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox txtlistas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDesifrar;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Label Label;
        public System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

