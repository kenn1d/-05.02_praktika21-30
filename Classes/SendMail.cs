using System.Net;
using System.Net.Mail;

namespace praktika21_30_.Classes
{
    public class SendMail
    {
        public static void SendMessage(string Message, string To)
        {
            // Содаём smtp клиент, в качестве хоста указываем яндекс
            var smtpClient = new SmtpClient("smtp.yandex.ru")
            {
                Port = 587,
                Credentials = new NetworkCredential("yandex@yandex.ru", "password"),
                EnableSsl = true
            };
            // Вызываем метод send, который отправляет письмо на указанный адрес
            smtpClient.Send("landaxer@yandex.ru", To, "Проект Praktika21(30)", Message);
        }
    }
}
