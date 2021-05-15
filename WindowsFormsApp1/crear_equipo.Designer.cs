
namespace WindowsFormsApp1
{
    partial class Form_crear_equipo
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
            this.lbl_nombre_equipo = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.text_nombre_equipo = new System.Windows.Forms.TextBox();
            this.list_categoria = new System.Windows.Forms.ComboBox();
            this.text_descripcion = new System.Windows.Forms.RichTextBox();
            this.btn_crear_equipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombre_equipo
            // 
            this.lbl_nombre_equipo.AutoSize = true;
            this.lbl_nombre_equipo.Location = new System.Drawing.Point(32, 57);
            this.lbl_nombre_equipo.Name = "lbl_nombre_equipo";
            this.lbl_nombre_equipo.Size = new System.Drawing.Size(148, 17);
            this.lbl_nombre_equipo.TabIndex = 0;
            this.lbl_nombre_equipo.Text = "NOMBRE DE EQUIPO";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(32, 108);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(88, 17);
            this.lbl_categoria.TabIndex = 1;
            this.lbl_categoria.Text = "CATEGORIA";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(32, 168);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(100, 17);
            this.lbl_descripcion.TabIndex = 2;
            this.lbl_descripcion.Text = "DESCRIPCIÓN";
            // 
            // text_nombre_equipo
            // 
            this.text_nombre_equipo.Location = new System.Drawing.Point(207, 57);
            this.text_nombre_equipo.Name = "text_nombre_equipo";
            this.text_nombre_equipo.Size = new System.Drawing.Size(261, 22);
            this.text_nombre_equipo.TabIndex = 3;
            // 
            // list_categoria
            // 
            this.list_categoria.FormattingEnabled = true;
            this.list_categoria.Location = new System.Drawing.Point(207, 105);
            this.list_categoria.Name = "list_categoria";
            this.list_categoria.Size = new System.Drawing.Size(261, 24);
            this.list_categoria.TabIndex = 4;
            // 
            // text_descripcion
            // 
            this.text_descripcion.Location = new System.Drawing.Point(207, 165);
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(261, 96);
            this.text_descripcion.TabIndex = 5;
            this.text_descripcion.Text = "";
            // 
            // btn_crear_equipo
            // 
            this.btn_crear_equipo.Location = new System.Drawing.Point(281, 295);
            this.btn_crear_equipo.Name = "btn_crear_equipo";
            this.btn_crear_equipo.Size = new System.Drawing.Size(118, 46);
            this.btn_crear_equipo.TabIndex = 6;
            this.btn_crear_equipo.Text = "Crear equipo";
            this.btn_crear_equipo.UseVisualStyleBackColor = true;
            // 
            // Form_crear_equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 386);
            this.Controls.Add(this.btn_crear_equipo);
            this.Controls.Add(this.text_descripcion);
            this.Controls.Add(this.list_categoria);
            this.Controls.Add(this.text_nombre_equipo);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_nombre_equipo);
            this.Name = "Form_crear_equipo";
            this.Text = "crear_equipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre_equipo;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox text_nombre_equipo;
        private System.Windows.Forms.ComboBox list_categoria;
        private System.Windows.Forms.RichTextBox text_descripcion;
        private System.Windows.Forms.Button btn_crear_equipo;
    }
}