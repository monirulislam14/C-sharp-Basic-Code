namespace SimpleCalculator
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
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.addLebel = new System.Windows.Forms.Label();
            this.subLebel = new System.Windows.Forms.Label();
            this.mulLebel = new System.Windows.Forms.Label();
            this.divLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(365, 59);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(158, 20);
            this.firstNumberTextBox.TabIndex = 0;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(365, 94);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(158, 20);
            this.secondNumberTextBox.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(365, 162);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(158, 20);
            this.resultTextBox.TabIndex = 2;
            // 
            // addLebel
            // 
            this.addLebel.AutoSize = true;
            this.addLebel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addLebel.Location = new System.Drawing.Point(374, 120);
            this.addLebel.Name = "addLebel";
            this.addLebel.Size = new System.Drawing.Size(28, 15);
            this.addLebel.TabIndex = 3;
            this.addLebel.Text = "Add";
            this.addLebel.Click += new System.EventHandler(this.addLebel_Click);
            // 
            // subLebel
            // 
            this.subLebel.AutoSize = true;
            this.subLebel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subLebel.Location = new System.Drawing.Point(459, 120);
            this.subLebel.Name = "subLebel";
            this.subLebel.Size = new System.Drawing.Size(28, 15);
            this.subLebel.TabIndex = 4;
            this.subLebel.Text = "Sub";
            this.subLebel.Click += new System.EventHandler(this.subLebel_Click);
            // 
            // mulLebel
            // 
            this.mulLebel.AutoSize = true;
            this.mulLebel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mulLebel.Location = new System.Drawing.Point(374, 143);
            this.mulLebel.Name = "mulLebel";
            this.mulLebel.Size = new System.Drawing.Size(26, 15);
            this.mulLebel.TabIndex = 5;
            this.mulLebel.Text = "Mul";
            this.mulLebel.Click += new System.EventHandler(this.mulLebel_Click);
            // 
            // divLevel
            // 
            this.divLevel.AutoSize = true;
            this.divLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.divLevel.Location = new System.Drawing.Point(462, 143);
            this.divLevel.Name = "divLevel";
            this.divLevel.Size = new System.Drawing.Size(25, 15);
            this.divLevel.TabIndex = 6;
            this.divLevel.Text = "Div";
            this.divLevel.Click += new System.EventHandler(this.divLevel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "First Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Second Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Result";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(365, 214);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.divLevel);
            this.Controls.Add(this.mulLebel);
            this.Controls.Add(this.subLebel);
            this.Controls.Add(this.addLebel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label addLebel;
        private System.Windows.Forms.Label subLebel;
        private System.Windows.Forms.Label mulLebel;
        private System.Windows.Forms.Label divLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClearButton;
    }
}

