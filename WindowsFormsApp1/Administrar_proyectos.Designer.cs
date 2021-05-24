
namespace WindowsFormsApp1
{
    partial class Form_administrar_proyectos
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
            this.lbl_proyectos = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_equipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_proyectosDataSet = new WindowsFormsApp1.admin_proyectosDataSet();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter = new WindowsFormsApp1.admin_proyectosDataSetTableAdapters.equiposTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.admin_proyectosDataSetTableAdapters.TableAdapterManager();
            this.proyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectosTableAdapter = new WindowsFormsApp1.admin_proyectosDataSetTableAdapters.proyectosTableAdapter();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.admin_proyectosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_proyectos
            // 
            this.lbl_proyectos.AutoSize = true;
            this.lbl_proyectos.Location = new System.Drawing.Point(63, 56);
            this.lbl_proyectos.Name = "lbl_proyectos";
            this.lbl_proyectos.Size = new System.Drawing.Size(94, 17);
            this.lbl_proyectos.TabIndex = 0;
            this.lbl_proyectos.Text = "PROYECTOS";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.proyectosBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(411, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "id_proyecto";
            // 
            // lbl_equipo
            // 
            this.lbl_equipo.AutoSize = true;
            this.lbl_equipo.Location = new System.Drawing.Point(943, 33);
            this.lbl_equipo.Name = "lbl_equipo";
            this.lbl_equipo.Size = new System.Drawing.Size(157, 17);
            this.lbl_equipo.TabIndex = 2;
            this.lbl_equipo.Text = "EQUIPO: ......................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ETAPAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "TAREAS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // admin_proyectosDataSet
            // 
            this.admin_proyectosDataSet.DataSetName = "admin_proyectosDataSet";
            this.admin_proyectosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "equipos";
            this.equiposBindingSource.DataSource = this.admin_proyectosDataSet;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.equiposTableAdapter = this.equiposTableAdapter;
            this.tableAdapterManager.proyectosTableAdapter = this.proyectosTableAdapter;
            this.tableAdapterManager.tipos_proyectosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.admin_proyectosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // proyectosBindingSource
            // 
            this.proyectosBindingSource.DataMember = "proyectos";
            this.proyectosBindingSource.DataSource = this.admin_proyectosDataSet;
            // 
            // proyectosTableAdapter
            // 
            this.proyectosTableAdapter.ClearBeforeFill = true;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(28, 12);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 26);
            this.btn_regresar.TabIndex = 6;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // Form_administrar_proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 499);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_equipo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_proyectos);
            this.Name = "Form_administrar_proyectos";
            this.Text = "Administrar_proyectos";
            this.Load += new System.EventHandler(this.Form_administrar_proyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_proyectosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_proyectos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_equipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private admin_proyectosDataSet admin_proyectosDataSet;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private admin_proyectosDataSetTableAdapters.equiposTableAdapter equiposTableAdapter;
        private admin_proyectosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private admin_proyectosDataSetTableAdapters.proyectosTableAdapter proyectosTableAdapter;
        private System.Windows.Forms.BindingSource proyectosBindingSource;
        private System.Windows.Forms.Button btn_regresar;
    }
}