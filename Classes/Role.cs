using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEDSS.Classes
{
    internal class Role
    {
        public static int CheckRole() {
            if(UserSessionStats.status == 0) 
            { return 0; } 
            else
            if (UserSessionStats.status == 1) 
            { return 1; }
            else { return 2; }
        }
    }
}
