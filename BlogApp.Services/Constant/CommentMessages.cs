using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services.Constant
{
    public static class CommentMessages
    {
        public static string CommentNotFoundPlural = "Hiç bir yorum bulunamadı.";
        public static string CommentNotFoundSingular = "Böyle bir yorum bulunamadı.";

        public static string Add(string createdByName)
        {
            return $"Sayın {createdByName}, yorumunuz başarıyla eklenmiştir.";
        }
        public static string Approve(int commentId)
        {
            return $"Sayın {commentId} no'lu yorum başarıyla onaylanmıştır.";
        }

        public static string Update(string createdByName)
        {
            return $"{createdByName} tarafından eklenen yorum başarıyla güncellenmiştir.";
        }
        public static string Delete(string createdByName)
        {
            return $"{createdByName} tarafından eklenen yorum başarıyla silinmiştir.";
        }
        public static string HardDelete(string createdByName)
        {
            return $"{createdByName} tarafından eklenen yorum başarıyla veritabanından silinmiştir.";
        }
        public static string UndoDelete(string createdByName)
        {
            return $"{createdByName} tarafından eklenen yorum başarıyla arşivden geri getirilmiştir.";
        }
    }
}
