using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartero.Tools
{
    public class Registry
    {
        private string p;

        public Registry(string KeyName)
        {
            this.KeyName = KeyName;
        }
        public string KeyName { get; set; }

        public string GetString(string ValueName)
        {
            return Microsoft.Win32.Registry.GetValue(KeyName, ValueName, string.Empty).ToString();
        }

        public int GetInt(string ValueName)
        {
            int valorEntero = 0;
            int.TryParse(GetString(ValueName), out valorEntero);
            return valorEntero;
        }

        public bool GetBool(string ValueName)
        {
            string valor = GetString(ValueName);
            bool valorBool = false;
            bool.TryParse(valor, out valorBool);
            return valorBool;
        }

        public void SetString(string ValueName, string Value)
        {
            Microsoft.Win32.Registry.SetValue(KeyName, ValueName, Value);
        }

        public void SetInt(string ValueName, int Value) {
            SetString(ValueName, Value.ToString());
        }

        public void SetBool(string ValueName, bool Value)
        {
            SetString(ValueName, Value.ToString());
        }

    }
}
