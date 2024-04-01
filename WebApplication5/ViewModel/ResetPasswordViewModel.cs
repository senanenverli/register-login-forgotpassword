using System.ComponentModel.DataAnnotations;

namespace WebApplication5.ViewModel;

public class ResetPasswordViewModel
{
    
    public string Email { get; set; }
    public string Token { get; set; }
}
