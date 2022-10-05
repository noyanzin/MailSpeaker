using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailSpeaker
{
    public class ReadMailFile
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
                    string[] l = new string[file_new_mail.Length];
                    bool canRead = false;
                    do
                    {
                        try
                        {
                            l = File.ReadAllLines(file_new_mail, Encoding.GetEncoding(1251));
                            canRead = true;
                        }
                        catch
                        {
                            Thread.Sleep(1000);
                        }
                    }while(!canRead);
                    
                    File.Delete(file_new_mail);
                    if (sound_on)
                    {
                        sound_on = false;
                        
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
        
       
    }
}
