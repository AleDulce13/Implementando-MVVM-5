using Implementando_MVVM_3.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Implementando_MVVM_3.VistaModel
{
    public class VMpagina2 : BaseViewModel
    {
        #region VARIABLES

        private string _Texto;

        public List<Musuarios> listaUsuarios { get; set; }

        #endregion

        #region CONSTRUCTOR

        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
        }
        #endregion

        #region COMANDOS 

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        public void MostrarUsuarios()
        {
            listaUsuarios = new List<Musuarios> {

                new Musuarios
                {
                    Nombre = "Chimmy",
                    Imagen = "https://ibb.co/fNLJWPg"
                },

                new Musuarios
                {
                    Nombre = "Cooky",
                    Imagen = "https://ibb.co/W2f0CTq"
                },

                new Musuarios
                {
                    Nombre = "Van",
                    Imagen = "https://ibb.co/QXGrdNY"
                }
            };
        }

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public ICommand Volvercommand => new Command(async () => await Volver());

        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "OK");
        }

        public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));
    }

}
