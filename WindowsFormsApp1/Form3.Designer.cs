
namespace WindowsFormsApp1
{
    partial class Form_admin_equipos
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
            this.btn_crear_equipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_crear_equipo
            // 
            this.btn_crear_equipo.Location = new System.Drawing.Point(21, 12);
            this.btn_crear_equipo.Name = "btn_crear_equipo";
            this.btn_crear_equipo.Size = new System.Drawing.Size(126, 23);
            this.btn_crear_equipo.TabIndex = 0;
            this.btn_crear_equipo.Text = "Crear equipo";
            this.btn_crear_equipo.UseVisualStyleBackColor = true;
            this.btn_crear_equipo.Click += new System.EventHandler(this.btn_crear_equipo_Click);
            // 
            // Form_admin_equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.btn_crear_equipo);
            this.Name = "Form_admin_equipos";
            this.Text = "Administrar equipos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_equipo;
    }
}