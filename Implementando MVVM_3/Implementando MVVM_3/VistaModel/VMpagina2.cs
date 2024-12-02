using Implementando_MVVM_3.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Implementando_MVVM_3.VistaModel
{
    public class VMpagina2 : BaseViewModel
    {
        private string _Texto;
        public List<Musuarios> listaUsuarios { get; set; }
        #region CONSTRUCTOR
        public VMpagina2()
        {
            MostrarUsuarios();
        }
        #endregion

        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
        }

        #region COMANDOS 

        public void MostrarUsuarios()
        {
            listaUsuarios = new List<Musuarios> {

                new Musuarios
                {
                    Nombre = "Chimmy",
                    Imagen = "https://ibb.co/pzk0zVM"
                },

                new Musuarios
                {
                    Nombre = "Cooky",
                    Imagen = "https://ibb.co/Xb28rn7"
                },

                new Musuarios
                {
                    Nombre = "Van",
                    Imagen = "https://ibb.co/GvZcXrq"
                }
            };
        }
    }
    #endregion
}
