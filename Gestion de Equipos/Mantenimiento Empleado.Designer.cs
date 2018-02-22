namespace Gestion_de_Equipos
{
    partial class Mantenimiento_Empleado
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
            this.btpnew = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btpdelete = new System.Windows.Forms.Button();
            this.btnactualizarservicio = new System.Windows.Forms.Button();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lblparticipante = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btpnew
            // 
            this.btpnew.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpnew.Location = new System.Drawing.Point(110, 262);
            this.btpnew.Name = "btpnew";
            this.btpnew.Size = new System.Drawing.Size(102, 39);
            this.btpnew.TabIndex = 80;
            this.btpnew.Text = "Nuevo";
            this.btpnew.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(395, 37);
            this.label8.TabIndex = 86;
            this.label8.Text = "Mantenimiento de Empleados";
            // 
            // btpdelete
            // 
            this.btpdelete.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.btpdelete.Location = new System.Drawing.Point(190, 223);
            this.btpdelete.Name = "btpdelete";
            this.btpdelete.Size = new System.Drawing.Size(93, 33);
            this.btpdelete.TabIndex = 79;
            this.btpdelete.Text = "Eliminar";
            this.btpdelete.UseVisualStyleBackColor = true;
            // 
            // btnactualizarservicio
            // 
            this.btnactualizarservicio.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarservicio.Location = new System.Drawing.Point(78, 223);
            this.btnactualizarservicio.Name = "btnactualizarservicio";
            this.btnactualizarservicio.Size = new System.Drawing.Size(106, 33);
            this.btnactualizarservicio.TabIndex = 78;
            this.btnactualizarservicio.Text = "Guardar";
            this.btnactualizarservicio.UseVisualStyleBackColor = true;
            this.btnactualizarservicio.Click += new System.EventHandler(this.btnactualizarservicio_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtdireccion.Location = new System.Drawing.Point(155, 184);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(112, 23);
            this.txtdireccion.TabIndex = 77;
            // 
            // lblparticipante
            // 
            this.lblparticipante.AutoSize = true;
            this.lblparticipante.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.lblparticipante.Location = new System.Drawing.Point(42, 181);
            this.lblparticipante.Name = "lblparticipante";
            this.lblparticipante.Size = new System.Drawing.Size(105, 24);
            this.lblparticipante.TabIndex = 85;
            this.lblparticipante.Text = "Dirección";
            // 
            // txtcedula
            // 
            this.txtcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtcedula.Location = new System.Drawing.Point(153, 122);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(194, 23);
            this.txtcedula.TabIndex = 75;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.lblmarca.Location = new System.Drawing.Point(68, 122);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(79, 24);
            this.lblmarca.TabIndex = 83;
            this.lblmarca.Text = "Cédula";
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txttelefono.Location = new System.Drawing.Point(154, 153);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(112, 23);
            this.txttelefono.TabIndex = 76;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.lblestado.Location = new System.Drawing.Point(50, 153);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(97, 24);
            this.lblestado.TabIndex = 84;
            this.lblestado.Text = "Teléfono";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtnombre.Location = new System.Drawing.Point(153, 93);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(238, 23);
            this.txtnombre.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(57, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 82;
            this.label2.Text = "Nombre";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtcodigo.Location = new System.Drawing.Point(153, 61);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(90, 23);
            this.txtcodigo.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(68, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 81;
            this.label1.Text = "Código";
            // 
            // Mantenimiento_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 318);
            this.Controls.Add(this.btpnew);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btpdelete);
            this.Controls.Add(this.btnactualizarservicio);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.lblparticipante);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Mantenimiento_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Empleados";
            this.Load += new System.EventHandler(this.Mantenimiento_Empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btpnew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btpdelete;
        private System.Windows.Forms.Button btnactualizarservicio;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lblparticipante;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
    }
}