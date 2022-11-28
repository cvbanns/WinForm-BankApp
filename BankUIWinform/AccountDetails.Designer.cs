namespace BankAppUI
{
    partial class formAccountDetails
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
            this.btnHome = new System.Windows.Forms.Button();
            this.dataGridAcctDeetUser = new System.Windows.Forms.DataGridView();
            this.lblAcctDeetUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcctDeetUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnHome.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Snow;
            this.btnHome.Location = new System.Drawing.Point(880, 533);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 63);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dataGridAcctDeetUser
            // 
            this.dataGridAcctDeetUser.AllowUserToAddRows = false;
            this.dataGridAcctDeetUser.AllowUserToDeleteRows = false;
            this.dataGridAcctDeetUser.AllowUserToResizeColumns = false;
            this.dataGridAcctDeetUser.AllowUserToResizeRows = false;
            this.dataGridAcctDeetUser.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAcctDeetUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAcctDeetUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAcctDeetUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAcctDeetUser.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridAcctDeetUser.Location = new System.Drawing.Point(121, 138);
            this.dataGridAcctDeetUser.Name = "dataGridAcctDeetUser";
            this.dataGridAcctDeetUser.RowHeadersWidth = 62;
            this.dataGridAcctDeetUser.RowTemplate.Height = 33;
            this.dataGridAcctDeetUser.Size = new System.Drawing.Size(937, 372);
            this.dataGridAcctDeetUser.TabIndex = 1;
            this.dataGridAcctDeetUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAcctDeetUser_CellContentClick);
            // 
            // lblAcctDeetUser
            // 
            this.lblAcctDeetUser.AutoSize = true;
            this.lblAcctDeetUser.BackColor = System.Drawing.Color.Transparent;
            this.lblAcctDeetUser.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAcctDeetUser.ForeColor = System.Drawing.Color.White;
            this.lblAcctDeetUser.Location = new System.Drawing.Point(121, 53);
            this.lblAcctDeetUser.Name = "lblAcctDeetUser";
            this.lblAcctDeetUser.Size = new System.Drawing.Size(403, 44);
            this.lblAcctDeetUser.TabIndex = 1;
            this.lblAcctDeetUser.Text = "ACCOUNT DETAILS";
            // 
            // formAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dataGridAcctDeetUser);
            this.Controls.Add(this.lblAcctDeetUser);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MaximizeBox = false;
            this.Name = "formAccountDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCOUNT DETAILS";
            this.Load += new System.EventHandler(this.formAccountDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcctDeetUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHome;
        private DataGridView dataGridAcctDeetUser;
        private Label lblAcctDeetUser;
    }
}