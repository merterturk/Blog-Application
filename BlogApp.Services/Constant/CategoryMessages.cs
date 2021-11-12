using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services.Constant
{
    public static class CategoryMessages
    {
        public static string CategoryNotFoundPlural = "Hiç bir kategori bulunamadı.";
        public static string CategoryNotFoundSingular = "Böyle bir kategori bulunamadı.";

        public static string NotFoundById(int categoryId)
        {
            return $"{categoryId} kategori koduna ait bir kategori bulunamadı";
        }

        public static string Add(string categoryName)
        {
            return $"{categoryName} adlı kategori başarıyla eklenmiştir.";
        }

        public static string Update(string categoryName)
        {
            return $"{categoryName} adlı kategori başarıyla güncellenmiştir.";
        }

        public static string Delete(string categoryName)
        {
            return $"{categoryName} adlı kategori başarıyla silinmiştir.";
        }
        public static string HardDelete(string categoryName)
        {
            return $"{categoryName} adlı kategori başarıyla veritabanından silinmiştir.";
        }
        public static string UndoDelete(string categoryName)
        {
            return $"{categoryName} adlı kategori başarıyla arşivden geri getirilmiştir.";
        }


    }
}
