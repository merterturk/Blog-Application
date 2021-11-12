using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services.Constant
{
    public static class UserMessages
    {
        //public static string NotFoundPlural = "Makaleler bulunamadı.";
        //public static string NotFoundSingular = "Böyle bir makale bulunamadı.";

        public static string NotFoundById(int userId)
        {
            return $"{userId} kullanıcı koduna ait bir kullanıcı bulunamadı";
        }
        //public static string Add(string articleTitle)
        //{
        //    return $"{articleTitle} başlıklı makale başarıyla eklenmiştir.";
        //}

        //public static string Update(string articleTitle)
        //{
        //    return $"{articleTitle} başlıklı makale başarıyla güncellenmiştir.";
        //}

        //public static string Delete(string articleTitle)
        //{
        //    return $"{articleTitle} başlıklı makale başarıyla silinmiştir.";
        //}
        //public static string HardDelete(string articleTitle)
        //{
        //    return $"{articleTitle} başlıklı makale başarıyla veritabanından silinmiştir.";
        //}
        //public static string UndoDelete(string articleTitle)
        //{
        //    return $"{articleTitle} başlıklı makale başarıyla arşivden geri getirilmiştir.";
        //}
        //public static string IncreaseViewCount(string articleTitle)
        //{
        //    return $"{articleTitle} başlıklı makale'nin okunma sayısı başarıyla arttırılmıştır.";
        //}

    }
}
