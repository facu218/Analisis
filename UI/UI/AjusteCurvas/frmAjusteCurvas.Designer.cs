namespace UI.Regresion
{
    partial class frmAjusteCurvas
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
            this.lblCoe = new System.Windows.Forms.Label();
            this.txtCoe = new System.Windows.Forms.TextBox();
            this.btnPolinomial = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtInter = new System.Windows.Forms.TextBox();
            this.lblInter = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPot = new System.Windows.Forms.TextBox();
            this.lblPot = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPot);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtPot);
            this.groupBox1.Controls.Add(this.lblInter);
            this.groupBox1.Controls.Add(this.txtInter);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.lblCoe);
            this.groupBox1.Controls.Add(this.txtCoe);
            this.groupBox1.Controls.Add(this.btnPolinomial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvPuntos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regresion lineal";
            // 
            // lblCoe
            // 
            this.lblCoe.AutoSize = true;
            this.lblCoe.Location = new System.Drawing.Point(182, 125);
            this.lblCoe.Name = "lblCoe";
            this.lblCoe.Size = new System.Drawing.Size(133, 13);
            this.lblCoe.TabIndex = 15;
            this.lblCoe.Text = "Coeficiente de correlación:";
            this.lblCoe.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCoe
            // 
            this.txtCoe.Location = new System.Drawing.Point(185, 141);
            this.txtCoe.Name = "txtCoe";
            this.txtCoe.Size = new System.Drawing.Size(207, 20);
            this.txtCoe.TabIndex = 14;
            // 
            // btnPolinomial
            // 
            this.btnPolinomial.Location = new System.Drawing.Point(112, 272);
            this.btnPolinomial.Name = "btnPolinomial";
            this.btnPolinomial.Size = new System.Drawing.Size(75, 42);
            this.btnPolinomial.TabIndex = 13;
            this.btnPolinomial.Text = "Regresion Polinomial";
            this.btnPolinomial.UseVisualStyleBackColor = true;
            this.btnPolinomial.Click += new System.EventHandler(this.btnPolinomial_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Recta de mejor ajuste";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Regresión lineal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.AllowUserToAddRows = false;
            this.dgvPuntos.AllowUserToDeleteRows = false;
            this.dgvPuntos.AllowUserToResizeColumns = false;
            this.dgvPuntos.AllowUserToResizeRows = false;
            this.dgvPuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.ColumnHeadersVisible = false;
            this.dgvPuntos.Location = new System.Drawing.Point(32, 85);
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.RowHeadersVisible = false;
            this.dgvPuntos.Size = new System.Drawing.Size(95, 163);
            this.dgvPuntos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de puntos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(185, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Lagrange";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtInter
            // 
            this.txtInter.Location = new System.Drawing.Point(264, 222);
            this.txtInter.Name = "txtInter";
            this.txtInter.Size = new System.Drawing.Size(95, 20);
            this.txtInter.TabIndex = 17;
            this.txtInter.Visible = false;
            // 
            // lblInter
            // 
            this.lblInter.AutoSize = true;
            this.lblInter.Location = new System.Drawing.Point(262, 206);
            this.lblInter.Name = "lblInter";
            this.lblInter.Size = new System.Drawing.Size(97, 13);
            this.lblInter.TabIndex = 18;
            this.lblInter.Text = "Valor interpolacion:";
            this.lblInter.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 19;
            this.button3.Text = "Lagrange";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPot
            // 
            this.txtPot.Location = new System.Drawing.Point(185, 180);
            this.txtPot.Name = "txtPot";
            this.txtPot.Size = new System.Drawing.Size(207, 20);
            this.txtPot.TabIndex = 20;
            // 
            // lblPot
            // 
            this.lblPot.AutoSize = true;
            this.lblPot.Location = new System.Drawing.Point(182, 164);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(113, 13);
            this.lblPot.TabIndex = 21;
            this.lblPot.Text = "Potencia de la funcion";
            // 
            // frmAjusteCurvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 347);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAjusteCurvas";
            this.Text = "frnAjusteCurvas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPuntos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPolinomial;
        private System.Windows.Forms.Label lblCoe;
        private System.Windows.Forms.TextBox txtCoe;
        private System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPot;
        private System.Windows.Forms.Label lblInter;
        private System.Windows.Forms.TextBox txtInter;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}