using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementando_MVVM_3.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmdals-default-rtdb.firebaseio.com/");
    }
}
