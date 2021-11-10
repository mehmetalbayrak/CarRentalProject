using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba başarılı bir şekilde eklendi.";
        public static string CarAddWithFail = "Araba ekleme işlemi başarısız oldu.";
        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string CarListed = "Arabalar listelendi.";
        public static string MaintenanceTime = "Sistem bakım zamanı.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserAlreadyExists = "Kullanıı zaten mevcut.";
        public static string AccessTokenCreated = "Access token oluşturuldu.";
        public static string UserRegistered = "Kullanıcı kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
    }
}
