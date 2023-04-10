using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class ResetPasswordViewModel
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Yeni şifre alanı boş bırakılamaz.")]
        [Display(Name = "Yeni Şifre : ")]
        public string Password { get; set; } = null!;
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Şifre aynı değildir.")]
        [Required(ErrorMessage = "Yeni şifre tekrar alanı boş bırakılamaz.")]
        [Display(Name = "Yeni Şifre Tekrar : ")]
        public string PasswordConfirm { get; set; } = null!;
    }
}
