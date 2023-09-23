using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkaldApplication.Data.Enums
{
    enum AccountAccess : int
    {
        Anonim = 0,
        GOD = 1,
        Admin = 2,
        Seller = 3,
        Marketer = 4,
        Storekeeper = 5
    }
}
