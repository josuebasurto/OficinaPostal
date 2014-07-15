using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartero
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Está seguro de enviar el correo?", "¿Está seguro de enviar el correo?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK) {
                try
                {
                    var smtp = new System.Net.Mail.SmtpClient
                    {
                        Host = txtServer.Text,
                        Port = toInt(txtPort.Text, 587),
                        EnableSsl = cbSSL.Checked,
                        DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new System.Net.NetworkCredential(txtUser.Text, txtPass.Text)
                    };
                    using (var message = new System.Net.Mail.MailMessage(txtFrom.Text, txtTo.Text)
                    {
                        Subject = txtSubj.Text,
                        Body = txtMessage.Text,
                        IsBodyHtml = cbHTML.Checked
                    })
                    {
                        smtp.Send(message);
                        MessageBox.Show("Mensaje Enviado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int toInt(string numero, int defaultValue)
        {
            try
            {
                return Convert.ToInt32(numero);
            }
            catch { }
            return defaultValue;
        }

        private void Bind()
        {
            Entities.ConfigurationsEntity entidad = Entities.ConfigurationsEntity.Create(Tools.Constants.Key);
            if (entidad.Load())
            {
                txtServer.Text = entidad.Server;
                txtPort.Text = entidad.Port.ToString();
                txtUser.Text = entidad.User;
                txtPass.Text = entidad.Password;
                cbSSL.Checked = entidad.SSL;
                txtFrom.Text = entidad.From;
            }
        }

        private void Unbind()
        {
            Entities.ConfigurationsEntity entidad = new Entities.ConfigurationsEntity(Tools.Constants.Key);
            entidad.Server = txtServer.Text;

            var puerto = 0;
            int.TryParse(txtPort.Text, out puerto);
            entidad.Port = puerto;

            entidad.User = txtUser.Text;
            entidad.Password = txtPass.Text;
            entidad.SSL = cbSSL.Checked;
            entidad.From = txtFrom.Text;

            entidad.Save();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Unbind();
        }
    }
}
