using Implementando_MVVM_3.Vistas.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Implementando_MVVM_3.Datos;
using Implementando_MVVM_3.Model;
using System.Collections.ObjectModel;

namespace Implementando_MVVM_3.VistaModel.VMpokemon
{
    public class VMlistapokemon : BaseViewModel
    {
        #region VARIABLES


        public string _Texto;
        ObservableCollection<Mpokemon> _Listapokemon;

        #endregion

        #region CONTSRUCTOR

        public  VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPokemon();
        }

        #endregion

        #region OBJETOS
        public ObservableCollection<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set
            {
                SetValue(ref _Listapokemon, value);
                OnPropertyChanged();
            }

        }
        #endregion

        public async Task MostrarPokemon()
        {
            var funcion = new Dpokemon();
            Listapokemon = await funcion.Mostrarpokemones();
        }

        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new RegistrarPokemon());
        }
        public void ProcesoSimple()
        {

        }
        #region COMANDOS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion

        #region CONSTRUCTOR

        #endregion
    }
}
