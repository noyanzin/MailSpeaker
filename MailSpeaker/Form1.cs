using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSpeaker
{
    
    public partial class Form1 : Form
    {
        public ReadMailFile readMail = new ReadMailFile();
        public SpeakMail speakMail = new SpeakMail();
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            fileSystemWatcher1.EnableRaisingEvents = false;
            speakMail.StartBrowser();
            string textToSpeak = readMail.ReadFiles();
            do
            {
                speakMail.DefaultText();
                speakMail.Agree();
                speakMail.SelectLanguage();
                speakMail.SelectVoice();
                speakMail.FillTextArea(textToSpeak);
                speakMail.Synthesize();
                speakMail.Play();
                textToSpeak = readMail.ReadFiles();
                textBoxSpeak.Text = textToSpeak;

            } while (textToSpeak != "");
            speakMail.StopBrowser();
            fileSystemWatcher1.EnableRaisingEvents = true;
        }

        private void btnStartBrowser_Click(object sender, EventArgs e)
        {
            speakMail.StartBrowser();
        }

        private void btnSynthesizeSubmit_Click(object sender, EventArgs e)
        {
            speakMail.Synthesize();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            speakMail.Play();
        }

       

        private void btnReadTextFromFiles_Click(object sender, EventArgs e)
        {
            speakMail.FillTextArea(textBoxSpeak.Text);
        }
        private void DingDong()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Program Files (x86)\The Bat!\Пришло новое письмо.wav");
            simpleSound.PlaySync();
        }

        private void btnSelectLanguage_Click(object sender, EventArgs e)
        {
            btnSelectLanguage.Text = speakMail.SelectLanguage();
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {
            btnVoice.Text = speakMail.SelectVoice();
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            speakMail.Agree();
        }

        private void btnDefaultText_Click(object sender, EventArgs e)
        {
            speakMail.DefaultText();
        }
    }
}
