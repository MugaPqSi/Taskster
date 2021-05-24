
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_proyecto = new System.Windows.Forms.TextBox();
            this.list_tipo_proyecto = new System.Windows.Forms.ComboBox();
            this.txt_descripcion = new System.Windows.Forms.RichTextBox();
            this.btn_crear_proyecto = new System.Windows.Forms.Button();
            this.admin_proyectosDataSet = new WindowsFormsApp1.admin_proyectosDataSet();
            this.tiposproyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipos_proyectosTableAdapter = new WindowsFormsApp1.admin_proyectosDataSetTableAdapters.tipos_proyectosTableAdapter();
            this.tiposproyectosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tiposproyectosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.admin_proyectosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposproyectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposproyectosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposproyectosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo proyecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // txt_nombre_proyecto
            // 
            this.txt_nombre_proyecto.Location = new System.Drawing.Point(173, 28);
            this.txt_nombre_proyecto.Name = "txt_nombre_proyecto";
            this.txt_nombre_proyecto.Size = new System.Drawing.Size(309, 22);
            this.txt_nombre_proyecto.TabIndex = 3;
            // 
            // list_tipo_proyecto
            // 
            this.list_tipo_proyecto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tiposproyectosBindingSource, "nombre", true));
            this.list_tipo_proyecto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tiposproyectosBindingSource1, "id_tipo", true));
            this.list_tipo_proyecto.DataSource = this.tiposproyectosBindingSource2;
            this.list_tipo_proyecto.DisplayMember = "nombre";
            this.list_tipo_proyecto.FormattingEnabled = true;
            this.list_tipo_proyecto.Location = new System.Drawing.Point(173, 81);
            this.list_tipo_proyecto.Name = "list_tipo_proyecto";
            this.list_tipo_proyecto.Size = new System.Drawing.Size(309, 24);
            this.list_tipo_proyecto.TabIndex = 4;
            this.list_tipo_proyecto.ValueMember = "id_tipo";
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
            this.btn_crear_proyecto.Click += new System.EventHandler(this.btn_crear_proyecto_Click);
            // 
            // admin_proyectosDataSet
            // 
            this.admin_proyectosDataSet.DataSetName = "admin_proyectosDataSet";
            this.admin_proyectosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposproyectosBindingSource
            // 
            this.tiposproyectosBindingSource.DataMember = "tipos_proyectos";
            this.tiposproyectosBindingSource.DataSource = this.admin_proyectosDataSet;
            // 
            // tipos_proyectosTableAdapter
            // 
            this.tipos_proyectosTableAdapter.ClearBeforeFill = true;
            // 
            // tiposproyectosBindingSource1
            // 
            this.tiposproyectosBindingSource1.DataMember = "tipos_proyectos";
            this.tiposproyectosBindingSource1.DataSource = this.admin_proyectosDataSet;
            // 
            // tiposproyectosBindingSource2
            // 
            this.tiposproyectosBindingSource2.DataMember = "tipos_proyectos";
            this.tiposproyectosBindingSource2.DataSource = this.admin_proyectosDataSet;
            // 
            // Form_nuevo_proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 385);
            this.Controls.Add(this.btn_crear_proyecto);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.list_tipo_proyecto);
            this.Controls.Add(this.txt_nombre_proyecto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_nuevo_proyecto";
            this.Text = "Nuevo proyecto";
            this.Load += new System.EventHandler(this.Form_nuevo_proyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_proyectosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposproyectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposproyectosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposproyectosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre_proyecto;
        private System.Windows.Forms.ComboBox list_tipo_proyecto;
        private System.Windows.Forms.RichTextBox txt_descripcion;
        private System.Windows.Forms.Button btn_crear_proyecto;
        private admin_proyectosDataSet admin_proyectosDataSet;
        private System.Windows.Forms.BindingSource tiposproyectosBindingSource;
        private admin_proyectosDataSetTableAdapters.tipos_proyectosTableAdapter tipos_proyectosTableAdapter;
        private System.Windows.Forms.BindingSource tiposproyectosBindingSource1;
        private System.Windows.Forms.BindingSource tiposproyectosBindingSource2;
    }
}