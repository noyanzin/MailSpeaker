namespace MailSpeaker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnStartBrowser = new System.Windows.Forms.Button();
            this.btnSynthesizeClick = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.textBoxSpeak = new System.Windows.Forms.TextBox();
            this.btnReadTextFromFiles = new System.Windows.Forms.Button();
            this.btnSelectLanguage = new System.Windows.Forms.Button();
            this.btnVoice = new System.Windows.Forms.Button();
            this.btnAgree = new System.Windows.Forms.Button();
            this.btnDefaultText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "*.txt";
            this.fileSystemWatcher1.Path = "C:\\Program Files (x86)\\The Bat!\\NewMail";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            // 
            // btnStartBrowser
            // 
            this.btnStartBrowser.Location = new System.Drawing.Point(0, 0);
            this.btnStartBrowser.Name = "btnStartBrowser";
            this.btnStartBrowser.Size = new System.Drawing.Size(111, 23);
            this.btnStartBrowser.TabIndex = 0;
            this.btnStartBrowser.Text = "Start browser";
            this.btnStartBrowser.UseVisualStyleBackColor = true;
            this.btnStartBrowser.Click += new System.EventHandler(this.btnStartBrowser_Click);
            // 
            // btnSynthesizeClick
            // 
            this.btnSynthesizeClick.Location = new System.Drawing.Point(318, 0);
            this.btnSynthesizeClick.Name = "btnSynthesizeClick";
            this.btnSynthesizeClick.Size = new System.Drawing.Size(75, 23);
            this.btnSynthesizeClick.TabIndex = 1;
            this.btnSynthesizeClick.Text = "Synthesize";
            this.btnSynthesizeClick.UseVisualStyleBackColor = true;
            this.btnSynthesizeClick.Click += new System.EventHandler(this.btnSynthesizeSubmit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(399, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // textBoxSpeak
            // 
            this.textBoxSpeak.Location = new System.Drawing.Point(0, 29);
            this.textBoxSpeak.Name = "textBoxSpeak";
            this.textBoxSpeak.Size = new System.Drawing.Size(717, 20);
            this.textBoxSpeak.TabIndex = 4;
            // 
            // btnReadTextFromFiles
            // 
            this.btnReadTextFromFiles.Location = new System.Drawing.Point(117, 0);
            this.btnReadTextFromFiles.Name = "btnReadTextFromFiles";
            this.btnReadTextFromFiles.Size = new System.Drawing.Size(75, 23);
            this.btnReadTextFromFiles.TabIndex = 5;
            this.btnReadTextFromFiles.Text = "FillTextArea";
            this.btnReadTextFromFiles.UseVisualStyleBackColor = true;
            this.btnReadTextFromFiles.Click += new System.EventHandler(this.btnReadTextFromFiles_Click);
            // 
            // btnSelectLanguage
            // 
            this.btnSelectLanguage.Location = new System.Drawing.Point(480, 0);
            this.btnSelectLanguage.Name = "btnSelectLanguage";
            this.btnSelectLanguage.Size = new System.Drawing.Size(75, 23);
            this.btnSelectLanguage.TabIndex = 6;
            this.btnSelectLanguage.Text = "Language";
            this.btnSelectLanguage.UseVisualStyleBackColor = true;
            this.btnSelectLanguage.Click += new System.EventHandler(this.btnSelectLanguage_Click);
            // 
            // btnVoice
            // 
            this.btnVoice.Location = new System.Drawing.Point(561, 0);
            this.btnVoice.Name = "btnVoice";
            this.btnVoice.Size = new System.Drawing.Size(75, 23);
            this.btnVoice.TabIndex = 7;
            this.btnVoice.Text = "Voice";
            this.btnVoice.UseVisualStyleBackColor = true;
            this.btnVoice.Click += new System.EventHandler(this.btnVoice_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.Location = new System.Drawing.Point(642, 0);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(75, 23);
            this.btnAgree.TabIndex = 8;
            this.btnAgree.Text = "Agree";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // btnDefaultText
            // 
            this.btnDefaultText.Location = new System.Drawing.Point(198, 0);
            this.btnDefaultText.Name = "btnDefaultText";
            this.btnDefaultText.Size = new System.Drawing.Size(114, 23);
            this.btnDefaultText.TabIndex = 9;
            this.btnDefaultText.Text = "Use default text";
            this.btnDefaultText.UseVisualStyleBackColor = true;
            this.btnDefaultText.Click += new System.EventHandler(this.btnDefaultText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 57);
            this.Controls.Add(this.btnDefaultText);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.btnVoice);
            this.Controls.Add(this.btnSelectLanguage);
            this.Controls.Add(this.btnReadTextFromFiles);
            this.Controls.Add(this.textBoxSpeak);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSynthesizeClick);
            this.Controls.Add(this.btnStartBrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnStartBrowser;
        private System.Windows.Forms.Button btnSynthesizeClick;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox textBoxSpeak;
        private System.Windows.Forms.Button btnReadTextFromFiles;
        private System.Windows.Forms.Button btnSelectLanguage;
        private System.Windows.Forms.Button btnVoice;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.Button btnDefaultText;
    }
}

