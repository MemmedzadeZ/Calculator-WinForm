namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.yazitxt = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnC = new System.Windows.Forms.Button();
            this.btnmi = new System.Windows.Forms.Button();
            this.btnfaiz = new System.Windows.Forms.Button();
            this.btnbol = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnvur = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btmplus = new System.Windows.Forms.Button();
            this.btnberaber = new System.Windows.Forms.Button();
            this.btnvergul = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // yazitxt
            // 
            this.yazitxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yazitxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.yazitxt.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yazitxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.yazitxt.Location = new System.Drawing.Point(-9, 49);
            this.yazitxt.MaxLength = 20;
            this.yazitxt.Name = "yazitxt";
            this.yazitxt.ReadOnly = true;
            this.yazitxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.yazitxt.Size = new System.Drawing.Size(416, 99);
            this.yazitxt.TabIndex = 0;
            this.yazitxt.Text = "0";
            this.yazitxt.UseWaitCursor = true;
            this.yazitxt.TextChanged += new System.EventHandler(this.yazitxt_TextChanged);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnC.Font = new System.Drawing.Font("Segoe UI Historic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnC.Location = new System.Drawing.Point(4, 154);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(84, 73);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnmi
            // 
            this.btnmi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmi.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnmi.Location = new System.Drawing.Point(106, 154);
            this.btnmi.Name = "btnmi";
            this.btnmi.Size = new System.Drawing.Size(88, 73);
            this.btnmi.TabIndex = 2;
            this.btnmi.Text = "+/-";
            this.btnmi.UseVisualStyleBackColor = false;
            this.btnmi.Click += new System.EventHandler(this.btnmi_Click);
            // 
            // btnfaiz
            // 
            this.btnfaiz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfaiz.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnfaiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnfaiz.Location = new System.Drawing.Point(210, 154);
            this.btnfaiz.Name = "btnfaiz";
            this.btnfaiz.Size = new System.Drawing.Size(86, 73);
            this.btnfaiz.TabIndex = 3;
            this.btnfaiz.Text = "%";
            this.btnfaiz.UseVisualStyleBackColor = false;
            this.btnfaiz.Click += new System.EventHandler(this.btnfaiz_Click);
            // 
            // btnbol
            // 
            this.btnbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnbol.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnbol.Location = new System.Drawing.Point(311, 154);
            this.btnbol.Name = "btnbol";
            this.btnbol.Size = new System.Drawing.Size(87, 73);
            this.btnbol.TabIndex = 4;
            this.btnbol.Text = "/";
            this.btnbol.UseVisualStyleBackColor = false;
            this.btnbol.Click += new System.EventHandler(this.btnbol_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn7.Location = new System.Drawing.Point(4, 242);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(84, 73);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn8.Location = new System.Drawing.Point(107, 242);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(87, 73);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn9.Location = new System.Drawing.Point(210, 242);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(86, 73);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnvur
            // 
            this.btnvur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnvur.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnvur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnvur.Location = new System.Drawing.Point(311, 242);
            this.btnvur.Name = "btnvur";
            this.btnvur.Size = new System.Drawing.Size(87, 73);
            this.btnvur.TabIndex = 8;
            this.btnvur.Text = "x";
            this.btnvur.UseVisualStyleBackColor = false;
            this.btnvur.Click += new System.EventHandler(this.btnvur_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn4.Location = new System.Drawing.Point(4, 330);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(84, 73);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn5.Location = new System.Drawing.Point(107, 330);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(87, 73);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn6.Location = new System.Drawing.Point(210, 330);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(86, 73);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.Fuchsia;
            this.btnminus.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnminus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnminus.Location = new System.Drawing.Point(311, 330);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(87, 73);
            this.btnminus.TabIndex = 12;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = false;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn1.Location = new System.Drawing.Point(4, 419);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(84, 73);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(107, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 73);
            this.button1.TabIndex = 15;
            this.button1.Text = "2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn3.Location = new System.Drawing.Point(210, 419);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(86, 73);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btmplus
            // 
            this.btmplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btmplus.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btmplus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btmplus.Location = new System.Drawing.Point(311, 419);
            this.btmplus.Name = "btmplus";
            this.btmplus.Size = new System.Drawing.Size(87, 73);
            this.btmplus.TabIndex = 17;
            this.btmplus.Text = "+";
            this.btmplus.UseVisualStyleBackColor = false;
            this.btmplus.Click += new System.EventHandler(this.btmplus_Click);
            // 
            // btnberaber
            // 
            this.btnberaber.BackColor = System.Drawing.Color.Purple;
            this.btnberaber.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnberaber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnberaber.Location = new System.Drawing.Point(311, 505);
            this.btnberaber.Name = "btnberaber";
            this.btnberaber.Size = new System.Drawing.Size(87, 73);
            this.btnberaber.TabIndex = 18;
            this.btnberaber.Text = "=";
            this.btnberaber.UseVisualStyleBackColor = false;
            this.btnberaber.Click += new System.EventHandler(this.btnberaber_Click);
            // 
            // btnvergul
            // 
            this.btnvergul.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvergul.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnvergul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnvergul.Location = new System.Drawing.Point(210, 505);
            this.btnvergul.Name = "btnvergul";
            this.btnvergul.Size = new System.Drawing.Size(87, 73);
            this.btnvergul.TabIndex = 19;
            this.btnvergul.Text = ",";
            this.btnvergul.UseVisualStyleBackColor = false;
            this.btnvergul.Click += new System.EventHandler(this.btnvergul_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.Color.Purple;
            this.btn0.Location = new System.Drawing.Point(4, 505);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(190, 73);
            this.btn0.TabIndex = 20;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(295, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(410, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnvergul);
            this.Controls.Add(this.btnberaber);
            this.Controls.Add(this.btmplus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnvur);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnbol);
            this.Controls.Add(this.btnfaiz);
            this.Controls.Add(this.btnmi);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.yazitxt);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RichTextBox yazitxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button btnC;
        private Button btnmi;
        private Button btnfaiz;
        private Button btnbol;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnvur;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnminus;
        private Button btn1;
        private Button button1;
        private Button btn3;
        private Button btmplus;
        private Button btnberaber;
        private Button btnvergul;
        private Button btn0;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
    }
}