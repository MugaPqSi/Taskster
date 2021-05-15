
namespace WindowsFormsApp1
{
    partial class Form_nuevo_proyecto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nuevo_proyecto = new System.Windows.Forms.TextBox();
            this.list_tipo_proyecto = new System.Windows.Forms.ComboBox();
            this.txt_descripcion = new System.Windows.Forms.RichTextBox();
            this.btn_crear_proyecto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVO PROYECTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIPO PROYECTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESCRIPCIÓN";
            // 
            // txt_nuevo_proyecto
            // 
            this.txt_nuevo_proyecto.Location = new System.Drawing.Point(173, 28);
            this.txt_nuevo_proyecto.Name = "txt_nuevo_proyecto";
            this.txt_nuevo_proyecto.Size = new System.Drawing.Size(309, 22);
            this.txt_nuevo_proyecto.TabIndex = 3;
            // 
            // list_tipo_proyecto
            // 
            this.list_tipo_proyecto.FormattingEnabled = true;
            this.list_tipo_proyecto.Location = new System.Drawing.Point(173, 81);
            this.list_tipo_proyecto.Name = "list_tipo_proyecto";
            this.list_tipo_proyecto.Size = new System.Drawing.Size(309, 24);
            this.list_tipo_proyecto.TabIndex = 4;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(173, 162);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(309, 96);
            this.txt_descripcion.TabIndex = 5;
            this.txt_descripcion.Text = "";
            // 
            // btn_crear_proyecto
            // 
            this.btn_crear_proyecto.Location = new System.Drawing.Point(234, 289);
            this.btn_crear_proyecto.Name = "btn_crear_proyecto";
            this.btn_crear_proyecto.Size = new System.Drawing.Size(198, 59);
            this.btn_crear_proyecto.TabIndex = 6;
            this.btn_crear_proyecto.Text = "CREAR PROYECTO";
            this.btn_crear_proyecto.UseVisualStyleBackColor = true;
            // 
            // Form_nuevo_proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 385);
            this.Controls.Add(this.btn_crear_proyecto);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.list_tipo_proyecto);
            this.Controls.Add(this.txt_nuevo_proyecto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_nuevo_proyecto";
            this.Text = "Nuevo proyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nuevo_proyecto;
        private System.Windows.Forms.ComboBox list_tipo_proyecto;
        private System.Windows.Forms.RichTextBox txt_descripcion;
        private System.Windows.Forms.Button btn_crear_proyecto;
    }
}