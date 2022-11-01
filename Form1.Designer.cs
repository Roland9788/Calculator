namespace Калькулятор
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btrez = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btsub = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btmlt = new System.Windows.Forms.Button();
            this.btscCl = new System.Windows.Forms.Button();
            this.btscOp = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(0, 86);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btrez);
            this.groupBox1.Controls.Add(this.bt0);
            this.groupBox1.Controls.Add(this.btadd);
            this.groupBox1.Controls.Add(this.bt9);
            this.groupBox1.Controls.Add(this.bt8);
            this.groupBox1.Controls.Add(this.bt7);
            this.groupBox1.Controls.Add(this.btsub);
            this.groupBox1.Controls.Add(this.bt6);
            this.groupBox1.Controls.Add(this.bt5);
            this.groupBox1.Controls.Add(this.bt4);
            this.groupBox1.Controls.Add(this.btdiv);
            this.groupBox1.Controls.Add(this.bt3);
            this.groupBox1.Controls.Add(this.bt2);
            this.groupBox1.Controls.Add(this.bt1);
            this.groupBox1.Controls.Add(this.btmlt);
            this.groupBox1.Controls.Add(this.btscCl);
            this.groupBox1.Controls.Add(this.btscOp);
            this.groupBox1.Controls.Add(this.btClear);
            this.groupBox1.Location = new System.Drawing.Point(1, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 489);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btrez
            // 
            this.btrez.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btrez.Location = new System.Drawing.Point(299, 397);
            this.btrez.Name = "btrez";
            this.btrez.Size = new System.Drawing.Size(90, 90);
            this.btrez.TabIndex = 19;
            this.btrez.Text = "=";
            this.btrez.UseVisualStyleBackColor = true;
            this.btrez.Click += new System.EventHandler(this.btrez_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt0.Location = new System.Drawing.Point(11, 397);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(282, 90);
            this.bt0.TabIndex = 18;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btadd.Location = new System.Drawing.Point(299, 301);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(90, 90);
            this.btadd.TabIndex = 17;
            this.btadd.Text = "+";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt9.Location = new System.Drawing.Point(203, 301);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(90, 90);
            this.bt9.TabIndex = 16;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt8.Location = new System.Drawing.Point(107, 301);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(90, 90);
            this.bt8.TabIndex = 15;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt7.Location = new System.Drawing.Point(11, 301);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(90, 90);
            this.bt7.TabIndex = 14;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // btsub
            // 
            this.btsub.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btsub.Location = new System.Drawing.Point(299, 205);
            this.btsub.Name = "btsub";
            this.btsub.Size = new System.Drawing.Size(90, 90);
            this.btsub.TabIndex = 13;
            this.btsub.Text = "-";
            this.btsub.UseVisualStyleBackColor = true;
            this.btsub.Click += new System.EventHandler(this.btsub_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt6.Location = new System.Drawing.Point(203, 205);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(90, 90);
            this.bt6.TabIndex = 12;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt5.Location = new System.Drawing.Point(107, 205);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(90, 90);
            this.bt5.TabIndex = 11;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt4.Location = new System.Drawing.Point(11, 205);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(90, 90);
            this.bt4.TabIndex = 10;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // btdiv
            // 
            this.btdiv.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btdiv.Location = new System.Drawing.Point(299, 109);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(90, 90);
            this.btdiv.TabIndex = 9;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.btdiv_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt3.Location = new System.Drawing.Point(203, 109);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(90, 90);
            this.bt3.TabIndex = 8;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt2.Location = new System.Drawing.Point(107, 109);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(90, 90);
            this.bt2.TabIndex = 7;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt1.Location = new System.Drawing.Point(11, 109);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(90, 90);
            this.bt1.TabIndex = 6;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btmlt
            // 
            this.btmlt.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btmlt.Location = new System.Drawing.Point(299, 13);
            this.btmlt.Name = "btmlt";
            this.btmlt.Size = new System.Drawing.Size(90, 90);
            this.btmlt.TabIndex = 5;
            this.btmlt.Text = "*";
            this.btmlt.UseVisualStyleBackColor = true;
            this.btmlt.Click += new System.EventHandler(this.btmlt_Click);
            // 
            // btscCl
            // 
            this.btscCl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btscCl.Location = new System.Drawing.Point(203, 13);
            this.btscCl.Name = "btscCl";
            this.btscCl.Size = new System.Drawing.Size(90, 90);
            this.btscCl.TabIndex = 4;
            this.btscCl.Text = "(";
            this.btscCl.UseVisualStyleBackColor = true;
            this.btscCl.Click += new System.EventHandler(this.btscCl_Click);
            // 
            // btscOp
            // 
            this.btscOp.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btscOp.Location = new System.Drawing.Point(107, 13);
            this.btscOp.Name = "btscOp";
            this.btscOp.Size = new System.Drawing.Size(90, 90);
            this.btscOp.TabIndex = 3;
            this.btscOp.Text = ")";
            this.btscOp.UseVisualStyleBackColor = true;
            this.btscOp.Click += new System.EventHandler(this.btscOp_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btClear.Location = new System.Drawing.Point(11, 13);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(90, 90);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(417, 655);
            this.MinimumSize = new System.Drawing.Size(417, 655);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Калькулятор by:Roland9788";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btadd;
        private Button bt9;
        private Button bt8;
        private Button bt7;
        private Button btsub;
        private Button bt6;
        private Button bt5;
        private Button bt4;
        private Button btdiv;
        private Button bt3;
        private Button bt2;
        private Button bt1;
        private Button btmlt;
        private Button btscCl;
        private Button btscOp;
        private Button btClear;
        private Button btrez;
        private Button bt0;
        private System.Windows.Forms.Timer timer1;
    }
}