namespace Gestion_de_Equipos
{
    partial class Consultar
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
            this.tbbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dgvequipos = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldobruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.cbtipobusqueda = new System.Windows.Forms.ComboBox();
            this.btnmostrartodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbbuscar
            // 
            this.tbbuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.tbbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbuscar.Location = new System.Drawing.Point(245, 13);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(204, 29);
            this.tbbuscar.TabIndex = 75;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(455, 7);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(111, 38);
            this.btnbuscar.TabIndex = 76;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar.Location = new System.Drawing.Point(572, 6);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(126, 39);
            this.btnagregar.TabIndex = 79;
            this.btnagregar.Text = "Agregar (+)";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dgvequipos
            // 
            this.dgvequipos.AllowUserToAddRows = false;
            this.dgvequipos.AllowUserToDeleteRows = false;
            this.dgvequipos.AllowUserToResizeColumns = false;
            this.dgvequipos.AllowUserToResizeRows = false;
            this.dgvequipos.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvequipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvequipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.Nombre,
            this.sueldobruto,
            this.cargo});
            this.dgvequipos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvequipos.Location = new System.Drawing.Point(15, 51);
            this.dgvequipos.MultiSelect = false;
            this.dgvequipos.Name = "dgvequipos";
            this.dgvequipos.ReadOnly = true;
            this.dgvequipos.RowHeadersVisible = false;
            this.dgvequipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvequipos.Size = new System.Drawing.Size(683, 319);
            this.dgvequipos.TabIndex = 78;
            this.dgvequipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvequipos_CellDoubleClick);
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Código";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Equipo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 260;
            // 
            // sueldobruto
            // 
            this.sueldobruto.HeaderText = "Estado";
            this.sueldobruto.Name = "sueldobruto";
            this.sueldobruto.ReadOnly = true;
            this.sueldobruto.Width = 150;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Participante";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 220;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(9, 10);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(118, 32);
            this.lbltitulo.TabIndex = 80;
            this.lbltitulo.Text = "Consultar";
            // 
            // cbtipobusqueda
            // 
            this.cbtipobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipobusqueda.FormattingEnabled = true;
            this.cbtipobusqueda.Items.AddRange(new object[] {
            "Participante",
            "Equipos",
            "Empleados"});
            this.cbtipobusqueda.Location = new System.Drawing.Point(129, 18);
            this.cbtipobusqueda.Name = "cbtipobusqueda";
            this.cbtipobusqueda.Size = new System.Drawing.Size(110, 21);
            this.cbtipobusqueda.TabIndex = 83;
            // 
            // btnmostrartodo
            // 
            this.btnmostrartodo.BackColor = System.Drawing.Color.White;
            this.btnmostrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrartodo.Location = new System.Drawing.Point(12, 383);
            this.btnmostrartodo.Name = "btnmostrartodo";
            this.btnmostrartodo.Size = new System.Drawing.Size(686, 38);
            this.btnmostrartodo.TabIndex = 77;
            this.btnmostrartodo.Text = "Mostrar Todos";
            this.btnmostrartodo.UseVisualStyleBackColor = false;
            this.btnmostrartodo.Click += new System.EventHandler(this.btnmostrartodo_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 430);
            this.Controls.Add(this.tbbuscar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvequipos);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.cbtipobusqueda);
            this.Controls.Add(this.btnmostrartodo);
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvequipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldobruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.ComboBox cbtipobusqueda;
        private System.Windows.Forms.Button btnmostrartodo;
    }
}