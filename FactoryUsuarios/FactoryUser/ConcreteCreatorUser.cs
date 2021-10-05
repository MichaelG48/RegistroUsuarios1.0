using FactoryUsuarios.AbstractUser;
using FactoryUsuarios.ConcretUser;
using FactoryUsuarios.Entities;
using FactoryUsuarios.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryUsuarios.FactoryUser
{
    internal class ConcreteCreatorUser : Creator
    {
        public override IUser FactoryMethod(string perfil,usuarios usuario)
        {
            switch (perfil)
            {
                case "ventas":
                    return new ConcreteUserVentas();
                    break;

                case "admin":
                    return new ConcreteUserAdmin();
                    break;

                default:
                    return new ConcreteUserDefault();
            }
            
        }
    }
}
