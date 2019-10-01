namespace interestClaculator
{
    partial class InterestCalculator
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
            this.formulaComboBox = new System.Windows.Forms.ComboBox();
            this.SolveForLebel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowFormulaLebel = new System.Windows.Forms.Label();
            this.PrincipalTextBox = new System.Windows.Forms.TextBox();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.TimecomboBox = new System.Windows.Forms.ComboBox();
            this.PrincipalLebel = new System.Windows.Forms.Label();
            this.RateLebel = new System.Windows.Forms.Label();
            this.TimeLebel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // formulaComboBox
            // 
            this.formulaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formulaComboBox.FormattingEnabled = true;
            this.formulaComboBox.Location = new System.Drawing.Point(292, 51);
            this.formulaComboBox.Name = "formulaComboBox";
            this.formulaComboBox.Size = new System.Drawing.Size(225, 21);
            this.formulaComboBox.TabIndex = 0;
            this.formulaComboBox.SelectedIndexChanged += new System.EventHandler(this.formulaComboBox_SelectedIndexChanged);
            this.formulaComboBox.DropDownStyleChanged += new System.EventHandler(this.formulaComboBox_SelectedIndexChanged);
            // 
            // SolveForLebel
            // 
            this.SolveForLebel.AutoSize = true;
            this.SolveForLebel.Location = new System.Drawing.Point(213, 59);
            this.SolveForLebel.Name = "SolveForLebel";
            this.SolveForLebel.Size = new System.Drawing.Size(52, 13);
            this.SolveForLebel.TabIndex = 1;
            this.SolveForLebel.Text = "Solve For";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Where";
            // 
            // ShowFormulaLebel
            // 
            this.ShowFormulaLebel.AutoSize = true;
            this.ShowFormulaLebel.Location = new System.Drawing.Point(326, 89);
            this.ShowFormulaLebel.Name = "ShowFormulaLebel";
            this.ShowFormulaLebel.Size = new System.Drawing.Size(0, 13);
            this.ShowFormulaLebel.TabIndex = 3;
            // 
            // PrincipalTextBox
            // 
            this.PrincipalTextBox.Location = new System.Drawing.Point(292, 109);
            this.PrincipalTextBox.Name = "PrincipalTextBox";
            this.PrincipalTextBox.Size = new System.Drawing.Size(225, 20);
            this.PrincipalTextBox.TabIndex = 4;
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(292, 148);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(225, 20);
            this.RateTextBox.TabIndex = 5;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(292, 203);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(225, 20);
            this.TimeTextBox.TabIndex = 6;
            // 
            // TimecomboBox
            // 
            this.TimecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimecomboBox.FormattingEnabled = true;
            this.TimecomboBox.Location = new System.Drawing.Point(292, 229);
            this.TimecomboBox.Name = "TimecomboBox";
            this.TimecomboBox.Size = new System.Drawing.Size(225, 21);
            this.TimecomboBox.TabIndex = 7;
            // 
            // PrincipalLebel
            // 
            this.PrincipalLebel.AutoSize = true;
            this.PrincipalLebel.Location = new System.Drawing.Point(194, 115);
            this.PrincipalLebel.Name = "PrincipalLebel";
            this.PrincipalLebel.Size = new System.Drawing.Size(75, 13);
            this.PrincipalLebel.TabIndex = 8;
            this.PrincipalLebel.Text = "Principal (P): $";
            // 
            // RateLebel
            // 
            this.RateLebel.AutoSize = true;
            this.RateLebel.Location = new System.Drawing.Point(197, 154);
            this.RateLebel.Name = "RateLebel";
            this.RateLebel.Size = new System.Drawing.Size(61, 13);
            this.RateLebel.TabIndex = 9;
            this.RateLebel.Text = "Rate (R): %";
            // 
            // TimeLebel
            // 
            this.TimeLebel.AutoSize = true;
            this.TimeLebel.Location = new System.Drawing.Point(210, 210);
            this.TimeLebel.Name = "TimeLebel";
            this.TimeLebel.Size = new System.Drawing.Size(48, 13);
            this.TimeLebel.TabIndex = 10;
            this.TimeLebel.Text = "Time (t) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Per Year";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(292, 270);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(442, 270);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 14;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Answer:";
            // 
            // ShowAnswerTextBox
            // 
            this.ShowAnswerTextBox.Location = new System.Drawing.Point(343, 320);
            this.ShowAnswerTextBox.Name = "ShowAnswerTextBox";
            this.ShowAnswerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShowAnswerTextBox.TabIndex = 16;
            // 
            // InterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowAnswerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLebel);
            this.Controls.Add(this.RateLebel);
            this.Controls.Add(this.PrincipalLebel);
            this.Controls.Add(this.TimecomboBox);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.RateTextBox);
            this.Controls.Add(this.PrincipalTextBox);
            this.Controls.Add(this.ShowFormulaLebel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SolveForLebel);
            this.Controls.Add(this.formulaComboBox);
            this.Name = "InterestCalculator";
            this.Text = "Simple Interest Calcualtor";
            this.Load += new System.EventHandler(this.InterestCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox formulaComboBox;
        private System.Windows.Forms.Label SolveForLebel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ShowFormulaLebel;
        private System.Windows.Forms.TextBox PrincipalTextBox;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.ComboBox TimecomboBox;
        private System.Windows.Forms.Label PrincipalLebel;
        private System.Windows.Forms.Label RateLebel;
        private System.Windows.Forms.Label TimeLebel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ShowAnswerTextBox;
    }
}

