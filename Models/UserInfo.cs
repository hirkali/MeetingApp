using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models;

public class UserInfo
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Adınızı Girmediniz!")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Telefonunuzu Girmediniz!!")]
    public string? Phone { get; set; }
    [Required(ErrorMessage = "Hatalı Mail!!"),EmailAddress]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Katılım Bilgisi Seçiniz!!")]
    public bool? WillAttend { get; set; }
}