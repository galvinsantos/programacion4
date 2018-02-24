namespace Gestion_de_Equipos
{
    partial class reservar
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
            this.btnreservar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtparticipantematricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtfechatarget = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtequipo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtidequipo = new System.Windows.Forms.TextBox();
            this.Aula = new System.Windows.Forms.Label();
            this.txtaula = new System.Windows.Forms.TextBox();
            this.btnselectpart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnreservar
            // 
            this.btnreservar.BackColor = System.Drawing.Color.Azure;
            this.btnreservar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservar.Location = new System.Drawing.Point(55, 235);
            this.btnreservar.Name = "btnreservar";
            this.btnreservar.Size = new System.Drawing.Size(201, 38);
            this.btnreservar.TabIndex = 80;
            this.btnreservar.Text = "Reservar";
            this.btnreservar.UseVisualStyleBackColor = false;
            this.btnreservar.Click += new System.EventHandler(this.btnreservar_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(169, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(193, 32);
            this.lbltitulo.TabIndex = 78;
            this.lbltitulo.Text = "Reservar Equipo";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Azure;
            this.btncancelar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(282, 235);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(201, 38);
            this.btncancelar.TabIndex = 80;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtparticipantematricula
            // 
            this.txtparticipantematricula.BackColor = System.Drawing.Color.White;
            this.txtparticipantematricula.Enabled = false;
            this.txtparticipantematricula.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtparticipantematricula.Location = new System.Drawing.Point(241, 66);
            this.txtparticipantematricula.MaxLength = 10;
            this.txtparticipantematricula.Name = "txtparticipantematricula";
            this.txtparticipantematricula.ReadOnly = true;
            this.txtparticipantematricula.Size = new System.Drawing.Size(114, 29);
            this.txtparticipantematricula.TabIndex = 81;
            this.txtparticipantematricula.Text = "14-3679";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 78;
            this.label1.Text = "Matrícula del Participante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 78;
            this.label2.Text = "Reservado para";
            // 
            // dtfechatarget
            // 
            this.dtfechatarget.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.dtfechatarget.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtfechatarget.Location = new System.Drawing.Point(262, 105);
            this.dtfechatarget.Name = "dtfechatarget";
            this.dtfechatarget.Size = new System.Drawing.Size(114, 29);
            this.dtfechatarget.TabIndex = 82;
            this.dtfechatarget.Value = new System.DateTime(2018, 2, 23, 8, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 78;
            this.label3.Text = "Equipo";
            // 
            // txtequipo
            // 
            this.txtequipo.BackColor = System.Drawing.Color.White;
            this.txtequipo.Enabled = false;
            this.txtequipo.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.txtequipo.Location = new System.Drawing.Point(136, 150);
            this.txtequipo.MaxLength = 10;
            this.txtequipo.Name = "txtequipo";
            this.txtequipo.ReadOnly = true;
            this.txtequipo.Size = new System.Drawing.Size(166, 29);
            this.txtequipo.TabIndex = 81;
            this.txtequipo.Text = "Seleccionar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(361, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 38);
            this.button1.TabIndex = 80;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtidequipo
            // 
            this.txtidequipo.BackColor = System.Drawing.Color.White;
            this.txtidequipo.Enabled = false;
            this.txtidequipo.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.txtidequipo.Location = new System.Drawing.Point(308, 150);
            this.txtidequipo.MaxLength = 10;
            this.txtidequipo.Name = "txtidequipo";
            this.txtidequipo.ReadOnly = true;
            this.txtidequipo.Size = new System.Drawing.Size(47, 29);
            this.txtidequipo.TabIndex = 81;
            this.txtidequipo.Text = "0";
            this.txtidequipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Aula
            // 
            this.Aula.AutoSize = true;
            this.Aula.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aula.Location = new System.Drawing.Point(184, 191);
            this.Aula.Name = "Aula";
            this.Aula.Size = new System.Drawing.Size(61, 26);
            this.Aula.TabIndex = 78;
            this.Aula.Text = "Lugar";
            // 
            // txtaula
            // 
            this.txtaula.BackColor = System.Drawing.Color.White;
            this.txtaula.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.txtaula.Location = new System.Drawing.Point(262, 191);
            this.txtaula.MaxLength = 20;
            this.txtaula.Name = "txtaula";
            this.txtaula.Size = new System.Drawing.Size(166, 29);
            this.txtaula.TabIndex = 81;
            this.txtaula.Text = "1-D-503";
            // 
            // btnselectpart
            // 
            this.btnselectpart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnselectpart.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselectpart.Location = new System.Drawing.Point(361, 61);
            this.btnselectpart.Name = "btnselectpart";
            this.btnselectpart.Size = new System.Drawing.Size(148, 38);
            this.btnselectpart.TabIndex = 80;
            this.btnselectpart.Text = "Seleccionar";
            this.btnselectpart.UseVisualStyleBackColor = false;
            this.btnselectpart.Click += new System.EventHandler(this.btnselectpart_Click);
            // 
            // reservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 288);
            this.Controls.Add(this.dtfechatarget);
            this.Controls.Add(this.txtidequipo);
            this.Controls.Add(this.txtaula);
            this.Controls.Add(this.txtequipo);
            this.Controls.Add(this.txtparticipantematricula);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.Aula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnselectpart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnreservar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 327);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 327);
            this.Name = "reservar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservar Equipo";
            this.Load += new System.EventHandler(this.reservar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreservar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtparticipantematricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtfechatarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtequipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtidequipo;
        private System.Windows.Forms.Label Aula;
        private System.Windows.Forms.TextBox txtaula;
        private System.Windows.Forms.Button btnselectpart;
    }
}