using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryUsuarios.Interface;
using FactoryUsuarios.Entities;

namespace FactoryUsuarios.AbstractUser
{
    abstract class Creator
    {
        public abstract IUser FactoryMethod(string perfil, usuarios usuario);

        public string LlenarUsuario(string perfil, usuarios usuario)
        {
            var user_obj = FactoryMethod(perfil, usuario);
            var result = "El Creator: " + user_obj.Operation();

            // user.SetUser(user_aux);

            return result;
        }
    }
}

