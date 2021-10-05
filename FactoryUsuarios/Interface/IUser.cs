using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryUsuarios.Entities;

namespace FactoryUsuarios.Interface
{
    public interface IUser
    {
        string Operation();
        usuarios SetUser(usuarios user);
    }
}
