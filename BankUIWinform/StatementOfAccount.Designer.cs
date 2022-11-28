namespace BankAppUI
{
    partial class formStatementOfAccount
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
            this.lblAcctNum = new System.Windows.Forms.Label();
            this.txtAcctNum = new System.Windows.Forms.TextBox();
            this.btnSoA = new System.Windows.Forms.Button();
            this.dataGridSoA = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblSoAHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSoA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAcctNum
            // 
            this.lblAcctNum.AutoSize = true;
            this.lblAcctNum.BackColor = System.Drawing.Color.Transparent;
            this.lblAcctNum.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAcctNum.ForeColor = System.Drawing.Color.White;
            this.lblAcctNum.Location = new System.Drawing.Point(123, 63);
            this.lblAcctNum.Name = "lblAcctNum";
            this.lblAcctNum.Size = new System.Drawing.Size(425, 44);
            this.lblAcctNum.TabIndex = 1;
            this.lblAcctNum.Text = "ACCOUNT NUMBER :";
            // 
            // txtAcctNum
            // 
            this.txtAcctNum.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAcctNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAcctNum.Location = new System.Drawing.Point(608, 61);
            this.txtAcctNum.Multiline = true;
            this.txtAcctNum.Name = "txtAcctNum";
            this.txtAcctNum.Size = new System.Drawing.Size(452, 46);
            this.txtAcctNum.TabIndex = 1;
            // 
            // btnSoA
            // 
            this.btnSoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnSoA.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSoA.ForeColor = System.Drawing.Color.Snow;
            this.btnSoA.Location = new System.Drawing.Point(608, 148);
            this.btnSoA.Name = "btnSoA";
            this.btnSoA.Size = new System.Drawing.Size(452, 63);
            this.btnSoA.TabIndex = 9;
            this.btnSoA.Text = "PRINT STATEMENT";
            this.btnSoA.UseVisualStyleBackColor = false;
            this.btnSoA.Click += new System.EventHandler(this.btnSoA_Click);
            // 
            // dataGridSoA
            // 
            this.dataGridSoA.AllowUserToAddRows = false;
            this.dataGridSoA.AllowUserToDeleteRows = false;
            this.dataGridSoA.AllowUserToOrderColumns = true;
            this.dataGridSoA.AllowUserToResizeColumns = false;
            this.dataGridSoA.AllowUserToResizeRows = false;
            this.dataGridSoA.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSoA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridSoA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSoA.GridColor = System.Drawing.Color.Black;
            this.dataGridSoA.Location = new System.Drawing.Point(265, 302);
            this.dataGridSoA.Name = "dataGridSoA";
            this.dataGridSoA.RowHeadersWidth = 62;
            this.dataGridSoA.RowTemplate.Height = 33;
            this.dataGridSoA.Size = new System.Drawing.Size(795, 246);
            this.dataGridSoA.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnHome.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Snow;
            this.btnHome.Location = new System.Drawing.Point(882, 569);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 63);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblSoAHeader
            // 
            this.lblSoAHeader.AutoSize = true;
            this.lblSoAHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblSoAHeader.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoAHeader.ForeColor = System.Drawing.Color.White;
            this.lblSoAHeader.Location = new System.Drawing.Point(265, 265);
            this.lblSoAHeader.Name = "lblSoAHeader";
            this.lblSoAHeader.Size = new System.Drawing.Size(587, 34);
            this.lblSoAHeader.TabIndex = 1;
            this.lblSoAHeader.Text = "ACCOUNT STATEMENT ON ACCOUNT NO";
            this.lblSoAHeader.Click += new System.EventHandler(this.lblSoAHeader_Click);
            // 
            // formStatementOfAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.lblSoAHeader);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dataGridSoA);
            this.Controls.Add(this.btnSoA);
            this.Controls.Add(this.lblAcctNum);
            this.Controls.Add(this.txtAcctNum);
            this.MaximizeBox = false;
            this.Name = "formStatementOfAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STATEMENT OF ACCOUNT";
            this.Load += new System.EventHandler(this.formStatementOfAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSoA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAcctNum;
        private TextBox txtAcctNum;
        private Button btnSoA;
        private DataGridView dataGridSoA;
        private Button btnHome;
        private Label lblSoAHeader;
    }
}