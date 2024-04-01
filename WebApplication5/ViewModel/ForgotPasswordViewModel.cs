using System.ComponentModel.DataAnnotations;

namespace WebApplication5.ViewModel;

public class ForgotPasswordViewModel
{
    [Required,DataType(DataType.EmailAddress)]
    public string Email { get; set; }

}
