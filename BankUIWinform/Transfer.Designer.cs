namespace BankAppUI
{
    partial class formTransfer
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDestAcct = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtDestAcct = new System.Windows.Forms.TextBox();
            this.lblSendAcct = new System.Windows.Forms.Label();
            this.txtSendAcct = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(534, 384);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(222, 44);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "AMOUNT :";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Location = new System.Drawing.Point(780, 384);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(332, 46);
            this.txtAmount.TabIndex = 1;
            // 
            // lblDestAcct
            // 
            this.lblDestAcct.AutoSize = true;
            this.lblDestAcct.BackColor = System.Drawing.Color.Transparent;
            this.lblDestAcct.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestAcct.ForeColor = System.Drawing.Color.White;
            this.lblDestAcct.Location = new System.Drawing.Point(29, 296);
            this.lblDestAcct.Name = "lblDestAcct";
            this.lblDestAcct.Size = new System.Drawing.Size(727, 44);
            this.lblDestAcct.TabIndex = 1;
            this.lblDestAcct.Text = "DESTINATION ACCOUNT NUMBER :";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnTransfer.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.ForeColor = System.Drawing.Color.Snow;
            this.btnTransfer.Location = new System.Drawing.Point(780, 476);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(332, 63);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "TRANSFER";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtDestAcct
            // 
            this.txtDestAcct.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDestAcct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestAcct.Location = new System.Drawing.Point(780, 294);
            this.txtDestAcct.Multiline = true;
            this.txtDestAcct.Name = "txtDestAcct";
            this.txtDestAcct.Size = new System.Drawing.Size(332, 46);
            this.txtDestAcct.TabIndex = 1;
            // 
            // lblSendAcct
            // 
            this.lblSendAcct.AutoSize = true;
            this.lblSendAcct.BackColor = System.Drawing.Color.Transparent;
            this.lblSendAcct.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSendAcct.ForeColor = System.Drawing.Color.White;
            this.lblSendAcct.Location = new System.Drawing.Point(155, 202);
            this.lblSendAcct.Name = "lblSendAcct";
            this.lblSendAcct.Size = new System.Drawing.Size(601, 44);
            this.lblSendAcct.TabIndex = 1;
            this.lblSendAcct.Text = "SENDER ACCOUNT NUMBER :";
            // 
            // txtSendAcct
            // 
            this.txtSendAcct.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSendAcct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSendAcct.Location = new System.Drawing.Point(780, 202);
            this.txtSendAcct.Multiline = true;
            this.txtSendAcct.Name = "txtSendAcct";
            this.txtSendAcct.Size = new System.Drawing.Size(332, 46);
            this.txtSendAcct.TabIndex = 1;
            this.txtSendAcct.TextChanged += new System.EventHandler(this.txtSendAcct_TextChanged);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnHome.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Snow;
            this.btnHome.Location = new System.Drawing.Point(780, 558);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(332, 63);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // formTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblSendAcct);
            this.Controls.Add(this.txtSendAcct);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblDestAcct);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtDestAcct);
            this.MaximizeBox = false;
            this.Name = "formTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANSFER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblDestAcct;
        private Button btnTransfer;
        private TextBox txtDestAcct;
        private Label lblSendAcct;
        private TextBox txtSendAcct;
        private Button btnHome;
    }
}