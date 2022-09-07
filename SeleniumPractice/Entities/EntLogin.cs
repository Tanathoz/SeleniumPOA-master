using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice.Entities
{
    public class EntLogin
    {
        #region Atributos
        private string usuario;
        private string password;
        #endregion

        public string Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                if (value == null)
                    this.usuario = string.Empty;
                else
                    this.usuario = value;
            }

        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value == null)
                    this.password = string.Empty;
                else
                    this.password = value;
            }
        }

        public static EntLogin Init(string usuario, string pass)
        {
            EntLogin objLogin = new EntLogin();
            objLogin.Usuario = usuario;
            objLogin.Password = pass;
            return objLogin;
        }
    }
}
