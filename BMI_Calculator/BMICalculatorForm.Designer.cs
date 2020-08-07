namespace BMI_Calculator
{
    partial class BMICalculatorForm
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
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextbox = new System.Windows.Forms.TextBox();
            this.BmiResult = new System.Windows.Forms.TextBox();
            this.HeightTextbox = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.UnitGroupBox = new System.Windows.Forms.GroupBox();
            this.BmiScaleResult = new System.Windows.Forms.TextBox();
            this.GenerateCalculatorButton = new System.Windows.Forms.Button();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.TableLayoutPanel.SuspendLayout();
            this.UnitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(175, 27);
            this.MetricRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(142, 44);
            this.MetricRadioButton.TabIndex = 0;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseMnemonic = false;
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.Click += new System.EventHandler(this.UnitRadioButton_Click);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(0, 27);
            this.ImperialRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(173, 44);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.Click += new System.EventHandler(this.UnitRadioButton_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(8, 8);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(131, 44);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "My Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(8, 52);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(136, 50);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "My Weight:";
            // 
            // WeightTextbox
            // 
            this.WeightTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightTextbox.Location = new System.Drawing.Point(176, 59);
            this.WeightTextbox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.WeightTextbox.Name = "WeightTextbox";
            this.WeightTextbox.Size = new System.Drawing.Size(99, 49);
            this.WeightTextbox.TabIndex = 3;
            // 
            // BmiResult
            // 
            this.BmiResult.BackColor = System.Drawing.Color.White;
            this.BmiResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableLayoutPanel.SetColumnSpan(this.BmiResult, 3);
            this.BmiResult.Location = new System.Drawing.Point(8, 175);
            this.BmiResult.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BmiResult.Name = "BmiResult";
            this.BmiResult.Size = new System.Drawing.Size(284, 49);
            this.BmiResult.TabIndex = 4;
            // 
            // HeightTextbox
            // 
            this.HeightTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightTextbox.Location = new System.Drawing.Point(176, 15);
            this.HeightTextbox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.HeightTextbox.Name = "HeightTextbox";
            this.HeightTextbox.Size = new System.Drawing.Size(99, 49);
            this.HeightTextbox.TabIndex = 5;
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 3;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.33333F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.315615F));
            this.TableLayoutPanel.Controls.Add(this.HeightTextbox, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.UnitGroupBox, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.BmiResult, 0, 5);
            this.TableLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.WeightTextbox, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.BmiScaleResult, 1, 8);
            this.TableLayoutPanel.Controls.Add(this.GenerateCalculatorButton, 0, 7);
            this.TableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 6);
            this.TableLayoutPanel.Controls.Add(this.ResetButton, 0, 8);
            this.TableLayoutPanel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 9;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.66667F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.55556F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.65079F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.01587F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(300, 449);
            this.TableLayoutPanel.TabIndex = 8;
            // 
            // UnitGroupBox
            // 
            this.TableLayoutPanel.SetColumnSpan(this.UnitGroupBox, 3);
            this.UnitGroupBox.Controls.Add(this.ImperialRadioButton);
            this.UnitGroupBox.Controls.Add(this.MetricRadioButton);
            this.UnitGroupBox.Location = new System.Drawing.Point(3, 105);
            this.UnitGroupBox.Name = "UnitGroupBox";
            this.TableLayoutPanel.SetRowSpan(this.UnitGroupBox, 2);
            this.UnitGroupBox.Size = new System.Drawing.Size(290, 60);
            this.UnitGroupBox.TabIndex = 8;
            this.UnitGroupBox.TabStop = false;
            this.UnitGroupBox.Text = "Select Units";
            // 
            // BmiScaleResult
            // 
            this.BmiScaleResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel.SetColumnSpan(this.BmiScaleResult, 3);
            this.BmiScaleResult.Location = new System.Drawing.Point(3, 405);
            this.BmiScaleResult.Name = "BmiScaleResult";
            this.BmiScaleResult.Size = new System.Drawing.Size(294, 49);
            this.BmiScaleResult.TabIndex = 11;
            // 
            // GenerateCalculatorButton
            // 
            this.GenerateCalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TableLayoutPanel.SetColumnSpan(this.GenerateCalculatorButton, 2);
            this.GenerateCalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateCalculatorButton.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateCalculatorButton.ForeColor = System.Drawing.Color.Snow;
            this.GenerateCalculatorButton.Location = new System.Drawing.Point(3, 285);
            this.GenerateCalculatorButton.Name = "GenerateCalculatorButton";
            this.GenerateCalculatorButton.Size = new System.Drawing.Size(277, 57);
            this.GenerateCalculatorButton.TabIndex = 12;
            this.GenerateCalculatorButton.Text = "Extra Button";
            this.GenerateCalculatorButton.UseVisualStyleBackColor = false;
            this.GenerateCalculatorButton.Click += new System.EventHandler(this.GenerateCalculatorButton_Click);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TableLayoutPanel.SetColumnSpan(this.CalculateBMIButton, 2);
            this.CalculateBMIButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.ForeColor = System.Drawing.Color.Snow;
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 222);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(277, 57);
            this.CalculateBMIButton.TabIndex = 10;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.Snow;
            this.ResetButton.Location = new System.Drawing.Point(3, 348);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(149, 51);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(300, 449);
            this.Controls.Add(this.TableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " BMI CALCULATOR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.UnitGroupBox.ResumeLayout(false);
            this.UnitGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextbox;
        private System.Windows.Forms.TextBox BmiResult;
        private System.Windows.Forms.TextBox HeightTextbox;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.GroupBox UnitGroupBox;
        private System.Windows.Forms.Button ResetButton;
        protected System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox BmiScaleResult;
        private System.Windows.Forms.Button GenerateCalculatorButton;
    }
}

