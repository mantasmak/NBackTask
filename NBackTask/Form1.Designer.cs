namespace NBackTask
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
            this.butPositive = new System.Windows.Forms.Button();
            this.butNegative = new System.Windows.Forms.Button();
            this.labNumber = new System.Windows.Forms.Label();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.picBottom = new System.Windows.Forms.PictureBox();
            this.butStart = new System.Windows.Forms.Button();
            this.labCountdown = new System.Windows.Forms.Label();
            this.labEnding = new System.Windows.Forms.Label();
            this.butEnd = new System.Windows.Forms.Button();
            this.labN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labCorrect = new System.Windows.Forms.Label();
            this.labWrong = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labSequence = new System.Windows.Forms.Label();
            this.textBoxSeq = new System.Windows.Forms.TextBox();
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
            this.labNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumber.Location = new System.Drawing.Point(385, 155);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(0, 31);
            this.labNumber.TabIndex = 2;
            this.labNumber.Visible = false;
            // 
            // picTop
            // 
            this.picTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picTop.Location = new System.Drawing.Point(335, 99);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(133, 22);
            this.picTop.TabIndex = 3;
            this.picTop.TabStop = false;
            // 
            // picBottom
            // 
            this.picBottom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBottom.Location = new System.Drawing.Point(335, 199);
            this.picBottom.Name = "picBottom";
            this.picBottom.Size = new System.Drawing.Size(133, 22);
            this.picBottom.TabIndex = 4;
            this.picBottom.TabStop = false;
            // 
            // butStart
            // 
            this.butStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart.Location = new System.Drawing.Point(218, 314);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(374, 124);
            this.butStart.TabIndex = 5;
            this.butStart.Text = "PRADĖTI";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
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
            this.butEnd.Text = "BAIGTI";
            this.butEnd.UseVisualStyleBackColor = true;
            this.butEnd.Visible = false;
            this.butEnd.Click += new System.EventHandler(this.butEnd_Click);
            // 
            // labN
            // 
            this.labN.AutoSize = true;
            this.labN.Location = new System.Drawing.Point(370, 170);
            this.labN.Name = "labN";
            this.labN.Size = new System.Drawing.Size(15, 13);
            this.labN.TabIndex = 10;
            this.labN.Text = "N";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(391, 167);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(28, 20);
            this.textBoxN.TabIndex = 11;
            this.textBoxN.Text = "3";
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxN_TextChanged_1);
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
            this.labName.Location = new System.Drawing.Point(345, 142);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(40, 13);
            this.labName.TabIndex = 14;
            this.labName.Text = "Vardas";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(391, 139);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(77, 20);
            this.textBoxName.TabIndex = 15;
            // 
            // labSequence
            // 
            this.labSequence.AutoSize = true;
            this.labSequence.Location = new System.Drawing.Point(352, 201);
            this.labSequence.Name = "labSequence";
            this.labSequence.Size = new System.Drawing.Size(32, 13);
            this.labSequence.TabIndex = 16;
            this.labSequence.Text = "Seka";
            // 
            // textBoxSeq
            // 
            this.textBoxSeq.Location = new System.Drawing.Point(390, 198);
            this.textBoxSeq.Name = "textBoxSeq";
            this.textBoxSeq.Size = new System.Drawing.Size(150, 20);
            this.textBoxSeq.TabIndex = 17;
            this.textBoxSeq.TextChanged += new System.EventHandler(this.textBoxSeq_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSeq);
            this.Controls.Add(this.labSequence);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labWrong);
            this.Controls.Add(this.labCorrect);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labN);
            this.Controls.Add(this.butEnd);
            this.Controls.Add(this.labEnding);
            this.Controls.Add(this.labCountdown);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.picBottom);
            this.Controls.Add(this.picTop);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.butNegative);
            this.Controls.Add(this.butPositive);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button butStart;
        public System.Windows.Forms.Label labCountdown;
        public System.Windows.Forms.Label labEnding;
        private System.Windows.Forms.Button butEnd;
        private System.Windows.Forms.Label labN;
        private System.Windows.Forms.TextBox textBoxN;
        public System.Windows.Forms.Label labCorrect;
        public System.Windows.Forms.Label labWrong;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labSequence;
        private System.Windows.Forms.TextBox textBoxSeq;
    }
}

