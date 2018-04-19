using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebVideoGame.Models
{
    public class Tarea
    {
        #region "Atributos"
            [StringLength(50), Required]
            private string name;
            [StringLength(100),Required]
            private string description;
            private int estado;
        #endregion

        #region "Consutructor Sin parametros"
            public Tarea() { }
        #endregion

        #region "Constructor que recibe parametros"
            public Tarea(string name, string description)
            {
                this.name = name;
                this.description = description;
            }
        #endregion

        #region "Propiedades"

            public string getName()
            {
                return name;
            }

            public void setName(string name)
            {
                this.name = name;
            }

            public string getDescription()
            {
                return description;
            }

            public void setDescription(string description)
            {
                this.description = description;
            }
        #endregion

        #region "Metodos Publicos"
            public bool validarCampos()
            {
                if (!String.IsNullOrEmpty(name) 
                        || !String.IsNullOrEmpty(description))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        #endregion
    }
}