namespace Math_Game
{
    partial class Form1
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
            this.lblFNumber = new System.Windows.Forms.Label();
            this.lblOpration = new System.Windows.Forms.Label();
            this.lblSNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMid = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lblResulte = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFNumber
            // 
            this.lblFNumber.AutoSize = true;
            this.lblFNumber.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFNumber.Location = new System.Drawing.Point(251, 109);
            this.lblFNumber.Name = "lblFNumber";
            this.lblFNumber.Size = new System.Drawing.Size(29, 32);
            this.lblFNumber.TabIndex = 0;
            this.lblFNumber.Text = "0";
            this.lblFNumber.Click += new System.EventHandler(this.lblFNumber_Click);
            // 
            // lblOpration
            // 
            this.lblOpration.AutoSize = true;
            this.lblOpration.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOpration.Location = new System.Drawing.Point(363, 109);
            this.lblOpration.Name = "lblOpration";
            this.lblOpration.Size = new System.Drawing.Size(31, 32);
            this.lblOpration.TabIndex = 1;
            this.lblOpration.Text = "+";
            this.lblOpration.Click += new System.EventHandler(this.lblOpration_Click);
            // 
            // lblSNumber
            // 
            this.lblSNumber.AutoSize = true;
            this.lblSNumber.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSNumber.Location = new System.Drawing.Point(482, 109);
            this.lblSNumber.Name = "lblSNumber";
            this.lblSNumber.Size = new System.Drawing.Size(29, 32);
            this.lblSNumber.TabIndex = 2;
            this.lblSNumber.Text = "0";
            this.lblSNumber.Click += new System.EventHandler(this.lblSNumber_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(598, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Another Quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHard);
            this.groupBox1.Controls.Add(this.rbMid);
            this.groupBox1.Controls.Add(this.rbEasy);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 193);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quizez Level";
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(28, 129);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(61, 23);
            this.rbHard.TabIndex = 2;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.CheckedChanged += new System.EventHandler(this.rbHard_CheckedChanged);
            // 
            // rbMid
            // 
            this.rbMid.AutoSize = true;
            this.rbMid.Location = new System.Drawing.Point(28, 87);
            this.rbMid.Name = "rbMid";
            this.rbMid.Size = new System.Drawing.Size(75, 23);
            this.rbMid.TabIndex = 1;
            this.rbMid.TabStop = true;
            this.rbMid.Text = "Midum";
            this.rbMid.UseVisualStyleBackColor = true;
            this.rbMid.CheckedChanged += new System.EventHandler(this.rbMid_CheckedChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Location = new System.Drawing.Point(28, 42);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(60, 23);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(240, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(307, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(20, 22);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "0";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(642, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Show Answer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(614, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Check Answer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 241);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opration";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(28, 170);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(97, 23);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Divide \"/\"";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 129);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 23);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mutibly \"*\"";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Subtract \"-\"";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(28, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 23);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Plus \"+\"";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblResulte
            // 
            this.lblResulte.AutoSize = true;
            this.lblResulte.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResulte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResulte.Location = new System.Drawing.Point(658, 332);
            this.lblResulte.Name = "lblResulte";
            this.lblResulte.Size = new System.Drawing.Size(20, 22);
            this.lblResulte.TabIndex = 13;
            this.lblResulte.Text = "0";
            this.lblResulte.Click += new System.EventHandler(this.lblResulte_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(804, 521);
            this.Controls.Add(this.lblResulte);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSNumber);
            this.Controls.Add(this.lblOpration);
            this.Controls.Add(this.lblFNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFNumber;
        private System.Windows.Forms.Label lblOpration;
        private System.Windows.Forms.Label lblSNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMid;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label lblResulte;
    }
}

