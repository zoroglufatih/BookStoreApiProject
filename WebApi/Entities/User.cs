using System;

namespace WebApi.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RefreshToken { get; set; }  
        // access token authenticate için kullanılan token süresi tamamlandığında erişim sonlanır
        // refresh token access token süresi dolduğunda kullanıcıyı logout etmemek için kullanılan token
        // access token süresi dolduğunda refresh token sayesinde bir istek gönderilir ve yeni bir access token oluşturulur
        public DateTime? RefreshTokenExpireDate { get; set; }
    }
}