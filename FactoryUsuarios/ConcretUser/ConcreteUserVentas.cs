using FactoryUsuarios.Entities;
using FactoryUsuarios.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryUsuarios.ConcretUser
{
    public class ConcreteUserVentas : IUser
    {
        public usuarios SetUser(usuarios user)
        {
            user.perfil_usuario = "VENTAS";
            return user;
        }

        public string Operation()
        {
            return "[Resultado ConcreteUserVentas]";
        }
    }

    public class ConcreteUserAdmin : IUser
    {
        public usuarios SetUser(usuarios user)
        {
            user.perfil_usuario = "ADMIN";
            return user;
        }

        public string Operation()
        {
            return "[Resultado ConcreteUserAdmin]";
        }
    }

    public class ConcreteUserDefault : IUser
    {
        public usuarios SetUser(usuarios user)
        {
            return null;
            // throw new NotImplementedException();
        }

        public string Operation()
        {
            return "[Resultado ConcreteUserDefault no usuario]";
        }
    }
}
