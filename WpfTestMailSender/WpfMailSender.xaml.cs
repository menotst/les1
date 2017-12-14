using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Mail;

namespace WpfTestMailSender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WpfMailSender : Window
    {
        public WpfMailSender()
        {
            InitializeComponent();            
        }

        private void btnSendEmail_Click(object sender, RoutedEventArgs e)
        {
            List<string> listStrMails = new List<string> { "rutara317@gmail.com", "mikhail.tarasov@miele.com" };
            string strPassword = passwordBox.Password;
            foreach(string mail in listStrMails)
            {
                using (MailMessage mm = new MailMessage("mikhail.tarasov@miele.com", mail))
                {
                    mm.Subject = "тестовое письмо";
                    mm.Body = "Mail Body";
                    mm.IsBodyHtml = false;
                    using (SmtpClient sc = new SmtpClient("mielecas01.miele.net",25))
                    {
                        sc.EnableSsl = false;
                        sc.Credentials = new NetworkCredential("mikhail.tarasov@miele.com",strPassword);
                        try
                        {
                            sc.Send(mm);
                            MessageBox.Show("Письмо на адрес " + mail + " отправлено");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            //MessageBox.Show("работа завершена");
            SendEndWindow sew = new SendEndWindow();
            sew.Show();
        }
    }
}
