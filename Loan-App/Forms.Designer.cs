namespace Loan_App
{
    partial class Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.loanNum = new System.Windows.Forms.Label();
            this.custFName = new System.Windows.Forms.Label();
            this.custLName = new System.Windows.Forms.Label();
            this.loanAmount = new System.Windows.Forms.Label();
            this.term = new System.Windows.Forms.Label();
            this.pInRate = new System.Windows.Forms.Label();
            this.loanType = new System.Windows.Forms.Label();
            this.pInRateT = new System.Windows.Forms.TextBox();
            this.loanNumT = new System.Windows.Forms.TextBox();
            this.custFNameT = new System.Windows.Forms.TextBox();
            this.custLNameT = new System.Windows.Forms.TextBox();
            this.loanAmountT = new System.Windows.Forms.TextBox();
            this.businessLoan = new System.Windows.Forms.RadioButton();
            this.personalLoan = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loanNum
            // 
            this.loanNum.AutoSize = true;
            this.loanNum.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanNum.Location = new System.Drawing.Point(26, 216);
            this.loanNum.Name = "loanNum";
            this.loanNum.Size = new System.Drawing.Size(165, 27);
            this.loanNum.TabIndex = 0;
            this.loanNum.Text = "Loan Number :";
            // 
            // custFName
            // 
            this.custFName.AutoSize = true;
            this.custFName.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custFName.Location = new System.Drawing.Point(26, 288);
            this.custFName.Name = "custFName";
            this.custFName.Size = new System.Drawing.Size(135, 27);
            this.custFName.TabIndex = 1;
            this.custFName.Text = "First Name :";
            // 
            // custLName
            // 
            this.custLName.AutoSize = true;
            this.custLName.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custLName.Location = new System.Drawing.Point(26, 351);
            this.custLName.Name = "custLName";
            this.custLName.Size = new System.Drawing.Size(132, 27);
            this.custLName.TabIndex = 2;
            this.custLName.Text = "Last Name :";
            // 
            // loanAmount
            // 
            this.loanAmount.AutoSize = true;
            this.loanAmount.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAmount.Location = new System.Drawing.Point(26, 428);
            this.loanAmount.Name = "loanAmount";
            this.loanAmount.Size = new System.Drawing.Size(165, 27);
            this.loanAmount.TabIndex = 3;
            this.loanAmount.Text = "Loan Amount :";
            // 
            // term
            // 
            this.term.AutoSize = true;
            this.term.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.term.Location = new System.Drawing.Point(27, 501);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(75, 27);
            this.term.TabIndex = 4;
            this.term.Text = "Term :";
            // 
            // pInRate
            // 
            this.pInRate.AutoSize = true;
            this.pInRate.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInRate.Location = new System.Drawing.Point(29, 20);
            this.pInRate.Name = "pInRate";
            this.pInRate.Size = new System.Drawing.Size(222, 27);
            this.pInRate.TabIndex = 5;
            this.pInRate.Text = "Prime Interest Rate :";
            // 
            // loanType
            // 
            this.loanType.AutoSize = true;
            this.loanType.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanType.Location = new System.Drawing.Point(29, 144);
            this.loanType.Name = "loanType";
            this.loanType.Size = new System.Drawing.Size(129, 27);
            this.loanType.TabIndex = 6;
            this.loanType.Text = "Loan Type :";
            this.loanType.Click += new System.EventHandler(this.loanType_Click);
            // 
            // pInRateT
            // 
            this.pInRateT.BackColor = System.Drawing.Color.LightGray;
            this.pInRateT.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInRateT.Location = new System.Drawing.Point(31, 50);
            this.pInRateT.Name = "pInRateT";
            this.pInRateT.Size = new System.Drawing.Size(234, 28);
            this.pInRateT.TabIndex = 8;
            // 
            // loanNumT
            // 
            this.loanNumT.BackColor = System.Drawing.Color.LightGray;
            this.loanNumT.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanNumT.Location = new System.Drawing.Point(31, 246);
            this.loanNumT.Name = "loanNumT";
            this.loanNumT.Size = new System.Drawing.Size(234, 28);
            this.loanNumT.TabIndex = 9;
            // 
            // custFNameT
            // 
            this.custFNameT.BackColor = System.Drawing.Color.LightGray;
            this.custFNameT.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custFNameT.Location = new System.Drawing.Point(31, 318);
            this.custFNameT.Name = "custFNameT";
            this.custFNameT.Size = new System.Drawing.Size(234, 28);
            this.custFNameT.TabIndex = 10;
            // 
            // custLNameT
            // 
            this.custLNameT.BackColor = System.Drawing.Color.LightGray;
            this.custLNameT.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custLNameT.Location = new System.Drawing.Point(31, 381);
            this.custLNameT.Name = "custLNameT";
            this.custLNameT.Size = new System.Drawing.Size(234, 28);
            this.custLNameT.TabIndex = 11;
            // 
            // loanAmountT
            // 
            this.loanAmountT.BackColor = System.Drawing.Color.LightGray;
            this.loanAmountT.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAmountT.Location = new System.Drawing.Point(31, 458);
            this.loanAmountT.Name = "loanAmountT";
            this.loanAmountT.Size = new System.Drawing.Size(234, 28);
            this.loanAmountT.TabIndex = 12;
            // 
            // businessLoan
            // 
            this.businessLoan.AutoSize = true;
            this.businessLoan.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessLoan.Location = new System.Drawing.Point(32, 174);
            this.businessLoan.Name = "businessLoan";
            this.businessLoan.Size = new System.Drawing.Size(151, 28);
            this.businessLoan.TabIndex = 13;
            this.businessLoan.TabStop = true;
            this.businessLoan.Text = "Business Loan";
            this.businessLoan.UseVisualStyleBackColor = true;
            // 
            // personalLoan
            // 
            this.personalLoan.AutoSize = true;
            this.personalLoan.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalLoan.Location = new System.Drawing.Point(189, 175);
            this.personalLoan.Name = "personalLoan";
            this.personalLoan.Size = new System.Drawing.Size(151, 28);
            this.personalLoan.TabIndex = 14;
            this.personalLoan.TabStop = true;
            this.personalLoan.Text = "Personal Loan";
            this.personalLoan.UseVisualStyleBackColor = true;
            this.personalLoan.CheckedChanged += new System.EventHandler(this.personalLoan_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Short-Term",
            "Medium-Term",
            "Long-Term"});
            this.comboBox1.Location = new System.Drawing.Point(32, 531);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 32);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 489);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Details";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button1.Location = new System.Drawing.Point(288, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LType,
            this.LoanNumber,
            this.FName,
            this.LName,
            this.LAmount,
            this.Time});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(407, 106);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 489);
            this.dataGridView1.TabIndex = 18;
            // 
            // LType
            // 
            this.LType.HeaderText = "Loan Type";
            this.LType.MinimumWidth = 6;
            this.LType.Name = "LType";
            this.LType.Width = 125;
            // 
            // LoanNumber
            // 
            this.LoanNumber.HeaderText = "Loan Number";
            this.LoanNumber.MinimumWidth = 6;
            this.LoanNumber.Name = "LoanNumber";
            this.LoanNumber.Width = 125;
            // 
            // FName
            // 
            this.FName.HeaderText = "First Name";
            this.FName.MinimumWidth = 6;
            this.FName.Name = "FName";
            this.FName.Width = 125;
            // 
            // LName
            // 
            this.LName.HeaderText = "Last Name";
            this.LName.MinimumWidth = 6;
            this.LName.Name = "LName";
            this.LName.Width = 125;
            // 
            // LAmount
            // 
            this.LAmount.HeaderText = "Loan Amount";
            this.LAmount.MinimumWidth = 6;
            this.LAmount.Name = "LAmount";
            this.LAmount.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Term";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 125;
            // 
            // Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1249, 715);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.personalLoan);
            this.Controls.Add(this.businessLoan);
            this.Controls.Add(this.loanAmountT);
            this.Controls.Add(this.custLNameT);
            this.Controls.Add(this.custFNameT);
            this.Controls.Add(this.loanNumT);
            this.Controls.Add(this.pInRateT);
            this.Controls.Add(this.loanType);
            this.Controls.Add(this.pInRate);
            this.Controls.Add(this.term);
            this.Controls.Add(this.loanAmount);
            this.Controls.Add(this.custLName);
            this.Controls.Add(this.custFName);
            this.Controls.Add(this.loanNum);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Forms";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loanNum;
        private System.Windows.Forms.Label custFName;
        private System.Windows.Forms.Label custLName;
        private System.Windows.Forms.Label loanAmount;
        private System.Windows.Forms.Label term;
        private System.Windows.Forms.Label pInRate;
        private System.Windows.Forms.Label loanType;
        private System.Windows.Forms.TextBox pInRateT;
        private System.Windows.Forms.TextBox loanNumT;
        private System.Windows.Forms.TextBox custFNameT;
        private System.Windows.Forms.TextBox custLNameT;
        private System.Windows.Forms.TextBox loanAmountT;
        private System.Windows.Forms.RadioButton businessLoan;
        private System.Windows.Forms.RadioButton personalLoan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}