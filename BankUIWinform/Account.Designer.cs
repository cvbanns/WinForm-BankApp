namespace BankAppUI
{
    partial class formAccount
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
            this.rdBtnSavings = new System.Windows.Forms.RadioButton();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtOpenBal = new System.Windows.Forms.TextBox();
            this.btnCreateAcct = new System.Windows.Forms.Button();
            this.rdBtnCurrent = new System.Windows.Forms.RadioButton();
            this.lblAcctTypeQue = new System.Windows.Forms.Label();
            this.lblAcctTypeRdbtn = new System.Windows.Forms.Label();
            this.grpBoxAcctType = new System.Windows.Forms.GroupBox();
            this.lblOpenBal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBoxAcctType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdBtnSavings
            // 
            this.rdBtnSavings.AutoSize = true;
            this.rdBtnSavings.ForeColor = System.Drawing.Color.White;
            this.rdBtnSavings.Location = new System.Drawing.Point(15, 35);
            this.rdBtnSavings.Name = "rdBtnSavings";
            this.rdBtnSavings.Size = new System.Drawing.Size(133, 33);
            this.rdBtnSavings.TabIndex = 1;
            this.rdBtnSavings.TabStop = true;
            this.rdBtnSavings.Text = "SAVINGS";
            this.rdBtnSavings.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnHome.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Snow;
            this.btnHome.Location = new System.Drawing.Point(618, 501);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(452, 63);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtOpenBal
            // 
            this.txtOpenBal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtOpenBal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpenBal.Location = new System.Drawing.Point(15, 30);
            this.txtOpenBal.Multiline = true;
            this.txtOpenBal.Name = "txtOpenBal";
            this.txtOpenBal.Size = new System.Drawing.Size(424, 46);
            this.txtOpenBal.TabIndex = 1;
            this.txtOpenBal.TextChanged += new System.EventHandler(this.txtOpenBal_TextChanged);
            // 
            // btnCreateAcct
            // 
            this.btnCreateAcct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnCreateAcct.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateAcct.ForeColor = System.Drawing.Color.Snow;
            this.btnCreateAcct.Location = new System.Drawing.Point(618, 410);
            this.btnCreateAcct.Name = "btnCreateAcct";
            this.btnCreateAcct.Size = new System.Drawing.Size(452, 63);
            this.btnCreateAcct.TabIndex = 1;
            this.btnCreateAcct.Text = "CREATE ACCOUNT";
            this.btnCreateAcct.UseVisualStyleBackColor = false;
            this.btnCreateAcct.Click += new System.EventHandler(this.btnCreateAcct_Click);
            // 
            // rdBtnCurrent
            // 
            this.rdBtnCurrent.AutoSize = true;
            this.rdBtnCurrent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdBtnCurrent.Location = new System.Drawing.Point(305, 37);
            this.rdBtnCurrent.Name = "rdBtnCurrent";
            this.rdBtnCurrent.Size = new System.Drawing.Size(141, 33);
            this.rdBtnCurrent.TabIndex = 13;
            this.rdBtnCurrent.TabStop = true;
            this.rdBtnCurrent.Text = "CURRENT";
            this.rdBtnCurrent.UseVisualStyleBackColor = true;
            // 
            // lblAcctTypeQue
            // 
            this.lblAcctTypeQue.AutoSize = true;
            this.lblAcctTypeQue.BackColor = System.Drawing.Color.Transparent;
            this.lblAcctTypeQue.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblAcctTypeQue.ForeColor = System.Drawing.Color.White;
            this.lblAcctTypeQue.Location = new System.Drawing.Point(153, 96);
            this.lblAcctTypeQue.Name = "lblAcctTypeQue";
            this.lblAcctTypeQue.Size = new System.Drawing.Size(881, 38);
            this.lblAcctTypeQue.TabIndex = 1;
            this.lblAcctTypeQue.Text = "Kindly select what type of Account you\'d like to open.";
            // 
            // lblAcctTypeRdbtn
            // 
            this.lblAcctTypeRdbtn.AutoSize = true;
            this.lblAcctTypeRdbtn.BackColor = System.Drawing.Color.Transparent;
            this.lblAcctTypeRdbtn.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAcctTypeRdbtn.ForeColor = System.Drawing.Color.White;
            this.lblAcctTypeRdbtn.Location = new System.Drawing.Point(210, 200);
            this.lblAcctTypeRdbtn.Name = "lblAcctTypeRdbtn";
            this.lblAcctTypeRdbtn.Size = new System.Drawing.Size(355, 44);
            this.lblAcctTypeRdbtn.TabIndex = 14;
            this.lblAcctTypeRdbtn.Text = "ACCOUNT TYPE :";
            // 
            // grpBoxAcctType
            // 
            this.grpBoxAcctType.Controls.Add(this.rdBtnSavings);
            this.grpBoxAcctType.Controls.Add(this.rdBtnCurrent);
            this.grpBoxAcctType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBoxAcctType.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpBoxAcctType.Location = new System.Drawing.Point(612, 174);
            this.grpBoxAcctType.Name = "grpBoxAcctType";
            this.grpBoxAcctType.Size = new System.Drawing.Size(452, 94);
            this.grpBoxAcctType.TabIndex = 1;
            this.grpBoxAcctType.TabStop = false;
            this.grpBoxAcctType.Text = "SAVINGS/CURRENT";
            // 
            // lblOpenBal
            // 
            this.lblOpenBal.AutoSize = true;
            this.lblOpenBal.BackColor = System.Drawing.Color.Transparent;
            this.lblOpenBal.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOpenBal.ForeColor = System.Drawing.Color.White;
            this.lblOpenBal.Location = new System.Drawing.Point(130, 316);
            this.lblOpenBal.Name = "lblOpenBal";
            this.lblOpenBal.Size = new System.Drawing.Size(435, 44);
            this.lblOpenBal.TabIndex = 1;
            this.lblOpenBal.Text = "OPENING BALANCE :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOpenBal);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(612, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 95);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Savings Minimum opening balance is 1000";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // formAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOpenBal);
            this.Controls.Add(this.grpBoxAcctType);
            this.Controls.Add(this.lblAcctTypeRdbtn);
            this.Controls.Add(this.lblAcctTypeQue);
            this.Controls.Add(this.btnCreateAcct);
            this.Controls.Add(this.btnHome);
            this.MaximizeBox = false;
            this.Name = "formAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOUNT";
            this.Load += new System.EventHandler(this.formAccount_Load);
            this.grpBoxAcctType.ResumeLayout(false);
            this.grpBoxAcctType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton rdBtnSavings;
        private Button btnHome;
        private TextBox txtOpenBal;
        private Button btnCreateAcct;
        private RadioButton rdBtnCurrent;
        private Label lblAcctTypeQue;
        private Label lblAcctTypeRdbtn;
        private GroupBox grpBoxAcctType;
        private Label lblOpenBal;
        private GroupBox groupBox1;
    }
}