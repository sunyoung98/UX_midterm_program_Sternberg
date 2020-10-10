namespace SternbergTest
{
    partial class Form2
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
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn3.Font = new System.Drawing.Font("굴림", 23F);
            this.btn3.Location = new System.Drawing.Point(100, 200);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(179, 52);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.input_btn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn4.Font = new System.Drawing.Font("굴림", 23F);
            this.btn4.Location = new System.Drawing.Point(450, 200);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(179, 52);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.input_btn_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn5.Font = new System.Drawing.Font("굴림", 23F);
            this.btn5.Location = new System.Drawing.Point(100, 300);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(179, 52);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.input_btn_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn6.Font = new System.Drawing.Font("굴림", 23F);
            this.btn6.Location = new System.Drawing.Point(450, 300);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(179, 52);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.input_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F);
            this.label1.Location = new System.Drawing.Point(100, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "아래의 세트 중 하나를 클릭하세요.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 30F);
            this.label2.Location = new System.Drawing.Point(286, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startBtn.Font = new System.Drawing.Font("굴림", 23F);
            this.startBtn.Location = new System.Drawing.Point(300, 301);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(179, 52);
            this.startBtn.TabIndex = 14;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.input_btn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseBtn.Font = new System.Drawing.Font("굴림", 23F);
            this.CloseBtn.Location = new System.Drawing.Point(300, 301);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(179, 52);
            this.CloseBtn.TabIndex = 15;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.input_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button CloseBtn;
        //private System.Windows.Forms.Label label3;
    }
}