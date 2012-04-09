namespace Sender
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.bnBrowse = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.pbFileSend = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP: ";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(43, 13);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(170, 20);
            this.tbIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File: ";
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(43, 56);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(170, 20);
            this.tbFile.TabIndex = 3;
            // 
            // bnBrowse
            // 
            this.bnBrowse.Location = new System.Drawing.Point(219, 53);
            this.bnBrowse.Name = "bnBrowse";
            this.bnBrowse.Size = new System.Drawing.Size(75, 23);
            this.bnBrowse.TabIndex = 4;
            this.bnBrowse.Text = "browse";
            this.bnBrowse.UseVisualStyleBackColor = true;
            this.bnBrowse.Click += new System.EventHandler(this.bnBrowse_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(130, 177);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(185, 45);
            this.send.TabIndex = 5;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // pbFileSend
            // 
            this.pbFileSend.Location = new System.Drawing.Point(130, 127);
            this.pbFileSend.Name = "pbFileSend";
            this.pbFileSend.Size = new System.Drawing.Size(185, 23);
            this.pbFileSend.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.pbFileSend);
            this.Controls.Add(this.send);
            this.Controls.Add(this.bnBrowse);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button bnBrowse;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.ProgressBar pbFileSend;
    }
}

