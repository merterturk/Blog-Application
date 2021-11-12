using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services.Constant
{
    public static class GeneralMessages
    {
        public static string ValidationError()
        {
            return $"Bir veya daha fazla validasyon hatası ile karşılaşıldı.";
        }
    }
}
