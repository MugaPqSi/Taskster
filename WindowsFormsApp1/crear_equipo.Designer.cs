
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
            this.components = new System.ComponentModel.Container();
            this.lbl_nombre_equipo = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.text_nombre_equipo = new System.Windows.Forms.TextBox();
            this.list_categoria = new System.Windows.Forms.ComboBox();
            this.text_descripcion = new System.Windows.Forms.RichTextBox();
            this.btn_crear_equipo = new System.Windows.Forms.Button();
            this.admin_proyectosDataSet = new WindowsFormsApp1.admin_proyectosDataSet();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new WindowsFormsApp1.admin_proyectosDataSetTableAdapters.categoriasTableAdapter();
            this.categoriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.admin_proyectosDataSet1 = new WindowsFormsApp1.admin_proyectosDataSet();
            this.categoriasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.admin_proyectosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_proyectosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource3)).BeginInit();
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
            this.list_categoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.categoriasBindingSource, "nombre_categoria", true));
            this.list_categoria.DataSource = this.categoriasBindingSource3;
            this.list_categoria.DisplayMember = "nombre_categoria";
            this.list_categoria.FormattingEnabled = true;
            this.list_categoria.Location = new System.Drawing.Point(207, 105);
            this.list_categoria.Name = "list_categoria";
            this.list_categoria.Size = new System.Drawing.Size(261, 24);
            this.list_categoria.TabIndex = 4;
            this.list_categoria.ValueMember = "id_categoria";
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
            this.btn_crear_equipo.Click += new System.EventHandler(this.btn_crear_equipo_Click);
            // 
            // admin_proyectosDataSet
            // 
            this.admin_proyectosDataSet.DataSetName = "admin_proyectosDataSet";
            this.admin_proyectosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.admin_proyectosDataSet;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // categoriasBindingSource1
            // 
            this.categoriasBindingSource1.DataMember = "categorias";
            this.categoriasBindingSource1.DataSource = this.admin_proyectosDataSet;
            // 
            // admin_proyectosDataSet1
            // 
            this.admin_proyectosDataSet1.DataSetName = "admin_proyectosDataSet";
            this.admin_proyectosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource2
            // 
            this.categoriasBindingSource2.DataMember = "categorias";
            this.categoriasBindingSource2.DataSource = this.admin_proyectosDataSet1;
            // 
            // categoriasBindingSource3
            // 
            this.categoriasBindingSource3.DataMember = "categorias";
            this.categoriasBindingSource3.DataSource = this.admin_proyectosDataSet1;
            // 
            // Form_crear_equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 386);
            this.Controls.Add(this.btn_crear_equipo);
            this.Controls.Add(this.text_descripcion);
            this.Controls.Add(this.list_categoria);
            this.Controls.Add(this.text_nombre_equipo);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_nombre_equipo);
            this.Name = "Form_crear_equipo";
            this.Text = "crear_equipo";
            this.Load += new System.EventHandler(this.Form_crear_equipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_proyectosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_proyectosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource3)).EndInit();
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
        private admin_proyectosDataSet admin_proyectosDataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private admin_proyectosDataSetTableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.BindingSource categoriasBindingSource1;
        private admin_proyectosDataSet admin_proyectosDataSet1;
        private System.Windows.Forms.BindingSource categoriasBindingSource2;
        private System.Windows.Forms.BindingSource categoriasBindingSource3;
    }
}