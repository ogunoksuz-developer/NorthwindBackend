using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";

        public static string CategoryAdded = "Kategori başarıyla eklendi";
        public static string CategoryDeleted = "Kategori başarıyla silindi";
        public static string CategoryUpdated = "Kategori başarıyla güncellendi";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Parola hatalı";
        public static string SuccessForLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kulanıcı sistemde kayıtlı";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated ="Acces token başarıyla oluşturuldu";
    }
}
