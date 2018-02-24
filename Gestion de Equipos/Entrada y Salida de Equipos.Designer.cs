namespace Gestion_de_Equipos
{
    partial class Entrada_y_Salida_de_Equipos
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
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnmostrartodo = new System.Windows.Forms.Button();
            this.cbtipobusqueda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbbuscar
            // 
            this.tbbuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.tbbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbuscar.Location = new System.Drawing.Point(272, 15);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(204, 29);
            this.tbbuscar.TabIndex = 66;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(482, 10);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(111, 38);
            this.btnbuscar.TabIndex = 67;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar.Location = new System.Drawing.Point(599, 9);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(147, 39);
            this.btnagregar.TabIndex = 69;
            this.btnagregar.Text = "Agregar Equipo (+)";
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
            this.cargo,
            this.empleado,
            this.fecha});
            this.dgvequipos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvequipos.Location = new System.Drawing.Point(12, 53);
            this.dgvequipos.MultiSelect = false;
            this.dgvequipos.Name = "dgvequipos";
            this.dgvequipos.ReadOnly = true;
            this.dgvequipos.RowHeadersVisible = false;
            this.dgvequipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvequipos.Size = new System.Drawing.Size(734, 319);
            this.dgvequipos.TabIndex = 68;
            this.dgvequipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvequipos_CellDoubleClick);
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Código";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Equipo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // sueldobruto
            // 
            this.sueldobruto.HeaderText = "Estado";
            this.sueldobruto.Name = "sueldobruto";
            this.sueldobruto.ReadOnly = true;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Participante";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 180;
            // 
            // empleado
            // 
            this.empleado.HeaderText = "Empleado";
            this.empleado.Name = "empleado";
            this.empleado.ReadOnly = true;
            this.empleado.Width = 180;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 70;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(40, 10);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(100, 32);
            this.lbltitulo.TabIndex = 72;
            this.lbltitulo.Text = "Equipos";
            // 
            // btnmostrartodo
            // 
            this.btnmostrartodo.BackColor = System.Drawing.Color.White;
            this.btnmostrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrartodo.Location = new System.Drawing.Point(33, 378);
            this.btnmostrartodo.Name = "btnmostrartodo";
            this.btnmostrartodo.Size = new System.Drawing.Size(685, 45);
            this.btnmostrartodo.TabIndex = 67;
            this.btnmostrartodo.Text = "Mostrar Todos";
            this.btnmostrartodo.UseVisualStyleBackColor = false;
            this.btnmostrartodo.Click += new System.EventHandler(this.btnmostrartodo_Click);
            // 
            // cbtipobusqueda
            // 
            this.cbtipobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipobusqueda.FormattingEnabled = true;
            this.cbtipobusqueda.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Estado",
            "Participante",
            "Empleado"});
            this.cbtipobusqueda.Location = new System.Drawing.Point(156, 21);
            this.cbtipobusqueda.Name = "cbtipobusqueda";
            this.cbtipobusqueda.Size = new System.Drawing.Size(110, 21);
            this.cbtipobusqueda.TabIndex = 74;
            // 
            // Entrada_y_Salida_de_Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 435);
            this.Controls.Add(this.cbtipobusqueda);
            this.Controls.Add(this.tbbuscar);
            this.Controls.Add(this.btnmostrartodo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvequipos);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Entrada_y_Salida_de_Equipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada y Salida de Equipos";
            this.Load += new System.EventHandler(this.Entrada_y_Salida_de_Equipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvequipos;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnmostrartodo;
        private System.Windows.Forms.ComboBox cbtipobusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldobruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}