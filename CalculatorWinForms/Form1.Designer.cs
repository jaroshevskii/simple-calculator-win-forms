namespace CalculatorWinForms
{
  partial class CalculatorForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.firstNumberString = new System.Windows.Forms.TextBox();
      this.operationString = new System.Windows.Forms.ComboBox();
      this.secondNumberString = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.resultString = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.calculateButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // firstNumberString
      // 
      this.firstNumberString.Location = new System.Drawing.Point(12, 27);
      this.firstNumberString.Name = "firstNumberString";
      this.firstNumberString.Size = new System.Drawing.Size(100, 23);
      this.firstNumberString.TabIndex = 0;
      this.firstNumberString.TextChanged += new System.EventHandler(this.firstNumber_TextChanged);
      // 
      // operationString
      // 
      this.operationString.FormattingEnabled = true;
      this.operationString.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
      this.operationString.Location = new System.Drawing.Point(118, 27);
      this.operationString.Name = "operationString";
      this.operationString.Size = new System.Drawing.Size(121, 23);
      this.operationString.TabIndex = 1;
      this.operationString.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // secondNumberString
      // 
      this.secondNumberString.Location = new System.Drawing.Point(245, 27);
      this.secondNumberString.Name = "secondNumberString";
      this.secondNumberString.Size = new System.Drawing.Size(100, 23);
      this.secondNumberString.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 15);
      this.label1.TabIndex = 3;
      this.label1.Text = "First number";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(245, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "Second number";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(118, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(60, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "Operation";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(351, 30);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(15, 15);
      this.label4.TabIndex = 6;
      this.label4.Text = "=";
      // 
      // resultString
      // 
      this.resultString.Enabled = false;
      this.resultString.Location = new System.Drawing.Point(372, 27);
      this.resultString.Name = "resultString";
      this.resultString.Size = new System.Drawing.Size(100, 23);
      this.resultString.TabIndex = 7;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(372, 9);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(39, 15);
      this.label5.TabIndex = 8;
      this.label5.Text = "Result";
      // 
      // calculateButton
      // 
      this.calculateButton.Location = new System.Drawing.Point(478, 27);
      this.calculateButton.Name = "calculateButton";
      this.calculateButton.Size = new System.Drawing.Size(75, 23);
      this.calculateButton.TabIndex = 9;
      this.calculateButton.Text = "Calculate";
      this.calculateButton.UseVisualStyleBackColor = true;
      this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
      // 
      // CalculatorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(564, 61);
      this.Controls.Add(this.calculateButton);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.resultString);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.secondNumberString);
      this.Controls.Add(this.operationString);
      this.Controls.Add(this.firstNumberString);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "CalculatorForm";
      this.Text = "Calculator";
      this.Load += new System.EventHandler(this.CalculatorForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox firstNumberString;
    private ComboBox operationString;
    private TextBox secondNumberString;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox resultString;
    private Label label5;
    private Button calculateButton;
  }
}