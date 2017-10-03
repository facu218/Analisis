namespace UI
{
    partial class FrmRaiz
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biseccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tangenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglaFalsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.pnlRaiz = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTole = new System.Windows.Forms.TextBox();
            this.txtIte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.pnlRaiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raizToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raizToolStripMenuItem
            // 
            this.raizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biseccionToolStripMenuItem,
            this.tangenteToolStripMenuItem,
            this.reglaFalsaToolStripMenuItem,
            this.secanteToolStripMenuItem});
            this.raizToolStripMenuItem.Name = "raizToolStripMenuItem";
            this.raizToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.raizToolStripMenuItem.Text = "Raiz";
            // 
            // biseccionToolStripMenuItem
            // 
            this.biseccionToolStripMenuItem.Name = "biseccionToolStripMenuItem";
            this.biseccionToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.biseccionToolStripMenuItem.Text = "Biseccion";
            this.biseccionToolStripMenuItem.Click += new System.EventHandler(this.biseccionToolStripMenuItem_Click);
            // 
            // tangenteToolStripMenuItem
            // 
            this.tangenteToolStripMenuItem.Name = "tangenteToolStripMenuItem";
            this.tangenteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.tangenteToolStripMenuItem.Text = "Tangente";
            this.tangenteToolStripMenuItem.Click += new System.EventHandler(this.tangenteToolStripMenuItem_Click);
            // 
            // reglaFalsaToolStripMenuItem
            // 
            this.reglaFalsaToolStripMenuItem.Name = "reglaFalsaToolStripMenuItem";
            this.reglaFalsaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.reglaFalsaToolStripMenuItem.Text = "Regla falsa";
            this.reglaFalsaToolStripMenuItem.Click += new System.EventHandler(this.reglaFalsaToolStripMenuItem_Click);
            // 
            // secanteToolStripMenuItem
            // 
            this.secanteToolStripMenuItem.Name = "secanteToolStripMenuItem";
            this.secanteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.secanteToolStripMenuItem.Text = "Secante";
            this.secanteToolStripMenuItem.Click += new System.EventHandler(this.secanteToolStripMenuItem_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(0, 242);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(351, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // pnlRaiz
            // 
            this.pnlRaiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRaiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRaiz.Controls.Add(this.label5);
            this.pnlRaiz.Controls.Add(this.txtTole);
            this.pnlRaiz.Controls.Add(this.txtIte);
            this.pnlRaiz.Controls.Add(this.label4);
            this.pnlRaiz.Controls.Add(this.label1);
            this.pnlRaiz.Controls.Add(this.button1);
            this.pnlRaiz.Controls.Add(this.txtValor2);
            this.pnlRaiz.Controls.Add(this.txtValor1);
            this.pnlRaiz.Controls.Add(this.lblPrincipal);
            this.pnlRaiz.Location = new System.Drawing.Point(7, 62);
            this.pnlRaiz.Name = "pnlRaiz";
            this.pnlRaiz.Size = new System.Drawing.Size(296, 138);
            this.pnlRaiz.TabIndex = 2;
            this.pnlRaiz.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tolerancia:";
            // 
            // txtTole
            // 
            this.txtTole.Location = new System.Drawing.Point(75, 110);
            this.txtTole.Name = "txtTole";
            this.txtTole.Size = new System.Drawing.Size(50, 20);
            this.txtTole.TabIndex = 7;
            this.txtTole.Text = "0,0001";
            // 
            // txtIte
            // 
            this.txtIte.Location = new System.Drawing.Point(75, 71);
            this.txtIte.Name = "txtIte";
            this.txtIte.Size = new System.Drawing.Size(50, 20);
            this.txtIte.TabIndex = 6;
            this.txtIte.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Iteraciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valores:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(141, 33);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(50, 20);
            this.txtValor2.TabIndex = 2;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(75, 33);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(50, 20);
            this.txtValor1.TabIndex = 1;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(3, 0);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(213, 17);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Ingrese 2 valores para biseccion";
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.SystemColors.Control;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(357, 27);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(413, 319);
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            this.picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(0, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 30);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Graficar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Escala:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "20";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Funcion:";
            // 
            // txtFunc
            // 
            this.txtFunc.Location = new System.Drawing.Point(71, 27);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(232, 20);
            this.txtFunc.TabIndex = 6;
            this.txtFunc.Text = "(x-3)^2-1";
            // 
            // FrmRaiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 357);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.pnlRaiz);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmRaiz";
            this.Text = "Metodos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlRaiz.ResumeLayout(false);
            this.pnlRaiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biseccionToolStripMenuItem;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Panel pnlRaiz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem tangenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglaFalsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secanteToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTole;
        private System.Windows.Forms.TextBox txtIte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

