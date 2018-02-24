namespace Gestion_de_Equipos
{
    partial class EntradaSalida
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
            this.btnsalida = new System.Windows.Forms.Button();
            this.btnentrada = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsalida
            // 
            this.btnsalida.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnsalida.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.btnsalida.Location = new System.Drawing.Point(219, 53);
            this.btnsalida.Name = "btnsalida";
            this.btnsalida.Size = new System.Drawing.Size(216, 38);
            this.btnsalida.TabIndex = 76;
            this.btnsalida.Text = "Dar Salida";
            this.btnsalida.UseVisualStyleBackColor = false;
            this.btnsalida.Click += new System.EventHandler(this.btnsalida_Click);
            // 
            // btnentrada
            // 
            this.btnentrada.BackColor = System.Drawing.Color.Azure;
            this.btnentrada.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrada.Location = new System.Drawing.Point(12, 53);
            this.btnentrada.Name = "btnentrada";
            this.btnentrada.Size = new System.Drawing.Size(201, 38);
            this.btnentrada.TabIndex = 75;
            this.btnentrada.Text = "Dar Entrada";
            this.btnentrada.UseVisualStyleBackColor = false;
            this.btnentrada.Click += new System.EventHandler(this.btnentrada_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(96, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(232, 32);
            this.lbltitulo.TabIndex = 74;
            this.lbltitulo.Text = "Seleccione la Opción";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(116, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 38);
            this.button1.TabIndex = 77;
            this.button1.Text = "Reservar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // EntradaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 145);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsalida);
            this.Controls.Add(this.btnentrada);
            this.Controls.Add(this.lbltitulo);
            this.MaximumSize = new System.Drawing.Size(463, 184);
            this.MinimumSize = new System.Drawing.Size(463, 184);
            this.Name = "EntradaSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntradaSalida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalida;
        private System.Windows.Forms.Button btnentrada;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button button1;
    }
}