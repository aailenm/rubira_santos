﻿namespace UberFrba.Abm_Turno
{
    partial class Alta_Turno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HHM = new System.Windows.Forms.NumericUpDown();
            this.HHH = new System.Windows.Forms.NumericUpDown();
            this.HDM = new System.Windows.Forms.NumericUpDown();
            this.HDH = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VKM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DETALLE = new System.Windows.Forms.TextBox();
            this.CANCELAR = new System.Windows.Forms.Button();
            this.CREAR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HHM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HHM);
            this.groupBox1.Controls.Add(this.HHH);
            this.groupBox1.Controls.Add(this.HDM);
            this.groupBox1.Controls.Add(this.HDH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.VKM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DETALLE);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Turno";
            // 
            // HHM
            // 
            this.HHM.Location = new System.Drawing.Point(329, 44);
            this.HHM.Name = "HHM";
            this.HHM.ReadOnly = true;
            this.HHM.Size = new System.Drawing.Size(39, 20);
            this.HHM.TabIndex = 6;
            // 
            // HHH
            // 
            this.HHH.Location = new System.Drawing.Point(272, 45);
            this.HHH.Name = "HHH";
            this.HHH.ReadOnly = true;
            this.HHH.Size = new System.Drawing.Size(39, 20);
            this.HHH.TabIndex = 5;
            this.HHH.ValueChanged += new System.EventHandler(this.HHH_ValueChanged);
            // 
            // HDM
            // 
            this.HDM.Location = new System.Drawing.Point(329, 19);
            this.HDM.Name = "HDM";
            this.HDM.ReadOnly = true;
            this.HDM.Size = new System.Drawing.Size(39, 20);
            this.HDM.TabIndex = 4;
            // 
            // HDH
            // 
            this.HDH.Location = new System.Drawing.Point(272, 19);
            this.HDH.Name = "HDH";
            this.HDH.ReadOnly = true;
            this.HDH.Size = new System.Drawing.Size(39, 20);
            this.HDH.TabIndex = 3;
            this.HDH.ValueChanged += new System.EventHandler(this.HHD_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Valor del KM $";
            // 
            // VKM
            // 
            this.VKM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.VKM.Location = new System.Drawing.Point(92, 71);
            this.VKM.Name = "VKM";
            this.VKM.Size = new System.Drawing.Size(100, 20);
            this.VKM.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Precio Base";
            // 
            // PB
            // 
            this.PB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PB.Location = new System.Drawing.Point(92, 45);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(100, 20);
            this.PB.TabIndex = 1;
            this.PB.TextChanged += new System.EventHandler(this.PB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Hora Hasta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Hora Desde";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            // 
            // DETALLE
            // 
            this.DETALLE.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DETALLE.Location = new System.Drawing.Point(92, 19);
            this.DETALLE.Name = "DETALLE";
            this.DETALLE.Size = new System.Drawing.Size(100, 20);
            this.DETALLE.TabIndex = 0;
            this.DETALLE.TextChanged += new System.EventHandler(this.DETALLE_TextChanged);
            // 
            // CANCELAR
            // 
            this.CANCELAR.Location = new System.Drawing.Point(210, 122);
            this.CANCELAR.Name = "CANCELAR";
            this.CANCELAR.Size = new System.Drawing.Size(181, 23);
            this.CANCELAR.TabIndex = 2;
            this.CANCELAR.Text = "Cancelar";
            this.CANCELAR.UseVisualStyleBackColor = true;
            this.CANCELAR.Click += new System.EventHandler(this.CANCELAR_Click);
            // 
            // CREAR
            // 
            this.CREAR.Location = new System.Drawing.Point(12, 122);
            this.CREAR.Name = "CREAR";
            this.CREAR.Size = new System.Drawing.Size(181, 23);
            this.CREAR.TabIndex = 1;
            this.CREAR.Text = "Aceptar";
            this.CREAR.UseVisualStyleBackColor = true;
            this.CREAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alta_Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 157);
            this.Controls.Add(this.CANCELAR);
            this.Controls.Add(this.CREAR);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Alta_Turno";
            this.Text = "Alta de Turno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HHM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DETALLE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VKM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CANCELAR;
        private System.Windows.Forms.Button CREAR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown HHM;
        private System.Windows.Forms.NumericUpDown HHH;
        private System.Windows.Forms.NumericUpDown HDM;
        private System.Windows.Forms.NumericUpDown HDH;
    }
}