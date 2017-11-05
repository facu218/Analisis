namespace UI.AreaFuncion
{
    partial class frmAreaFuncion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTrap = new System.Windows.Forms.RadioButton();
            this.rbTrapM = new System.Windows.Forms.RadioButton();
            this.rbSimpson13 = new System.Windows.Forms.RadioButton();
            this.rbSimpson13M = new System.Windows.Forms.RadioButton();
            this.rbSimpson38 = new System.Windows.Forms.RadioButton();
            this.txtInter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExe = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnExe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtInter);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtValB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFunc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area de función: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Función:";
            // 
            // txtFunc
            // 
            this.txtFunc.Location = new System.Drawing.Point(9, 46);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(241, 20);
            this.txtFunc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor A:";
            // 
            // txtValA
            // 
            this.txtValA.Location = new System.Drawing.Point(9, 85);
            this.txtValA.Name = "txtValA";
            this.txtValA.Size = new System.Drawing.Size(115, 20);
            this.txtValA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor B:";
            // 
            // txtValB
            // 
            this.txtValB.Location = new System.Drawing.Point(130, 85);
            this.txtValB.Name = "txtValB";
            this.txtValB.Size = new System.Drawing.Size(120, 20);
            this.txtValB.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSimpson38);
            this.groupBox2.Controls.Add(this.rbSimpson13M);
            this.groupBox2.Controls.Add(this.rbSimpson13);
            this.groupBox2.Controls.Add(this.rbTrapM);
            this.groupBox2.Controls.Add(this.rbTrap);
            this.groupBox2.Location = new System.Drawing.Point(285, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 88);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metodos: ";
            // 
            // rbTrap
            // 
            this.rbTrap.AutoSize = true;
            this.rbTrap.Location = new System.Drawing.Point(6, 16);
            this.rbTrap.Name = "rbTrap";
            this.rbTrap.Size = new System.Drawing.Size(67, 17);
            this.rbTrap.TabIndex = 0;
            this.rbTrap.TabStop = true;
            this.rbTrap.Text = "Trapecio";
            this.rbTrap.UseVisualStyleBackColor = true;
            // 
            // rbTrapM
            // 
            this.rbTrapM.AutoSize = true;
            this.rbTrapM.Location = new System.Drawing.Point(100, 16);
            this.rbTrapM.Name = "rbTrapM";
            this.rbTrapM.Size = new System.Drawing.Size(115, 17);
            this.rbTrapM.TabIndex = 1;
            this.rbTrapM.TabStop = true;
            this.rbTrapM.Text = "Trapecios multiples";
            this.rbTrapM.UseVisualStyleBackColor = true;
            // 
            // rbSimpson13
            // 
            this.rbSimpson13.AutoSize = true;
            this.rbSimpson13.Location = new System.Drawing.Point(6, 39);
            this.rbSimpson13.Name = "rbSimpson13";
            this.rbSimpson13.Size = new System.Drawing.Size(88, 17);
            this.rbSimpson13.TabIndex = 2;
            this.rbSimpson13.TabStop = true;
            this.rbSimpson13.Text = "Simpson 1/3 ";
            this.rbSimpson13.UseVisualStyleBackColor = true;
            // 
            // rbSimpson13M
            // 
            this.rbSimpson13M.AutoSize = true;
            this.rbSimpson13M.Location = new System.Drawing.Point(100, 39);
            this.rbSimpson13M.Name = "rbSimpson13M";
            this.rbSimpson13M.Size = new System.Drawing.Size(123, 17);
            this.rbSimpson13M.TabIndex = 3;
            this.rbSimpson13M.TabStop = true;
            this.rbSimpson13M.Text = "Simpson 1/3 multiple";
            this.rbSimpson13M.UseVisualStyleBackColor = true;
            // 
            // rbSimpson38
            // 
            this.rbSimpson38.AutoSize = true;
            this.rbSimpson38.Location = new System.Drawing.Point(6, 62);
            this.rbSimpson38.Name = "rbSimpson38";
            this.rbSimpson38.Size = new System.Drawing.Size(85, 17);
            this.rbSimpson38.TabIndex = 4;
            this.rbSimpson38.TabStop = true;
            this.rbSimpson38.Text = "Simpson 3/8";
            this.rbSimpson38.UseVisualStyleBackColor = true;
            // 
            // txtInter
            // 
            this.txtInter.Location = new System.Drawing.Point(9, 124);
            this.txtInter.Name = "txtInter";
            this.txtInter.Size = new System.Drawing.Size(115, 20);
            this.txtInter.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Intervalos:";
            // 
            // btnExe
            // 
            this.btnExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExe.Location = new System.Drawing.Point(130, 121);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(120, 23);
            this.btnExe.TabIndex = 9;
            this.btnExe.Text = "Ejecutar";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtResultado);
            this.groupBox3.Location = new System.Drawing.Point(9, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 51);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(6, 19);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(587, 20);
            this.txtResultado.TabIndex = 0;
            // 
            // frmAreaFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 245);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAreaFuncion";
            this.Text = "Area de una funcion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSimpson38;
        private System.Windows.Forms.RadioButton rbSimpson13M;
        private System.Windows.Forms.RadioButton rbSimpson13;
        private System.Windows.Forms.RadioButton rbTrapM;
        private System.Windows.Forms.RadioButton rbTrap;
        private System.Windows.Forms.TextBox txtValB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.Label label1;
    }
}