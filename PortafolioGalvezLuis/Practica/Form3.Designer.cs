namespace Practica
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInversion1 = new System.Windows.Forms.TextBox();
            this.txtInversion2 = new System.Windows.Forms.TextBox();
            this.txtInversion3 = new System.Windows.Forms.TextBox();
            this.txtPer1 = new System.Windows.Forms.TextBox();
            this.txtPer2 = new System.Windows.Forms.TextBox();
            this.txtPer3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inversiones:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Porcentajes:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "1.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "2.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "3.";
            // 
            // txtInversion1
            // 
            this.txtInversion1.Location = new System.Drawing.Point(34, 35);
            this.txtInversion1.Name = "txtInversion1";
            this.txtInversion1.Size = new System.Drawing.Size(100, 20);
            this.txtInversion1.TabIndex = 5;
            // 
            // txtInversion2
            // 
            this.txtInversion2.Location = new System.Drawing.Point(34, 66);
            this.txtInversion2.Name = "txtInversion2";
            this.txtInversion2.Size = new System.Drawing.Size(100, 20);
            this.txtInversion2.TabIndex = 6;
            // 
            // txtInversion3
            // 
            this.txtInversion3.Location = new System.Drawing.Point(34, 97);
            this.txtInversion3.Name = "txtInversion3";
            this.txtInversion3.Size = new System.Drawing.Size(100, 20);
            this.txtInversion3.TabIndex = 7;
            // 
            // txtPer1
            // 
            this.txtPer1.Enabled = false;
            this.txtPer1.Location = new System.Drawing.Point(170, 35);
            this.txtPer1.Name = "txtPer1";
            this.txtPer1.Size = new System.Drawing.Size(100, 20);
            this.txtPer1.TabIndex = 8;
            // 
            // txtPer2
            // 
            this.txtPer2.Enabled = false;
            this.txtPer2.Location = new System.Drawing.Point(170, 66);
            this.txtPer2.Name = "txtPer2";
            this.txtPer2.Size = new System.Drawing.Size(100, 20);
            this.txtPer2.TabIndex = 9;
            // 
            // txtPer3
            // 
            this.txtPer3.Enabled = false;
            this.txtPer3.Location = new System.Drawing.Point(170, 97);
            this.txtPer3.Name = "txtPer3";
            this.txtPer3.Size = new System.Drawing.Size(100, 20);
            this.txtPer3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inversión total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(34, 153);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 191);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(103, 191);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(194, 191);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 231);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPer3);
            this.Controls.Add(this.txtPer2);
            this.Controls.Add(this.txtPer1);
            this.Controls.Add(this.txtInversion3);
            this.Controls.Add(this.txtInversion2);
            this.Controls.Add(this.txtInversion1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Inversiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInversion1;
        private System.Windows.Forms.TextBox txtInversion2;
        private System.Windows.Forms.TextBox txtInversion3;
        private System.Windows.Forms.TextBox txtPer1;
        private System.Windows.Forms.TextBox txtPer2;
        private System.Windows.Forms.TextBox txtPer3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}