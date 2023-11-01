using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        int saat = DateTime.Now.Hour;
        
        ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
        ViewBag.Username = "Eren";
        var meetingInfo = new MeetingInfo()
        {
            Id = 1,
            Location = "Ankara Kongre Merkezi",
            Date = new DateTime(2024,01,20,20,0 ,0,00),
            NumberOfPeople = 100
            
        };
        
        return View(meetingInfo);
    }
}