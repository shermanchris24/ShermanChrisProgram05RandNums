namespace ShermanChrisProgram05RandNums
{
    partial class randNumsListBox
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.labelofNumRands = new System.Windows.Forms.Label();
            this.randNumsTextBox = new System.Windows.Forms.TextBox();
            this.writeToFileButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.readFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(35, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(425, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Chris\'s Random Number File Writer";
            // 
            // labelofNumRands
            // 
            this.labelofNumRands.AutoSize = true;
            this.labelofNumRands.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelofNumRands.Location = new System.Drawing.Point(12, 73);
            this.labelofNumRands.Name = "labelofNumRands";
            this.labelofNumRands.Size = new System.Drawing.Size(434, 18);
            this.labelofNumRands.TabIndex = 1;
            this.labelofNumRands.Text = "Choose how many random numbers you want to generate (1-20)";
            // 
            // randNumsTextBox
            // 
            this.randNumsTextBox.Location = new System.Drawing.Point(495, 73);
            this.randNumsTextBox.Name = "randNumsTextBox";
            this.randNumsTextBox.Size = new System.Drawing.Size(59, 22);
            this.randNumsTextBox.TabIndex = 2;
            // 
            // writeToFileButton
            // 
            this.writeToFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeToFileButton.Location = new System.Drawing.Point(378, 131);
            this.writeToFileButton.Name = "writeToFileButton";
            this.writeToFileButton.Size = new System.Drawing.Size(157, 50);
            this.writeToFileButton.TabIndex = 3;
            this.writeToFileButton.Text = "Write to File";
            this.writeToFileButton.UseVisualStyleBackColor = true;
            this.writeToFileButton.Click += new System.EventHandler(this.writeToFileButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(124, 372);
            this.listBox1.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(40, 511);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 28);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(385, 511);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 28);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(358, 216);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(177, 60);
            this.readFileButton.TabIndex = 7;
            this.readFileButton.Text = "Read From File";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // randNumsListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 596);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.writeToFileButton);
            this.Controls.Add(this.randNumsTextBox);
            this.Controls.Add(this.labelofNumRands);
            this.Controls.Add(this.titleLabel);
            this.Name = "randNumsListBox";
            this.Text = "Chris Sherman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label labelofNumRands;
        private System.Windows.Forms.TextBox randNumsTextBox;
        private System.Windows.Forms.Button writeToFileButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

