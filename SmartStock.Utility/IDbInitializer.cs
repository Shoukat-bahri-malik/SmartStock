using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Utility
{
    public interface IDbInitializer
    {
        void CreateRoles();
        void CreateSuperAdmin();
    }
}
