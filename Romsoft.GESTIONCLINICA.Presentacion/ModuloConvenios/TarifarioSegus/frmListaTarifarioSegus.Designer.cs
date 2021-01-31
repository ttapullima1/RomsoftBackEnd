
namespace Romsoft.GESTIONCLINICA.Presentacion.ModuloConvenios.TarifarioSegus
{
    partial class frmListaTarifarioSegus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaTarifarioSegus));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.idtarifariosegusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccodigosusaludDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdescripcionespDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdescripcionengDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tobservacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tclasificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ETListaTarifabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETListaTarifabindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Definición y Modificación de atributos del tarifario segus";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 38);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mantenimiento de Tarifarios Segus";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(878, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 26);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 35);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.AllowUserToAddRows = false;
            this.dgvListaUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvListaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaUsuarios.AutoGenerateColumns = false;
            this.dgvListaUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvListaUsuarios.ColumnHeadersHeight = 30;
            this.dgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtarifariosegusDataGridViewTextBoxColumn,
            this.ccodigoDataGridViewTextBoxColumn,
            this.ccodigosusaludDataGridViewTextBoxColumn,
            this.tdescripcionespDataGridViewTextBoxColumn,
            this.tdescripcionengDataGridViewTextBoxColumn,
            this.tobservacionDataGridViewTextBoxColumn,
            this.tclasificacionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.Edit});
            this.dgvListaUsuarios.DataSource = this.ETListaTarifabindingSource;
            this.dgvListaUsuarios.EnableHeadersVisualStyles = false;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(5, 80);
            this.dgvListaUsuarios.MultiSelect = false;
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.ReadOnly = true;
            this.dgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(900, 427);
            this.dgvListaUsuarios.TabIndex = 30;
            this.dgvListaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuarios_CellContentClick);
            this.dgvListaUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuarios_CellContentDoubleClick);
            // 
            // idtarifariosegusDataGridViewTextBoxColumn
            // 
            this.idtarifariosegusDataGridViewTextBoxColumn.DataPropertyName = "id_tarifario_segus";
            this.idtarifariosegusDataGridViewTextBoxColumn.HeaderText = "id_tarifario_segus";
            this.idtarifariosegusDataGridViewTextBoxColumn.Name = "idtarifariosegusDataGridViewTextBoxColumn";
            this.idtarifariosegusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtarifariosegusDataGridViewTextBoxColumn.Visible = false;
            this.idtarifariosegusDataGridViewTextBoxColumn.Width = 114;
            // 
            // ccodigoDataGridViewTextBoxColumn
            // 
            this.ccodigoDataGridViewTextBoxColumn.DataPropertyName = "c_codigo";
            this.ccodigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.ccodigoDataGridViewTextBoxColumn.Name = "ccodigoDataGridViewTextBoxColumn";
            this.ccodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccodigoDataGridViewTextBoxColumn.Width = 90;
            // 
            // ccodigosusaludDataGridViewTextBoxColumn
            // 
            this.ccodigosusaludDataGridViewTextBoxColumn.DataPropertyName = "c_codigo_susalud";
            this.ccodigosusaludDataGridViewTextBoxColumn.HeaderText = "Código Susalud";
            this.ccodigosusaludDataGridViewTextBoxColumn.Name = "ccodigosusaludDataGridViewTextBoxColumn";
            this.ccodigosusaludDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tdescripcionespDataGridViewTextBoxColumn
            // 
            this.tdescripcionespDataGridViewTextBoxColumn.DataPropertyName = "t_descripcion_esp";
            this.tdescripcionespDataGridViewTextBoxColumn.HeaderText = "Descripcion ESP";
            this.tdescripcionespDataGridViewTextBoxColumn.Name = "tdescripcionespDataGridViewTextBoxColumn";
            this.tdescripcionespDataGridViewTextBoxColumn.ReadOnly = true;
            this.tdescripcionespDataGridViewTextBoxColumn.Width = 290;
            // 
            // tdescripcionengDataGridViewTextBoxColumn
            // 
            this.tdescripcionengDataGridViewTextBoxColumn.DataPropertyName = "t_descripcion_eng";
            this.tdescripcionengDataGridViewTextBoxColumn.HeaderText = "Descripcion ENG";
            this.tdescripcionengDataGridViewTextBoxColumn.Name = "tdescripcionengDataGridViewTextBoxColumn";
            this.tdescripcionengDataGridViewTextBoxColumn.ReadOnly = true;
            this.tdescripcionengDataGridViewTextBoxColumn.Width = 200;
            // 
            // tobservacionDataGridViewTextBoxColumn
            // 
            this.tobservacionDataGridViewTextBoxColumn.DataPropertyName = "t_observacion";
            this.tobservacionDataGridViewTextBoxColumn.HeaderText = "Observación";
            this.tobservacionDataGridViewTextBoxColumn.Name = "tobservacionDataGridViewTextBoxColumn";
            this.tobservacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.tobservacionDataGridViewTextBoxColumn.Width = 200;
            // 
            // tclasificacionDataGridViewTextBoxColumn
            // 
            this.tclasificacionDataGridViewTextBoxColumn.DataPropertyName = "t_clasificacion";
            this.tclasificacionDataGridViewTextBoxColumn.HeaderText = "Clasificación";
            this.tclasificacionDataGridViewTextBoxColumn.Name = "tclasificacionDataGridViewTextBoxColumn";
            this.tclasificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.tclasificacionDataGridViewTextBoxColumn.Width = 99;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 64;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Ver Detalle";
            this.Edit.Image = global::Romsoft.GESTIONCLINICA.Presentacion.Properties.Resources.Editar2;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.ToolTipText = "Editar Registro";
            this.Edit.Width = 65;
            // 
            // ETListaTarifabindingSource
            // 
            this.ETListaTarifabindingSource.DataSource = typeof(Romsoft.GESTIONCLINICA.DTO.TABLAS.CVN_TARIFARIO_SEGUS.CVN_TARIFARIO_LISTADTO);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::Romsoft.GESTIONCLINICA.Presentacion.Properties.Resources.Editar2;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Editar Registro";
            this.dataGridViewImageColumn1.Width = 33;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(107, 49);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(107, 25);
            this.btnFiltrar.TabIndex = 33;
            this.btnFiltrar.Text = "   Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(5, 49);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 25);
            this.btnNuevo.TabIndex = 32;
            this.btnNuevo.Text = "    Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Inactivo";
            this.dataGridViewImageColumn2.Image = global::Romsoft.GESTIONCLINICA.Presentacion.Properties.Resources.Eliminar2;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.ToolTipText = "Inactivo";
            this.dataGridViewImageColumn2.Width = 53;
            // 
            // frmListaTarifarioSegus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 516);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvListaUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaTarifarioSegus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaTarifarioSegus";
            this.Load += new System.EventHandler(this.frmListaTarifarioSegus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETListaTarifabindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingSource ETListaTarifabindingSource;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtarifariosegusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccodigosusaludDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdescripcionespDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdescripcionengDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tobservacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tclasificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}