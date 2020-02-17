namespace NBackTask
{
    partial class NbackTask
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
            this.butPositive = new System.Windows.Forms.Button();
            this.butNegative = new System.Windows.Forms.Button();
            this.labNumber = new System.Windows.Forms.Label();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.picBottom = new System.Windows.Forms.PictureBox();
            this.labCountdown = new System.Windows.Forms.Label();
            this.labEnding = new System.Windows.Forms.Label();
            this.butEnd = new System.Windows.Forms.Button();
            this.labCorrect = new System.Windows.Forms.Label();
            this.labWrong = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.butTest1 = new System.Windows.Forms.Button();
            this.butTest2 = new System.Windows.Forms.Button();
            this.butTest3 = new System.Windows.Forms.Button();
            this.butTest4 = new System.Windows.Forms.Button();
            this.butTest5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // butPositive
            // 
            this.butPositive.Enabled = false;
            this.butPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPositive.Location = new System.Drawing.Point(12, 314);
            this.butPositive.Name = "butPositive";
            this.butPositive.Size = new System.Drawing.Size(374, 124);
            this.butPositive.TabIndex = 0;
            this.butPositive.Text = "TAIP";
            this.butPositive.UseVisualStyleBackColor = true;
            this.butPositive.Visible = false;
            this.butPositive.Click += new System.EventHandler(this.butPositive_Click);
            // 
            // butNegative
            // 
            this.butNegative.Enabled = false;
            this.butNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNegative.Location = new System.Drawing.Point(414, 314);
            this.butNegative.Name = "butNegative";
            this.butNegative.Size = new System.Drawing.Size(374, 124);
            this.butNegative.TabIndex = 1;
            this.butNegative.Text = "NE";
            this.butNegative.UseVisualStyleBackColor = true;
            this.butNegative.Visible = false;
            this.butNegative.Click += new System.EventHandler(this.butNegative_Click);
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumber.Location = new System.Drawing.Point(336, 73);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(0, 153);
            this.labNumber.TabIndex = 2;
            this.labNumber.Visible = false;
            // 
            // picTop
            // 
            this.picTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picTop.Location = new System.Drawing.Point(335, 52);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(133, 22);
            this.picTop.TabIndex = 3;
            this.picTop.TabStop = false;
            // 
            // picBottom
            // 
            this.picBottom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBottom.Location = new System.Drawing.Point(335, 229);
            this.picBottom.Name = "picBottom";
            this.picBottom.Size = new System.Drawing.Size(133, 22);
            this.picBottom.TabIndex = 4;
            this.picBottom.TabStop = false;
            // 
            // labCountdown
            // 
            this.labCountdown.AutoSize = true;
            this.labCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCountdown.Location = new System.Drawing.Point(385, 155);
            this.labCountdown.Name = "labCountdown";
            this.labCountdown.Size = new System.Drawing.Size(0, 31);
            this.labCountdown.TabIndex = 6;
            this.labCountdown.Visible = false;
            // 
            // labEnding
            // 
            this.labEnding.AutoSize = true;
            this.labEnding.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnding.Location = new System.Drawing.Point(307, 142);
            this.labEnding.Name = "labEnding";
            this.labEnding.Size = new System.Drawing.Size(206, 31);
            this.labEnding.TabIndex = 8;
            this.labEnding.Text = "Tyrimas baigtas";
            this.labEnding.Visible = false;
            // 
            // butEnd
            // 
            this.butEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEnd.Location = new System.Drawing.Point(218, 314);
            this.butEnd.Name = "butEnd";
            this.butEnd.Size = new System.Drawing.Size(374, 124);
            this.butEnd.TabIndex = 9;
            this.butEnd.Text = "IŠSAUGOTI";
            this.butEnd.UseVisualStyleBackColor = true;
            this.butEnd.Visible = false;
            this.butEnd.Click += new System.EventHandler(this.butEnd_Click);
            // 
            // labCorrect
            // 
            this.labCorrect.AutoSize = true;
            this.labCorrect.BackColor = System.Drawing.SystemColors.Control;
            this.labCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCorrect.ForeColor = System.Drawing.Color.LimeGreen;
            this.labCorrect.Location = new System.Drawing.Point(337, 142);
            this.labCorrect.Name = "labCorrect";
            this.labCorrect.Size = new System.Drawing.Size(131, 31);
            this.labCorrect.TabIndex = 12;
            this.labCorrect.Text = "Teisingai!";
            this.labCorrect.Visible = false;
            // 
            // labWrong
            // 
            this.labWrong.AutoSize = true;
            this.labWrong.BackColor = System.Drawing.SystemColors.Control;
            this.labWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWrong.ForeColor = System.Drawing.Color.Red;
            this.labWrong.Location = new System.Drawing.Point(356, 142);
            this.labWrong.Name = "labWrong";
            this.labWrong.Size = new System.Drawing.Size(97, 31);
            this.labWrong.TabIndex = 13;
            this.labWrong.Text = "Blogai!";
            this.labWrong.Visible = false;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(345, 122);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(40, 13);
            this.labName.TabIndex = 14;
            this.labName.Text = "Vardas";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(391, 119);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(77, 20);
            this.textBoxName.TabIndex = 15;
            // 
            // butTest1
            // 
            this.butTest1.Location = new System.Drawing.Point(218, 176);
            this.butTest1.Name = "butTest1";
            this.butTest1.Size = new System.Drawing.Size(374, 47);
            this.butTest1.TabIndex = 16;
            this.butTest1.Text = "Bandymas (N = 2)";
            this.butTest1.UseVisualStyleBackColor = true;
            this.butTest1.Click += new System.EventHandler(this.butTest1_Click);
            // 
            // butTest2
            // 
            this.butTest2.Location = new System.Drawing.Point(218, 229);
            this.butTest2.Name = "butTest2";
            this.butTest2.Size = new System.Drawing.Size(374, 47);
            this.butTest2.TabIndex = 17;
            this.butTest2.Text = "N = 2";
            this.butTest2.UseVisualStyleBackColor = true;
            this.butTest2.Click += new System.EventHandler(this.butTest2_Click);
            // 
            // butTest3
            // 
            this.butTest3.Location = new System.Drawing.Point(218, 282);
            this.butTest3.Name = "butTest3";
            this.butTest3.Size = new System.Drawing.Size(374, 47);
            this.butTest3.TabIndex = 18;
            this.butTest3.Text = "N = 3";
            this.butTest3.UseVisualStyleBackColor = true;
            this.butTest3.Click += new System.EventHandler(this.butTest3_Click);
            // 
            // butTest4
            // 
            this.butTest4.Location = new System.Drawing.Point(218, 335);
            this.butTest4.Name = "butTest4";
            this.butTest4.Size = new System.Drawing.Size(374, 47);
            this.butTest4.TabIndex = 19;
            this.butTest4.Text = "N = 4";
            this.butTest4.UseVisualStyleBackColor = true;
            this.butTest4.Click += new System.EventHandler(this.butTest4_Click);
            // 
            // butTest5
            // 
            this.butTest5.Location = new System.Drawing.Point(218, 388);
            this.butTest5.Name = "butTest5";
            this.butTest5.Size = new System.Drawing.Size(374, 47);
            this.butTest5.TabIndex = 20;
            this.butTest5.Text = "N = 5";
            this.butTest5.UseVisualStyleBackColor = true;
            this.butTest5.Click += new System.EventHandler(this.butTest5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Github: mantasmak";
            // 
            // NbackTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butTest5);
            this.Controls.Add(this.butTest4);
            this.Controls.Add(this.butTest3);
            this.Controls.Add(this.butTest2);
            this.Controls.Add(this.butTest1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labWrong);
            this.Controls.Add(this.labCorrect);
            this.Controls.Add(this.butEnd);
            this.Controls.Add(this.labEnding);
            this.Controls.Add(this.labCountdown);
            this.Controls.Add(this.picBottom);
            this.Controls.Add(this.picTop);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.butNegative);
            this.Controls.Add(this.butPositive);
            this.Name = "NbackTask";
            this.Text = "VisualNbackTask";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butPositive;
        private System.Windows.Forms.Button butNegative;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.PictureBox picBottom;
        public System.Windows.Forms.Label labNumber;
        public System.Windows.Forms.Label labCountdown;
        public System.Windows.Forms.Label labEnding;
        private System.Windows.Forms.Button butEnd;
        public System.Windows.Forms.Label labCorrect;
        public System.Windows.Forms.Label labWrong;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button butTest1;
        private System.Windows.Forms.Button butTest2;
        private System.Windows.Forms.Button butTest3;
        private System.Windows.Forms.Button butTest4;
        private System.Windows.Forms.Button butTest5;
        private System.Windows.Forms.Label label1;
    }
}

