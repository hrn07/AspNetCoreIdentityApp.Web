﻿using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignInViewModel
    {
        public SignInViewModel()
        {

        }
        public SignInViewModel(string email, string password)
        {
            Email = email;
            Password = password;
        }
        [EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email : ")]
        public string Email { get; set; } = null!;
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Şifre : ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olmalıdır")]
        public string Password { get; set; } = null!;
        [Display(Name = "Beni Hatırla!")]
        public bool RememberMe { get; set; }
    }
}
