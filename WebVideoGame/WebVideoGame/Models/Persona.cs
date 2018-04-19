using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebVideoGame.Models
{
    public class Persona
    {
        #region "Atributos"
            private string identificacion;
            private string name;
            private string address;
            private string lastName;
            private string phone;
        #endregion

        #region "Constructor Sin Parametros"
            public Persona() { }
        #endregion

        #region "Constructor Con Parametros"
            public Persona(string id, string name, string lastName,
                string phone, string address)
            {
                this.identificacion = id;
                this.name = name;
                this.lastName = lastName;
                this.phone = phone;
                this.address = address;
            }
        #endregion

        #region "Metodos Publicos"
            public string getIdentification()
            {
                return identificacion;
            }

            public void setIdentification(string id)
            {
                this.identificacion = id;
            }

            public string getName()
            {
                return name;
            }

            public void setName(string name)
            {
                this.name = name;
            }

            public string getLastName()
            {
                return lastName;
            }

            public void setLastName(string lastName)
            {
                this.lastName = lastName;
            }


            public string getPhone()
            {
                return phone;
            }

            public void setPhone(string phone)
            {
                this.phone = phone;
            }


            public string getAddress()
            {
                return address;
            }

            public void setAddress(string address)
            {
                this.address = address;
            }
        #endregion

    }
}