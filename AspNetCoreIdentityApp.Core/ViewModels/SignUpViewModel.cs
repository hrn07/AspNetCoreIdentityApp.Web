using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Core.ViewModels
{
    public class SignUpViewModel
    {
        public SignUpViewModel()
        {

        }
        public SignUpViewModel(string userName, string email, string phone, string password)
        {
            UserName = userName;
            Email = email;
            Phone = phone;
            Password = password;
        }
        [Required(ErrorMessage = "Kullanıcı Adı alanı boş bırakılamaz.")]
        [Display(Name = "Kullanıcı Adı : ")]
        public string UserName { get; set; } = null!;
        [EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email : ")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz.")]
        [Display(Name = "Telefon : ")]
        public string Phone { get; set; } = null!;
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Şifre : ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalıdır")]
        public string Password { get; set; } = null!;
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Şifre aynı değildir.")]
        [Required(ErrorMessage = "Şifre Tekrar alanı boş bırakılamaz.")]
        [Display(Name = "Şifre Tekrar : ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalıdır")]
        public string PasswordConfirm { get; set; } = null!;
    }
}
