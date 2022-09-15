
namespace Ejercicio_02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_edad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lst_pais = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_nobinario = new System.Windows.Forms.RadioButton();
            this.rbtn_femenino = new System.Windows.Forms.RadioButton();
            this.rbtn_masculino = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chb_javascript = new System.Windows.Forms.CheckBox();
            this.chb_c = new System.Windows.Forms.CheckBox();
            this.chb_csharp = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_edad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txb_direccion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(66, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del usuario";
            // 
            // nud_edad
            // 
            this.nud_edad.Location = new System.Drawing.Point(96, 112);
            this.nud_edad.Name = "nud_edad";
            this.nud_edad.Size = new System.Drawing.Size(100, 23);
            this.nud_edad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(96, 72);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(100, 23);
            this.txb_direccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(96, 31);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(100, 23);
            this.txb_nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pais";
            // 
            // lst_pais
            // 
            this.lst_pais.FormattingEnabled = true;
            this.lst_pais.ItemHeight = 15;
            this.lst_pais.Location = new System.Drawing.Point(92, 232);
            this.lst_pais.Name = "lst_pais";
            this.lst_pais.Size = new System.Drawing.Size(243, 109);
            this.lst_pais.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_nobinario);
            this.groupBox2.Controls.Add(this.rbtn_femenino);
            this.groupBox2.Controls.Add(this.rbtn_masculino);
            this.groupBox2.Location = new System.Drawing.Point(398, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 135);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genero";
            // 
            // rbtn_nobinario
            // 
            this.rbtn_nobinario.AutoSize = true;
            this.rbtn_nobinario.Location = new System.Drawing.Point(17, 93);
            this.rbtn_nobinario.Name = "rbtn_nobinario";
            this.rbtn_nobinario.Size = new System.Drawing.Size(81, 19);
            this.rbtn_nobinario.TabIndex = 2;
            this.rbtn_nobinario.TabStop = true;
            this.rbtn_nobinario.Text = "No binario";
            this.rbtn_nobinario.UseVisualStyleBackColor = true;
            // 
            // rbtn_femenino
            // 
            this.rbtn_femenino.AutoSize = true;
            this.rbtn_femenino.Location = new System.Drawing.Point(17, 61);
            this.rbtn_femenino.Name = "rbtn_femenino";
            this.rbtn_femenino.Size = new System.Drawing.Size(78, 19);
            this.rbtn_femenino.TabIndex = 1;
            this.rbtn_femenino.TabStop = true;
            this.rbtn_femenino.Text = "Femenino";
            this.rbtn_femenino.UseVisualStyleBackColor = true;
            // 
            // rbtn_masculino
            // 
            this.rbtn_masculino.AutoSize = true;
            this.rbtn_masculino.Location = new System.Drawing.Point(17, 32);
            this.rbtn_masculino.Name = "rbtn_masculino";
            this.rbtn_masculino.Size = new System.Drawing.Size(80, 19);
            this.rbtn_masculino.TabIndex = 0;
            this.rbtn_masculino.TabStop = true;
            this.rbtn_masculino.Text = "Masculino";
            this.rbtn_masculino.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chb_javascript);
            this.groupBox3.Controls.Add(this.chb_c);
            this.groupBox3.Controls.Add(this.chb_csharp);
            this.groupBox3.Location = new System.Drawing.Point(398, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 132);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cursos";
            // 
            // chb_javascript
            // 
            this.chb_javascript.AutoSize = true;
            this.chb_javascript.Location = new System.Drawing.Point(17, 93);
            this.chb_javascript.Name = "chb_javascript";
            this.chb_javascript.Size = new System.Drawing.Size(78, 19);
            this.chb_javascript.TabIndex = 2;
            this.chb_javascript.Text = "JavaScript";
            this.chb_javascript.UseVisualStyleBackColor = true;
            // 
            // chb_c
            // 
            this.chb_c.AutoSize = true;
            this.chb_c.Location = new System.Drawing.Point(17, 57);
            this.chb_c.Name = "chb_c";
            this.chb_c.Size = new System.Drawing.Size(50, 19);
            this.chb_c.TabIndex = 1;
            this.chb_c.Text = "C++";
            this.chb_c.UseVisualStyleBackColor = true;
            // 
            // chb_csharp
            // 
            this.chb_csharp.AutoSize = true;
            this.chb_csharp.Location = new System.Drawing.Point(17, 22);
            this.chb_csharp.Name = "chb_csharp";
            this.chb_csharp.Size = new System.Drawing.Size(41, 19);
            this.chb_csharp.TabIndex = 0;
            this.chb_csharp.Text = "C#";
            this.chb_csharp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lst_pais);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_edad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lst_pais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_nobinario;
        private System.Windows.Forms.RadioButton rbtn_femenino;
        private System.Windows.Forms.RadioButton rbtn_masculino;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chb_javascript;
        private System.Windows.Forms.CheckBox chb_c;
        private System.Windows.Forms.CheckBox chb_csharp;
        private System.Windows.Forms.Button button1;
    }
}