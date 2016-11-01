namespace Panties64
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.timesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.decreaseTimes = new System.Windows.Forms.Button();
            this.increaseTimes = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 12);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(654, 172);
            this.inputBox.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 190);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(654, 172);
            this.outputBox.TabIndex = 1;
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(591, 397);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(75, 23);
            this.encodeButton.TabIndex = 2;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(591, 368);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(75, 23);
            this.decodeButton.TabIndex = 3;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // timesBox
            // 
            this.timesBox.Location = new System.Drawing.Point(463, 370);
            this.timesBox.Name = "timesBox";
            this.timesBox.ReadOnly = true;
            this.timesBox.Size = new System.Drawing.Size(105, 20);
            this.timesBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of times to run: ";
            // 
            // decreaseTimes
            // 
            this.decreaseTimes.Location = new System.Drawing.Point(463, 397);
            this.decreaseTimes.Name = "decreaseTimes";
            this.decreaseTimes.Size = new System.Drawing.Size(31, 23);
            this.decreaseTimes.TabIndex = 7;
            this.decreaseTimes.Text = "-";
            this.decreaseTimes.UseVisualStyleBackColor = true;
            this.decreaseTimes.Click += new System.EventHandler(this.button2_Click);
            // 
            // increaseTimes
            // 
            this.increaseTimes.Location = new System.Drawing.Point(537, 397);
            this.increaseTimes.Name = "increaseTimes";
            this.increaseTimes.Size = new System.Drawing.Size(31, 23);
            this.increaseTimes.TabIndex = 8;
            this.increaseTimes.Text = "+";
            this.increaseTimes.UseVisualStyleBackColor = true;
            this.increaseTimes.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(500, 397);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(31, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "1";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Interval = 10;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 426);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.increaseTimes);
            this.Controls.Add(this.decreaseTimes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timesBox);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Panties64 - Encode/Decode Secret Messages for Crystaltheglaceonism!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.TextBox timesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decreaseTimes;
        private System.Windows.Forms.Button increaseTimes;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer timerCheck;
    }
}

