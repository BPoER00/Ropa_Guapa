using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Ropa_Guapa.ViewModels
{
    public class PrincipalViewModel
    {
        #region Propiedades

        public string Texto { get; set; }
        public string Image { get; set; }
        public string Items { get; set; }

        #endregion

        #region Atributos

        #endregion

        #region Contructores

        public PrincipalViewModel()
        {
            Texto = "Algo";
            Image = "Angelita";
            Items = "12";
        }
         
        #endregion

        #region Comandos

        #endregion
    }
}
