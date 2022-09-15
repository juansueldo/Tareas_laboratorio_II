
namespace Ejercicio_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_apellido = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_saludar = new System.Windows.Forms.Button();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_apellido
            // 
            this.txb_apellido.Location = new System.Drawing.Point(360, 66);
            this.txb_apellido.Name = "txb_apellido";
            this.txb_apellido.PlaceholderText = "Ingrese el apellido";
            this.txb_apellido.Size = new System.Drawing.Size(135, 23);
            this.txb_apellido.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(87, 38);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(53, 15);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // btn_saludar
            // 
            this.btn_saludar.Location = new System.Drawing.Point(242, 173);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(90, 31);
            this.btn_saludar.TabIndex = 2;
            this.btn_saludar.Text = "Saludar";
            this.btn_saludar.UseVisualStyleBackColor = true;
            this.btn_saludar.Click += new System.EventHandler(this.btn_saludar_Click);
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(87, 66);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PlaceholderText = "Ingrese el nombre";
            this.txb_nombre.Size = new System.Drawing.Size(124, 23);
            this.txb_nombre.TabIndex = 3;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_apellido.Location = new System.Drawing.Point(360, 38);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(52, 15);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 306);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.btn_saludar);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txb_apellido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_saludar;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.Label lbl_apellido;
    }
}

