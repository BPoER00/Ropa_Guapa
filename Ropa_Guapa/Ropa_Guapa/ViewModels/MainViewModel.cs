
namespace Ropa_Guapa.ViewModels
{
    public class MainViewModel
    {

        #region Propiedades

        public PrincipalViewModel Principal { get; set; }


        #endregion

        #region Constructores

        public MainViewModel()
        {
            Principal = new PrincipalViewModel();
        }


        #endregion
    }
}
