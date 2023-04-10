using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class PasswordChangeViewModel
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Eski şifre alanı boş bırakılamaz.")]
        [Display(Name = "Yeni Şifre : ")]
        public string PasswordOld { get; set; } = null!;
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Yeni Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Yeni Şifre : ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalıdır")]
        public string PasswordNew { get; set; } = null!;
        [DataType(DataType.Password)]
        [Compare(nameof(PasswordNew), ErrorMessage = "Şifre aynı değildir.")]
        [Required(ErrorMessage = "Yeni şifre tekrar alanı boş bırakılamaz.")]
        [Display(Name = "Yeni şifre Tekrar : ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalıdır")]

        public string PasswordNewConfirm { get; set; } = null!;
    }
}
