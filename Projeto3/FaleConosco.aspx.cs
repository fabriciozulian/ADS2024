﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using AdsLib;



namespace Projeto3
{
    public partial class FaleConosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            if (Nome.Text.Trim() == "")
            {
                Alerta.Text = "Digite seu nome";
            }
            else if (Email.Text.Trim() == "")
            {
                Alerta.Text = "Digite seu email";
            }
            else if (Mensagem.Text.Trim() == "")
            {
                Alerta.Text = "Digite a mensagem";
            }
            else
            {
                try
                {
                    // ENVIA O EMAIL

                    // Cria uma instancia da classe MailMessage()
                    MailMessage mail = new MailMessage();
                    mail.To.Add("contato@seudominio.com.br");

                    MailAddress from = new MailAddress("contato@seudominio.com.br");

                    mail.From = from;
                    mail.Subject = "E-mail enviado pela pagina fale conosco";

                    mail.Body = "Nome:" + Nome.Text + "\n";
                    mail.Body += "Email:" + Email.Text + "\n";
                    mail.Body += "Telefone:" + Telefone.Text + "\n";
                    mail.Body += "Mensagem:" + Mensagem.Text + "\n";
                    mail.IsBodyHtml = false;

                    // Cria uma instancia da classe SMTPClient()
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "seudominio.com.br";
                    smtp.Credentials = new System.Net.NetworkCredential("contato@seudominio.com.br", "suasenha");
                    // envia o email
                    smtp.Send(mail);

                    Alerta.Text = "Seu E-mail foi enviado com sucesso.";
                    Alerta.ForeColor = System.Drawing.Color.Green;
                    Formulario.Visible = false;

                }
                catch (Exception ex)
                {
                    Alerta.Text = "Houve uma falha ao enviar o e-mail.<br>Tente novamente mais tarde.";

                    Formulario.Visible = false;
                    //CRIANDO UMA INSTANCIA DE TRATAMENTO EXCECAO
                    
                    TratamentoExcecoes tratamento = new TratamentoExcecoes();

                    //Grava a exceção
                    tratamento.GravarExcecao(ex);

                    //Criar uma página para exibir a lista das exceções

                }
            }
        }
    }
}