
namespace WindowsFormsApp1
{
    partial class Form_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox_user = new System.Windows.Forms.TextBox();
            this.textbox_pass = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.link_regitrarse = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textbox_user
            // 
            this.textbox_user.Location = new System.Drawing.Point(347, 169);
            this.textbox_user.Name = "textbox_user";
            this.textbox_user.Size = new System.Drawing.Size(249, 22);
            this.textbox_user.TabIndex = 0;
            // 
            // textbox_pass
            // 
            this.textbox_pass.Location = new System.Drawing.Point(347, 302);
            this.textbox_pass.Name = "textbox_pass";
            this.textbox_pass.PasswordChar = '*';
            this.textbox_pass.Size = new System.Drawing.Size(249, 22);
            this.textbox_pass.TabIndex = 1;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(449, 149);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(61, 17);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "Usuario:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(435, 282);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(85, 17);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Contraseña:";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(422, 360);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(98, 31);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // link_regitrarse
            // 
            this.link_regitrarse.AutoSize = true;
            this.link_regitrarse.Location = new System.Drawing.Point(715, 556);
            this.link_regitrarse.Name = "link_regitrarse";
            this.link_regitrarse.Size = new System.Drawing.Size(220, 17);
            this.link_regitrarse.TabIndex = 5;
            this.link_regitrarse.TabStop = true;
            this.link_regitrarse.Text = "¿No tienes cuenta? Registrarse...";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 585);
            this.Controls.Add(this.link_regitrarse);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.textbox_pass);
            this.Controls.Add(this.textbox_user);
            this.Name = "Form_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_user;
        private System.Windows.Forms.TextBox textbox_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.LinkLabel link_regitrarse;
    }
}

