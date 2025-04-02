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
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            textBoxAccountNumberMovimentation = new TextBox();
            label3 = new Label();
            textBoxValueMovimentation = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            textBoxTransferMovimentation = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tableLayoutPanel1.Location = new Point(12, 115);
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
            textBoxName.Size = new Size(108, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(153, 34);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(108, 23);
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
            textBoxInitialBalance.Size = new Size(108, 23);
            textBoxInitialBalance.TabIndex = 5;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(3, 125);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(144, 23);
            buttonNew.TabIndex = 7;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(153, 125);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(108, 23);
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
            textBoxLimit.Size = new Size(108, 23);
            textBoxLimit.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.69643F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.30357F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxAccountNumberMovimentation, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(textBoxValueMovimentation, 1, 1);
            tableLayoutPanel2.Controls.Add(button2, 1, 2);
            tableLayoutPanel2.Controls.Add(button1, 0, 2);
            tableLayoutPanel2.Controls.Add(button3, 2, 2);
            tableLayoutPanel2.Controls.Add(button4, 3, 2);
            tableLayoutPanel2.Controls.Add(button5, 4, 2);
            tableLayoutPanel2.Controls.Add(label1, 2, 0);
            tableLayoutPanel2.Controls.Add(textBoxTransferMovimentation, 3, 0);
            tableLayoutPanel2.Location = new Point(12, 315);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 51.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 48.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.Size = new Size(568, 103);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Account number:";
            // 
            // textBoxAccountNumberMovimentation
            // 
            textBoxAccountNumberMovimentation.Location = new Point(136, 3);
            textBoxAccountNumberMovimentation.Name = "textBoxAccountNumberMovimentation";
            textBoxAccountNumberMovimentation.Size = new Size(96, 23);
            textBoxAccountNumberMovimentation.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 36);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Value:";
            // 
            // textBoxValueMovimentation
            // 
            textBoxValueMovimentation.Location = new Point(136, 39);
            textBoxValueMovimentation.Name = "textBoxValueMovimentation";
            textBoxValueMovimentation.Size = new Size(96, 23);
            textBoxValueMovimentation.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(136, 73);
            button2.Name = "button2";
            button2.Size = new Size(96, 23);
            button2.TabIndex = 6;
            button2.Text = "Withdrawl";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 73);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 7;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(238, 73);
            button3.Name = "button3";
            button3.Size = new Size(101, 23);
            button3.TabIndex = 8;
            button3.Text = "Deposit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(345, 73);
            button4.Name = "button4";
            button4.Size = new Size(110, 23);
            button4.TabIndex = 9;
            button4.Text = "Check balance";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(461, 73);
            button5.Name = "button5";
            button5.Size = new Size(104, 23);
            button5.TabIndex = 10;
            button5.Text = "Transfer";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 11;
            label1.Text = "Transfer to:";
            // 
            // textBoxTransferMovimentation
            // 
            textBoxTransferMovimentation.Location = new Point(345, 3);
            textBoxTransferMovimentation.Name = "textBoxTransferMovimentation";
            textBoxTransferMovimentation.Size = new Size(110, 23);
            textBoxTransferMovimentation.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox textBoxAccountNumberMovimentation;
        private Label label3;
        private TextBox textBoxValueMovimentation;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private TextBox textBoxTransferMovimentation;
    }
}
