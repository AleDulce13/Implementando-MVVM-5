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
        string _Texto;
        public List<Mmenuprincipal> listaUsuarios { get; set; }
        #region CONSTRUCTOR
        public VMmenuprincipal()
        {
            MostrarUsuarios();
        }
        #endregion

        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
        }
        public async Task Volver()
        {
        }


        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "OK");
        }

        #region COMANDOS 

        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));
        public void MostrarUsuarios()
        {
            listaUsuarios = new List<Mmenuprincipal> {

                new Mmenuprincipal
                {
                    Pagina = "Chimmy",
                    Icono = "https://ibb.co/fNLJWPg"
                },

                new Mmenuprincipal
                {
                    Pagina = "Cooky",
                    Icono = "https://ibb.co/W2f0CTq"
                },

                new Mmenuprincipal
                {
                    Pagina = "Van",
                    Icono = "https://ibb.co/QXGrdNY"
                }
            };
        }

        public async Task Navegar(Mmenuprincipal parametros)
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
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));

        #endregion
        public class Mmenuprincipal
        {
            public string Pagina { get; set; }
            public string Icono { get; set; }
        }
    }
    #endregion
}
