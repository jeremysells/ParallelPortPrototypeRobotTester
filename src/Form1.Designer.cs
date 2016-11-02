namespace simpleRobot_controller_V1._0
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
            this.components = new System.ComponentModel.Container();
            this.buttonFoward = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonStop1 = new System.Windows.Forms.Button();
            this.buttonStop2 = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonLeft360 = new System.Windows.Forms.Button();
            this.buttonRight360 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timerPWM = new System.Windows.Forms.Timer(this.components);
            this.trackBarMovementSpeed = new System.Windows.Forms.TrackBar();
            this.trackBarGapPWM = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labeltrackBarMovementSpeed = new System.Windows.Forms.Label();
            this.labeltrackBarGapPWM = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMovementSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGapPWM)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFoward
            // 
            this.buttonFoward.Location = new System.Drawing.Point(103, 26);
            this.buttonFoward.Name = "buttonFoward";
            this.buttonFoward.Size = new System.Drawing.Size(84, 47);
            this.buttonFoward.TabIndex = 0;
            this.buttonFoward.Text = "Foward";
            this.buttonFoward.UseVisualStyleBackColor = true;
            this.buttonFoward.Click += new System.EventHandler(this.buttonFoward_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(12, 79);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(89, 46);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(187, 79);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(93, 46);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonStop1
            // 
            this.buttonStop1.Location = new System.Drawing.Point(102, 131);
            this.buttonStop1.Name = "buttonStop1";
            this.buttonStop1.Size = new System.Drawing.Size(84, 55);
            this.buttonStop1.TabIndex = 3;
            this.buttonStop1.Text = "Stop1";
            this.buttonStop1.UseVisualStyleBackColor = true;
            this.buttonStop1.Click += new System.EventHandler(this.buttonStop1_Click);
            // 
            // buttonStop2
            // 
            this.buttonStop2.Location = new System.Drawing.Point(103, 192);
            this.buttonStop2.Name = "buttonStop2";
            this.buttonStop2.Size = new System.Drawing.Size(84, 57);
            this.buttonStop2.TabIndex = 4;
            this.buttonStop2.Text = "Stop2";
            this.buttonStop2.UseVisualStyleBackColor = true;
            this.buttonStop2.Click += new System.EventHandler(this.buttonStop2_Click);
            // 
            // buttonReverse
            // 
            this.buttonReverse.Location = new System.Drawing.Point(108, 80);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(73, 45);
            this.buttonReverse.TabIndex = 5;
            this.buttonReverse.Text = "Reverse";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // buttonLeft360
            // 
            this.buttonLeft360.Location = new System.Drawing.Point(12, 131);
            this.buttonLeft360.Name = "buttonLeft360";
            this.buttonLeft360.Size = new System.Drawing.Size(89, 43);
            this.buttonLeft360.TabIndex = 6;
            this.buttonLeft360.Text = "Left 360";
            this.buttonLeft360.UseVisualStyleBackColor = true;
            this.buttonLeft360.Click += new System.EventHandler(this.buttonLeft360_Click);
            // 
            // buttonRight360
            // 
            this.buttonRight360.Location = new System.Drawing.Point(187, 131);
            this.buttonRight360.Name = "buttonRight360";
            this.buttonRight360.Size = new System.Drawing.Size(89, 43);
            this.buttonRight360.TabIndex = 7;
            this.buttonRight360.Text = "Right 360";
            this.buttonRight360.UseVisualStyleBackColor = true;
            this.buttonRight360.Click += new System.EventHandler(this.buttonRight360_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(66, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 56);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "keybord controls";
            // 
            // timerPWM
            // 
            this.timerPWM.Tick += new System.EventHandler(this.timerPWM_Tick);
            // 
            // trackBarMovementSpeed
            // 
            this.trackBarMovementSpeed.Location = new System.Drawing.Point(12, 327);
            this.trackBarMovementSpeed.Maximum = 50;
            this.trackBarMovementSpeed.Minimum = 5;
            this.trackBarMovementSpeed.Name = "trackBarMovementSpeed";
            this.trackBarMovementSpeed.Size = new System.Drawing.Size(257, 42);
            this.trackBarMovementSpeed.TabIndex = 13;
            this.trackBarMovementSpeed.Value = 5;
            this.trackBarMovementSpeed.Scroll += new System.EventHandler(this.trackBarMovementSpeed_Scroll);
            this.trackBarMovementSpeed.Move += new System.EventHandler(this.trackBarMovementSpeed_Move);
            // 
            // trackBarGapPWM
            // 
            this.trackBarGapPWM.Location = new System.Drawing.Point(12, 387);
            this.trackBarGapPWM.Maximum = 22;
            this.trackBarGapPWM.Minimum = 1;
            this.trackBarGapPWM.Name = "trackBarGapPWM";
            this.trackBarGapPWM.Size = new System.Drawing.Size(257, 42);
            this.trackBarGapPWM.TabIndex = 9;
            this.trackBarGapPWM.Value = 1;
            this.trackBarGapPWM.Scroll += new System.EventHandler(this.trackBarGapPWM_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ttotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "PWM Speed";
            // 
            // labeltrackBarMovementSpeed
            // 
            this.labeltrackBarMovementSpeed.AutoSize = true;
            this.labeltrackBarMovementSpeed.Location = new System.Drawing.Point(225, 311);
            this.labeltrackBarMovementSpeed.Name = "labeltrackBarMovementSpeed";
            this.labeltrackBarMovementSpeed.Size = new System.Drawing.Size(35, 13);
            this.labeltrackBarMovementSpeed.TabIndex = 17;
            this.labeltrackBarMovementSpeed.Text = "label3";
            // 
            // labeltrackBarGapPWM
            // 
            this.labeltrackBarGapPWM.AutoSize = true;
            this.labeltrackBarGapPWM.Location = new System.Drawing.Point(225, 375);
            this.labeltrackBarGapPWM.Name = "labeltrackBarGapPWM";
            this.labeltrackBarGapPWM.Size = new System.Drawing.Size(35, 13);
            this.labeltrackBarGapPWM.TabIndex = 18;
            this.labeltrackBarGapPWM.Text = "label3";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(286, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 407);
            this.listBox1.TabIndex = 19;            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 444);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labeltrackBarGapPWM);
            this.Controls.Add(this.labeltrackBarMovementSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarGapPWM);
            this.Controls.Add(this.trackBarMovementSpeed);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRight360);
            this.Controls.Add(this.buttonLeft360);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.buttonStop2);
            this.Controls.Add(this.buttonStop1);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonFoward);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMovementSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGapPWM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFoward;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonStop1;
        private System.Windows.Forms.Button buttonStop2;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Button buttonLeft360;
        private System.Windows.Forms.Button buttonRight360;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerPWM;
        private System.Windows.Forms.TrackBar trackBarMovementSpeed;
        private System.Windows.Forms.TrackBar trackBarGapPWM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeltrackBarMovementSpeed;
        private System.Windows.Forms.Label labeltrackBarGapPWM;
        private System.Windows.Forms.ListBox listBox1;
    }
}

