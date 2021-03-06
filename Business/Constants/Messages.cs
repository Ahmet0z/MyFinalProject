using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün var.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı";

        public static string AuthorizationDenied = "Yetkiniz bulunmamaktadır";

        public static string UserRegistered = "Kayıt başarılı" ;
        public static string UserNotFound = "Kullanıcı bulunamadı" ;
        public static string PasswordError = "Şifre hatalı" ;
        public static string SuccessfulLogin = "Giriş başarılı" ;
        public static string UserAlreadyExists = "Kullanıcı mevcut" ;
        public static string AccessTokenCreated = "Token oluşturuldu" ;
    }
}
