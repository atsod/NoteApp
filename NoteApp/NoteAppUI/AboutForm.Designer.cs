namespace NoteAppUI
{
    partial class AboutForm
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
            AppTitleLabel = new Label();
            VersionLabel = new Label();
            AuthorLabel = new Label();
            EmailFeedbackLabel = new Label();
            GitHubLabel = new Label();
            BottomAuthorLabel = new Label();
            EmailLinkLabel = new LinkLabel();
            GithubLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // AppTitleLabel
            // 
            AppTitleLabel.AutoSize = true;
            AppTitleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            AppTitleLabel.Location = new Point(36, 34);
            AppTitleLabel.Name = "AppTitleLabel";
            AppTitleLabel.Size = new Size(124, 35);
            AppTitleLabel.TabIndex = 0;
            AppTitleLabel.Text = "NoteApp";
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(37, 81);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(53, 20);
            VersionLabel.TabIndex = 1;
            VersionLabel.Text = "v. 1.0.0";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(37, 141);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(173, 20);
            AuthorLabel.TabIndex = 2;
            AuthorLabel.Text = "Author: Andrey Abramov";
            // 
            // EmailFeedbackLabel
            // 
            EmailFeedbackLabel.AutoSize = true;
            EmailFeedbackLabel.Location = new Point(36, 192);
            EmailFeedbackLabel.Name = "EmailFeedbackLabel";
            EmailFeedbackLabel.Size = new Size(143, 20);
            EmailFeedbackLabel.TabIndex = 3;
            EmailFeedbackLabel.Text = "e-mail for feedback:";
            // 
            // GitHubLabel
            // 
            GitHubLabel.AutoSize = true;
            GitHubLabel.Location = new Point(37, 212);
            GitHubLabel.Name = "GitHubLabel";
            GitHubLabel.Size = new Size(59, 20);
            GitHubLabel.TabIndex = 4;
            GitHubLabel.Text = "GitHub:";
            // 
            // BottomAuthorLabel
            // 
            BottomAuthorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BottomAuthorLabel.AutoSize = true;
            BottomAuthorLabel.Location = new Point(37, 324);
            BottomAuthorLabel.Name = "BottomAuthorLabel";
            BottomAuthorLabel.Size = new Size(174, 20);
            BottomAuthorLabel.TabIndex = 5;
            BottomAuthorLabel.Text = "2024 Andrey Abramov ⓒ";
            // 
            // EmailLinkLabel
            // 
            EmailLinkLabel.AutoSize = true;
            EmailLinkLabel.Location = new Point(185, 192);
            EmailLinkLabel.Name = "EmailLinkLabel";
            EmailLinkLabel.Size = new Size(232, 20);
            EmailLinkLabel.TabIndex = 6;
            EmailLinkLabel.TabStop = true;
            EmailLinkLabel.Text = "andrey.abramov2001@gmail.com";
            EmailLinkLabel.LinkClicked += EmailLinkLabel_LinkClicked;
            // 
            // GithubLinkLabel
            // 
            GithubLinkLabel.AutoSize = true;
            GithubLinkLabel.Location = new Point(97, 212);
            GithubLinkLabel.Name = "GithubLinkLabel";
            GithubLinkLabel.Size = new Size(113, 20);
            GithubLinkLabel.TabIndex = 7;
            GithubLinkLabel.TabStop = true;
            GithubLinkLabel.Text = "atsod/NoteApp";
            GithubLinkLabel.LinkClicked += GithubLinkLabel_LinkClicked;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(GithubLinkLabel);
            Controls.Add(EmailLinkLabel);
            Controls.Add(BottomAuthorLabel);
            Controls.Add(GitHubLabel);
            Controls.Add(EmailFeedbackLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(VersionLabel);
            Controls.Add(AppTitleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AboutForm";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AppTitleLabel;
        private Label VersionLabel;
        private Label AuthorLabel;
        private Label EmailFeedbackLabel;
        private Label GitHubLabel;
        private Label BottomAuthorLabel;
        private LinkLabel EmailLinkLabel;
        private LinkLabel GithubLinkLabel;
    }
}