namespace WindowsFormsApp1
{
    partial class Formulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSimular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDPAUA = new System.Windows.Forms.TextBox();
            this.txtDPNAUA = new System.Windows.Forms.TextBox();
            this.txtDNHA = new System.Windows.Forms.TextBox();
            this.txtPAUASA = new System.Windows.Forms.TextBox();
            this.txtPNAUASA = new System.Windows.Forms.TextBox();
            this.txtNHASA = new System.Windows.Forms.TextBox();
            this.txtPAUANSA = new System.Windows.Forms.TextBox();
            this.txtPNAUANSA = new System.Windows.Forms.TextBox();
            this.txtNHANSA = new System.Windows.Forms.TextBox();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulación Montecarlo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad Simulaciones (N)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destinatario Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Iteraciones (I)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(740, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Desde donde (j)";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(831, 621);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(1016, 621);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 11;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(100, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "P(Paciente y asistió último año)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(82, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "P(Paciente y no asistió último año)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(143, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "P(Nunca había asistido)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(528, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "P(Paciente y asistió último año)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(528, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "P(Paciente y no asistió último año)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(528, 549);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "P(Nunca había asistido)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(797, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Solicitó asesor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(976, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "No solicitó asesor";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(159, 108);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 27;
            this.txtCantidad.Text = "1";
            // 
            // txtDPAUA
            // 
            this.txtDPAUA.Location = new System.Drawing.Point(299, 282);
            this.txtDPAUA.Name = "txtDPAUA";
            this.txtDPAUA.Size = new System.Drawing.Size(100, 22);
            this.txtDPAUA.TabIndex = 28;
            this.txtDPAUA.Text = "0.60";
            // 
            // txtDPNAUA
            // 
            this.txtDPNAUA.Location = new System.Drawing.Point(299, 324);
            this.txtDPNAUA.Name = "txtDPNAUA";
            this.txtDPNAUA.Size = new System.Drawing.Size(100, 22);
            this.txtDPNAUA.TabIndex = 29;
            this.txtDPNAUA.Text = "0.25";
            // 
            // txtDNHA
            // 
            this.txtDNHA.Location = new System.Drawing.Point(299, 362);
            this.txtDNHA.Name = "txtDNHA";
            this.txtDNHA.Size = new System.Drawing.Size(100, 22);
            this.txtDNHA.TabIndex = 30;
            this.txtDNHA.Text = "0.15";
            // 
            // txtPAUASA
            // 
            this.txtPAUASA.Location = new System.Drawing.Point(785, 462);
            this.txtPAUASA.Name = "txtPAUASA";
            this.txtPAUASA.Size = new System.Drawing.Size(100, 22);
            this.txtPAUASA.TabIndex = 31;
            this.txtPAUASA.Text = "0.5";
            // 
            // txtPNAUASA
            // 
            this.txtPNAUASA.Location = new System.Drawing.Point(785, 505);
            this.txtPNAUASA.Name = "txtPNAUASA";
            this.txtPNAUASA.Size = new System.Drawing.Size(100, 22);
            this.txtPNAUASA.TabIndex = 32;
            this.txtPNAUASA.Text = "0.4";
            // 
            // txtNHASA
            // 
            this.txtNHASA.Location = new System.Drawing.Point(785, 549);
            this.txtNHASA.Name = "txtNHASA";
            this.txtNHASA.Size = new System.Drawing.Size(100, 22);
            this.txtNHASA.TabIndex = 33;
            this.txtNHASA.Text = "0.15";
            // 
            // txtPAUANSA
            // 
            this.txtPAUANSA.Location = new System.Drawing.Point(979, 462);
            this.txtPAUANSA.Name = "txtPAUANSA";
            this.txtPAUANSA.Size = new System.Drawing.Size(100, 22);
            this.txtPAUANSA.TabIndex = 34;
            this.txtPAUANSA.Text = "0.5";
            // 
            // txtPNAUANSA
            // 
            this.txtPNAUANSA.Location = new System.Drawing.Point(979, 502);
            this.txtPNAUANSA.Name = "txtPNAUANSA";
            this.txtPNAUANSA.Size = new System.Drawing.Size(100, 22);
            this.txtPNAUANSA.TabIndex = 35;
            this.txtPNAUANSA.Text = "0.6";
            // 
            // txtNHANSA
            // 
            this.txtNHANSA.Location = new System.Drawing.Point(979, 543);
            this.txtNHANSA.Name = "txtNHANSA";
            this.txtNHANSA.Size = new System.Drawing.Size(100, 22);
            this.txtNHANSA.TabIndex = 36;
            this.txtNHANSA.Text = "0.85";
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(519, 106);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(100, 22);
            this.txtIteraciones.TabIndex = 37;
            this.txtIteraciones.Text = "1";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(743, 108);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 22);
            this.txtDesde.TabIndex = 38;
            this.txtDesde.Text = "1";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 705);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.txtIteraciones);
            this.Controls.Add(this.txtNHANSA);
            this.Controls.Add(this.txtPNAUANSA);
            this.Controls.Add(this.txtPAUANSA);
            this.Controls.Add(this.txtNHASA);
            this.Controls.Add(this.txtPNAUASA);
            this.Controls.Add(this.txtPAUASA);
            this.Controls.Add(this.txtDNHA);
            this.Controls.Add(this.txtDPNAUA);
            this.Controls.Add(this.txtDPAUA);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulario";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDPAUA;
        private System.Windows.Forms.TextBox txtDPNAUA;
        private System.Windows.Forms.TextBox txtDNHA;
        private System.Windows.Forms.TextBox txtPAUASA;
        private System.Windows.Forms.TextBox txtPNAUASA;
        private System.Windows.Forms.TextBox txtNHASA;
        private System.Windows.Forms.TextBox txtPAUANSA;
        private System.Windows.Forms.TextBox txtPNAUANSA;
        private System.Windows.Forms.TextBox txtNHANSA;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.TextBox txtDesde;
    }
}

