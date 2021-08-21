namespace MailSender
{
    partial class MainForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHeadline = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.rtbMailBody = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvAttachments = new System.Windows.Forms.ListView();
            this.chAttName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddAtt = new System.Windows.Forms.Button();
            this.btnRemoveAtt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(503, 310);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(126, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message:";
            // 
            // tbHeadline
            // 
            this.tbHeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHeadline.Location = new System.Drawing.Point(142, 58);
            this.tbHeadline.Name = "tbHeadline";
            this.tbHeadline.Size = new System.Drawing.Size(487, 20);
            this.tbHeadline.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Topic:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "To:";
            // 
            // tbTo
            // 
            this.tbTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTo.Location = new System.Drawing.Point(142, 6);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(487, 20);
            this.tbTo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CC:";
            // 
            // tbCC
            // 
            this.tbCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCC.Location = new System.Drawing.Point(142, 32);
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(487, 20);
            this.tbCC.TabIndex = 9;
            // 
            // rtbMailBody
            // 
            this.rtbMailBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMailBody.Location = new System.Drawing.Point(15, 208);
            this.rtbMailBody.Name = "rtbMailBody";
            this.rtbMailBody.Size = new System.Drawing.Size(614, 96);
            this.rtbMailBody.TabIndex = 10;
            this.rtbMailBody.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Attachments:";
            // 
            // lvAttachments
            // 
            this.lvAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAttachments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAttName});
            this.lvAttachments.HideSelection = false;
            this.lvAttachments.Location = new System.Drawing.Point(142, 84);
            this.lvAttachments.Name = "lvAttachments";
            this.lvAttachments.Size = new System.Drawing.Size(390, 97);
            this.lvAttachments.TabIndex = 12;
            this.lvAttachments.UseCompatibleStateImageBehavior = false;
            this.lvAttachments.View = System.Windows.Forms.View.Details;
            // 
            // chAttName
            // 
            this.chAttName.Text = "Name";
            this.chAttName.Width = 120;
            // 
            // btnAddAtt
            // 
            this.btnAddAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAtt.Location = new System.Drawing.Point(538, 84);
            this.btnAddAtt.Name = "btnAddAtt";
            this.btnAddAtt.Size = new System.Drawing.Size(93, 23);
            this.btnAddAtt.TabIndex = 13;
            this.btnAddAtt.Text = "Add...";
            this.btnAddAtt.UseVisualStyleBackColor = true;
            this.btnAddAtt.Click += new System.EventHandler(this.btnAddAtt_Click);
            // 
            // btnRemoveAtt
            // 
            this.btnRemoveAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAtt.Location = new System.Drawing.Point(538, 113);
            this.btnRemoveAtt.Name = "btnRemoveAtt";
            this.btnRemoveAtt.Size = new System.Drawing.Size(93, 23);
            this.btnRemoveAtt.TabIndex = 14;
            this.btnRemoveAtt.Text = "Remove";
            this.btnRemoveAtt.UseVisualStyleBackColor = true;
            this.btnRemoveAtt.Click += new System.EventHandler(this.btnRemoveAtt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(641, 345);
            this.Controls.Add(this.btnRemoveAtt);
            this.Controls.Add(this.btnAddAtt);
            this.Controls.Add(this.lvAttachments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbMailBody);
            this.Controls.Add(this.tbCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHeadline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHeadline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.RichTextBox rtbMailBody;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvAttachments;
        private System.Windows.Forms.ColumnHeader chAttName;
        private System.Windows.Forms.Button btnAddAtt;
        private System.Windows.Forms.Button btnRemoveAtt;
    }
}

