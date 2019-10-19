using IceCreamAPI.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IceCreamAPI.Models.mDAO
{
    sealed class DbConnection
    {
        public static IceCreamWebProjectEntities iceCreamDb = new IceCreamWebProjectEntities();
    }
}