namespace BankAppUI
{
    partial class formHomePage
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
            this.btnCreateNewAcct = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnAcctBal = new System.Windows.Forms.Button();
            this.btnSoA = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateNewAcct
            // 
            this.btnCreateNewAcct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnCreateNewAcct.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateNewAcct.ForeColor = System.Drawing.Color.Snow;
            this.btnCreateNewAcct.Location = new System.Drawing.Point(112, 134);
            this.btnCreateNewAcct.Name = "btnCreateNewAcct";
            this.btnCreateNewAcct.Size = new System.Drawing.Size(452, 63);
            this.btnCreateNewAcct.TabIndex = 7;
            this.btnCreateNewAcct.Text = "CREATE NEW ACCOUNT";
            this.btnCreateNewAcct.UseVisualStyleBackColor = false;
            this.btnCreateNewAcct.Click += new System.EventHandler(this.btnCreateNewAcct_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnWithdraw.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWithdraw.ForeColor = System.Drawing.Color.Snow;
            this.btnWithdraw.Location = new System.Drawing.Point(614, 134);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(452, 63);
            this.btnWithdraw.TabIndex = 8;
            this.btnWithdraw.Text = "WITHDRAW";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnDeposit.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.ForeColor = System.Drawing.Color.Snow;
            this.btnDeposit.Location = new System.Drawing.Point(614, 232);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(452, 63);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "DEPOSIT";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnAcctBal
            // 
            this.btnAcctBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnAcctBal.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAcctBal.ForeColor = System.Drawing.Color.Snow;
            this.btnAcctBal.Location = new System.Drawing.Point(112, 232);
            this.btnAcctBal.Name = "btnAcctBal";
            this.btnAcctBal.Size = new System.Drawing.Size(452, 63);
            this.btnAcctBal.TabIndex = 13;
            this.btnAcctBal.Text = "ACCOUNT DETAILS";
            this.btnAcctBal.UseVisualStyleBackColor = false;
            this.btnAcctBal.Click += new System.EventHandler(this.btnAcctBal_Click);
            // 
            // btnSoA
            // 
            this.btnSoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnSoA.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSoA.ForeColor = System.Drawing.Color.Snow;
            this.btnSoA.Location = new System.Drawing.Point(112, 327);
            this.btnSoA.Name = "btnSoA";
            this.btnSoA.Size = new System.Drawing.Size(452, 63);
            this.btnSoA.TabIndex = 10;
            this.btnSoA.Text = "STATEMENT OF ACCOUNT";
            this.btnSoA.UseVisualStyleBackColor = false;
            this.btnSoA.Click += new System.EventHandler(this.btnSoA_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnTransfer.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.ForeColor = System.Drawing.Color.Snow;
            this.btnTransfer.Location = new System.Drawing.Point(614, 327);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(452, 63);
            this.btnTransfer.TabIndex = 11;
            this.btnTransfer.Text = "TRANSFER";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Snow;
            this.btnLogout.Location = new System.Drawing.Point(361, 447);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(452, 63);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // formHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.btnCreateNewAcct);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnAcctBal);
            this.Controls.Add(this.btnSoA);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnLogout);
            this.MaximizeBox = false;
            this.Name = "formHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.formHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateNewAcct;
        private Button btnWithdraw;
        private Button btnDeposit;
        private Button btnAcctBal;
        private Button btnSoA;
        private Button btnTransfer;
        private Button btnLogout;
    }
}