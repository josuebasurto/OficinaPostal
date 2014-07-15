using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartero.Entities
{
    public class ConfigurationsEntity
    {
        private Tools.Registry registro = null;
        private string p;

        public ConfigurationsEntity(string RegistryKey)
        {
            this.registro = new Tools.Registry(RegistryKey);
        }
        public static ConfigurationsEntity Create(string RegistryKey)
        {
            return new ConfigurationsEntity(RegistryKey);
        }

        public string Server { get; set; }
        public int Port { get; set; }
        public bool SSL { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string From { get; set; }

        public bool Validate() {
            return true;
        }

        public void Save()
        {
            try
            {

                registro.SetString("Server", Server);
                registro.SetInt("Port", Port);
                registro.SetBool("SSL", SSL);
                registro.SetString("User", User);
                registro.SetString("Password", Password);
                registro.SetString("From", From);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la información.", ex);
            }
        }

        public bool Load()
        {
            bool resultado = false;
            try
            {
                Server = registro.GetString("Server");
                Port = registro.GetInt("Port");
                SSL = registro.GetBool("SSL");
                User = registro.GetString("User");
                Password = registro.GetString("Password");
                From = registro.GetString("From");
                resultado = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los valores", ex);
            }
            return resultado;
        }
    }
}
