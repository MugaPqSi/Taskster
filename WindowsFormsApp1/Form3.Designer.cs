
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
            this.components = new System.ComponentModel.Container();
            this.btn_crear_equipo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admin_proyectosDataSet = new WindowsFormsApp1.admin_proyectosDataSet();
            this.equiposTableAdapter = new WindowsFormsApp1.admin_proyectosDataSetTableAdapters.equiposTableAdapter();
            this.admin_proyectosDataSet1 = new WindowsFormsApp1.admin_proyectosDataSet();
            this.vistaequiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_equiposTableAdapter = new WindowsFormsApp1.admin_proyectosDataSetTableAdapters.vista_equiposTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_proyectosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_proyectosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaequiposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crear_equipo
            // 
            this.btn_crear_equipo.Location = new System.Drawing.Point(647, 389);
            this.btn_crear_equipo.Name = "btn_crear_equipo";
            this.btn_crear_equipo.Size = new System.Drawing.Size(126, 41);
            this.btn_crear_equipo.TabIndex = 0;
            this.btn_crear_equipo.Text = "Crear equipo";
            this.btn_crear_equipo.UseVisualStyleBackColor = true;
            this.btn_crear_equipo.Click += new System.EventHandler(this.btn_crear_equipo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.nombre_categoria,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vistaequiposBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 310);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(21, 13);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(114, 26);
            this.btn_regresar.TabIndex = 2;
            this.btn_regresar.Text = "< Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "equipos";
            this.equiposBindingSource.DataSource = this.admin_proyectosDataSet;
            // 
            // admin_proyectosDataSet
            // 
            this.admin_proyectosDataSet.DataSetName = "admin_proyectosDataSet";
            this.admin_proyectosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // admin_proyectosDataSet1
            // 
            this.admin_proyectosDataSet1.DataSetName = "admin_proyectosDataSet";
            this.admin_proyectosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaequiposBindingSource
            // 
            this.vistaequiposBindingSource.DataMember = "vista_equipos";
            this.vistaequiposBindingSource.DataSource = this.admin_proyectosDataSet1;
            // 
            // vista_equiposTableAdapter
            // 
            this.vista_equiposTableAdapter.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombre_categoria
            // 
            this.nombre_categoria.DataPropertyName = "nombre_categoria";
            this.nombre_categoria.HeaderText = "nombre_categoria";
            this.nombre_categoria.MinimumWidth = 6;
            this.nombre_categoria.Name = "nombre_categoria";
            this.nombre_categoria.ReadOnly = true;
            this.nombre_categoria.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form_admin_equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_crear_equipo);
            this.Name = "Form_admin_equipos";
            this.Text = "Administrar equipos";
            this.Load += new System.EventHandler(this.Form_admin_equipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_proyectosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_proyectosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaequiposBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_equipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private admin_proyectosDataSet admin_proyectosDataSet;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private admin_proyectosDataSetTableAdapters.equiposTableAdapter equiposTableAdapter;
        private System.Windows.Forms.Button btn_regresar;
        private admin_proyectosDataSet admin_proyectosDataSet1;
        private System.Windows.Forms.BindingSource vistaequiposBindingSource;
        private admin_proyectosDataSetTableAdapters.vista_equiposTableAdapter vista_equiposTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}