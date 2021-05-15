
namespace WindowsFormsApp1
{
    partial class Form_agregar_miembros
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
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.text_miembros = new System.Windows.Forms.RichTextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(137, 58);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(258, 22);
            this.txt_correo.TabIndex = 0;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(49, 61);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(68, 17);
            this.lbl_correo.TabIndex = 1;
            this.lbl_correo.Text = "CORREO";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(221, 96);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // text_miembros
            // 
            this.text_miembros.Location = new System.Drawing.Point(137, 136);
            this.text_miembros.Name = "text_miembros";
            this.text_miembros.Size = new System.Drawing.Size(258, 125);
            this.text_miembros.TabIndex = 4;
            this.text_miembros.Text = "";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(295, 287);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(100, 42);
            this.btn_enviar.TabIndex = 5;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            // 
            // Form_agregar_miembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 368);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.text_miembros);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.txt_correo);
            this.Name = "Form_agregar_miembros";
            this.Text = "Agregar miembros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.RichTextBox text_miembros;
        private System.Windows.Forms.Button btn_enviar;
    }
}