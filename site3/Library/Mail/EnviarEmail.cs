using site3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace site3.Library.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(Contato contato)
        {
            string conteudo = string.Format("Nome: {0}<br /> E-mail: {1}<br /> Assunto: {2}<br /> Menssagem {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

            //Configurar Servidor SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);
            //Mensagem de Email
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("hzpck17@gmail.com");
            mensagem.To.Add("hzpck17@gmail.com");
            mensagem.Subject = "Formulario de contato";

            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulario de contato</h1> " + conteudo;

            smtp.Send(mensagem);
        }
    }
}
