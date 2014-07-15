namespace Cartero
{
    partial class Main
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
            this.cbHTML = new System.Windows.Forms.CheckBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSSL = new System.Windows.Forms.CheckBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBcc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubj = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbHTML
            // 
            this.cbHTML.AutoSize = true;
            this.cbHTML.Checked = true;
            this.cbHTML.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHTML.Location = new System.Drawing.Point(48, 89);
            this.cbHTML.Name = "cbHTML";
            this.cbHTML.Size = new System.Drawing.Size(56, 17);
            this.cbHTML.TabIndex = 0;
            this.cbHTML.Text = "HTML";
            this.cbHTML.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Location = new System.Drawing.Point(51, 6);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(513, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "smtp.gmail.com";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(486, 434);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 49);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPort.Location = new System.Drawing.Point(51, 32);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(513, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "587";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Location = new System.Drawing.Point(51, 110);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(513, 20);
            this.txtPass.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Location = new System.Drawing.Point(51, 84);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(513, 20);
            this.txtUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "user";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "pass";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbSSL
            // 
            this.cbSSL.AutoSize = true;
            this.cbSSL.Checked = true;
            this.cbSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSSL.Location = new System.Drawing.Point(51, 61);
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.Size = new System.Drawing.Size(46, 17);
            this.cbSSL.TabIndex = 7;
            this.cbSSL.Text = "SSL";
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(48, 138);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(513, 290);
            this.txtMessage.TabIndex = 9;
            // 
            // txtFrom
            // 
            this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrom.Location = new System.Drawing.Point(51, 136);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(513, 20);
            this.txtFrom.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "from";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Location = new System.Drawing.Point(48, 6);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(513, 20);
            this.txtTo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "to";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCC
            // 
            this.txtCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCC.Location = new System.Drawing.Point(48, 32);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(513, 20);
            this.txtCC.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "cc";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBcc
            // 
            this.txtBcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBcc.Location = new System.Drawing.Point(48, 58);
            this.txtBcc.Name = "txtBcc";
            this.txtBcc.Size = new System.Drawing.Size(513, 20);
            this.txtBcc.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "bcc";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "subject";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSubj
            // 
            this.txtSubj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubj.Location = new System.Drawing.Point(48, 112);
            this.txtSubj.Name = "txtSubj";
            this.txtSubj.Size = new System.Drawing.Size(513, 20);
            this.txtSubj.TabIndex = 8;
            this.txtSubj.Text = "test";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 517);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbSSL);
            this.tabPage1.Controls.Add(this.txtServer);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtPort);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtUser);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPass);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtFrom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTo);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cbHTML);
            this.tabPage2.Controls.Add(this.txtSubj);
            this.tabPage2.Controls.Add(this.btnSend);
            this.tabPage2.Controls.Add(this.txtMessage);
            this.tabPage2.Controls.Add(this.txtCC);
            this.tabPage2.Controls.Add(this.txtBcc);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Emailing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 517);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Cartero";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHTML;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbSSL;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBcc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubj;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

