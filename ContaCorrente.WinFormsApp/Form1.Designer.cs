namespace ContaCorrente.WinFormsApp
{
    partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            labelName = new Label();
            labelNumber = new Label();
            textBoxName = new TextBox();
            textBoxNumber = new TextBox();
            labelInitialBalance = new Label();
            textBoxInitialBalance = new TextBox();
            buttonNew = new Button();
            buttonSave = new Button();
            labelLimit = new Label();
            textBoxLimit = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.81818F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.18182F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 303F));
            tableLayoutPanel1.Controls.Add(labelName, 0, 0);
            tableLayoutPanel1.Controls.Add(labelNumber, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxName, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxNumber, 1, 1);
            tableLayoutPanel1.Controls.Add(labelInitialBalance, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxInitialBalance, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonNew, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonSave, 1, 4);
            tableLayoutPanel1.Controls.Add(labelLimit, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxLimit, 1, 3);
            tableLayoutPanel1.Location = new Point(32, 69);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.Size = new Size(568, 194);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(3, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(3, 31);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(100, 15);
            labelNumber.TabIndex = 1;
            labelNumber.Text = "Account number:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(153, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(153, 34);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(100, 23);
            textBoxNumber.TabIndex = 3;
            // 
            // labelInitialBalance
            // 
            labelInitialBalance.AutoSize = true;
            labelInitialBalance.Location = new Point(3, 60);
            labelInitialBalance.Name = "labelInitialBalance";
            labelInitialBalance.Size = new Size(83, 15);
            labelInitialBalance.TabIndex = 4;
            labelInitialBalance.Text = "Initial balance:";
            // 
            // textBoxInitialBalance
            // 
            textBoxInitialBalance.Location = new Point(153, 63);
            textBoxInitialBalance.Name = "textBoxInitialBalance";
            textBoxInitialBalance.Size = new Size(100, 23);
            textBoxInitialBalance.TabIndex = 5;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(3, 125);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 23);
            buttonNew.TabIndex = 7;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(153, 125);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelLimit
            // 
            labelLimit.AutoSize = true;
            labelLimit.Location = new Point(3, 92);
            labelLimit.Name = "labelLimit";
            labelLimit.Size = new Size(37, 15);
            labelLimit.TabIndex = 8;
            labelLimit.Text = "Limit:";
            // 
            // textBoxLimit
            // 
            textBoxLimit.Location = new Point(153, 95);
            textBoxLimit.Name = "textBoxLimit";
            textBoxLimit.Size = new Size(100, 23);
            textBoxLimit.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelName;
        private Label labelNumber;
        private TextBox textBoxName;
        private TextBox textBoxNumber;
        private Label labelInitialBalance;
        private TextBox textBoxInitialBalance;
        private Button buttonSave;
        private Button buttonNew;
        private Label labelLimit;
        private TextBox textBoxLimit;
    }
}
