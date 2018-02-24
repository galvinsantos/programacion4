namespace Gestion_de_Equipos
{
    partial class MantenimientoUsuarios
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dgvequipos = new System.Windows.Forms.DataGridView();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(70, 315);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(165, 38);
            this.btnbuscar.TabIndex = 82;
            this.btnbuscar.Text = "Eliminar Cuenta";
            this.btnbuscar.UseVisualStyleBackColor = false;
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
            this.codigo,
            this.nomb,
            this.carrera,
            this.telefono});
            this.dgvequipos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvequipos.Location = new System.Drawing.Point(12, 49);
            this.dgvequipos.MultiSelect = false;
            this.dgvequipos.Name = "dgvequipos";
            this.dgvequipos.ReadOnly = true;
            this.dgvequipos.RowHeadersVisible = false;
            this.dgvequipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvequipos.Size = new System.Drawing.Size(473, 260);
            this.dgvequipos.TabIndex = 83;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(6, 8);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(308, 32);
            this.lbltitulo.TabIndex = 84;
            this.lbltitulo.Text = "Mantenimiento de Usuarios";
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Usuario";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nomb
            // 
            this.nomb.HeaderText = "Contraseña";
            this.nomb.Name = "nomb";
            this.nomb.ReadOnly = true;
            // 
            // carrera
            // 
            this.carrera.HeaderText = "Empleado";
            this.carrera.Name = "carrera";
            this.carrera.ReadOnly = true;
            this.carrera.Width = 150;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Tipo Cuenta";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 120;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar.Location = new System.Drawing.Point(320, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(165, 39);
            this.btnagregar.TabIndex = 85;
            this.btnagregar.Text = "Agregar (+)";
            this.btnagregar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(241, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 38);
            this.button1.TabIndex = 82;
            this.button1.Text = "Resetear Cuenta";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 368);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dgvequipos);
            this.Controls.Add(this.lbltitulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 407);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(512, 407);
            this.Name = "MantenimientoUsuarios";
            this.Text = "MantenimientoUsuarios";
            this.Load += new System.EventHandler(this.MantenimientoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dgvequipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomb;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button button1;
    }
}