using Implementando_MVVM_3.Model;
using Implementando_MVVM_3.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Implementando_MVVM_3.VistaModel
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES

        private string _Texto;
        public List<MenuPrincipal> listapaginas { get; set; }

        #endregion

        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        #region COMANDOS 
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }


       // public async Task Alerta(Musuarios parametros)
        //{
           // await DisplayAlert("Titulo", parametros.Nombre, "OK");
        //}

       // public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));

        public void MostrarPaginas()
        {
            listapaginas = new List<MenuPrincipal> {

                new MenuPrincipal
                {
                    Pagina = "Entry, datepicker, picker, label, navegacion",
                    Icono = "https://ibb.co/fNLJWPg"
                },

                new MenuPrincipal
                {
                    Pagina = "CollectionView sin enlace a Base de datos",
                    Icono = "https://ibb.co/W2f0CTq"
                },

                new MenuPrincipal
                {
                    Pagina = "Crud pokemon",
                    Icono = "https://ibb.co/QXGrdNY"
                }
            };
        }

        public async Task Navegar(MenuPrincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, datepicker"))
            {
                await Navigation.PushAsync(new pagina1());
            }
            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Pagina2());
            }
            if (pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }

        }
        public ICommand Navegarcommand => new Command<MenuPrincipal>(async (p) => await Navegar(p));

        #endregion

    }
}
