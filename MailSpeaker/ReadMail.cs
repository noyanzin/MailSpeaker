using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MailSpeaker
{
    public class ReadMail
    {
        public string mail_path = @"C:\Program Files (x86)\The Bat!\NewMail";
        public string ReadFiles()
        {
            string msg = "";
            bool sound_on = true;
            string file_new_mail;
            while (Directory.GetFiles(mail_path).Count() > 0)
            {
                
                file_new_mail = Directory.GetFiles(mail_path)[0];
                if (File.Exists(file_new_mail))
                {
                    string[] l = File.ReadAllLines(file_new_mail, Encoding.GetEncoding(1251));
                    File.Delete(file_new_mail);
                    if (sound_on)
                    {
                        sound_on = false;
                        SoundPlayer simpleSound = new SoundPlayer(@"C:\Program Files (x86)\The Bat!\Пришло новое письмо.wav");
                        simpleSound.PlaySync();
                    }


                    string[] addresses = File.ReadAllLines(@"C:\Program Files (x86)\The Bat!\addresses.csv", Encoding.GetEncoding(1251));
                    foreach (string s in l)
                    {
                        if (s.Length > 2 && s.Substring(0, 3) == "От:")
                        {
                            try
                            {
                                int start = s.IndexOf('<');
                                string email = s.Substring(start + 1, s.IndexOf('>') - 1 - start);
                                bool isPresent = false;
                                foreach (string fioadr in addresses)
                                {

                                    if (fioadr.Contains(email))
                                    {
                                        string[] fio = fioadr.Split(';');
                                        msg = msg + "Отправитель: " + fio[0] + "," + fio[1] + " " + fio[2] + ".";
                                        isPresent = true;
                                    }

                                }
                                if (!isPresent)
                                {
                                    msg = msg + "Отправителя нет в адресной книге.";
                                }
                            }
                            catch
                            {
                                //Не получилось прочитать email
                            }

                        }
                        if (s.Length > 5 && s.Substring(0, 5) == "Тема:")
                        {
                            msg = msg + " " + s + ". ";
                        }
                    }



                }

            }
            return msg;
        }
        private bool IsProcessOpen(string name)
        {
            int count = 0;
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                //now we're going to see if any of the running processes
                //match the currently running processes. Be sure to not
                //add the .exe to the name you provide, i.e: NOTEPAD,
                //not NOTEPAD.EXE or false is always returned even if
                //notepad is running.
                //Remember, if you have the process running more than once, 
                //say IE open 4 times the loop thr way it is now will close all 4,
                //if you want it to just close the first one it finds
                //then add a return; after the Kill
                if (clsProcess.ProcessName.Contains(name))
                {
                    count += 1;
                    //if the process is found to be running then we
                    //return a true
                }

            }
            //otherwise we return a false
            if (count <= 1)
            {
                return false;

            }
            else
            {
                return true;
            }
        }
    }
}
