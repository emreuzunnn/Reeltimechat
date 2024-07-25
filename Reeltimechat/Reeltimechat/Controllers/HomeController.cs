using Microsoft.AspNetCore.Mvc;
using Reeltimechat.Models;
using System.Diagnostics;


namespace Reeltimechat.Controllers
{
    public class HomeController : Controller
    {
        
        dataController database=new dataController();
        public IActionResult Index()
        {
          
            return View();
           
            
        }
        public IActionResult kay�tol()
        {
            return View();
        }
        public IActionResult kullan�c�ekle(kisiler kay�t)
        {
            database.useradd(kay�t.kad, kay�t.Pass);


            return View("Index");
        }

        public static string kullan�c�ad�;
        [HttpPost]
        public IActionResult giris(kisiler veri)
        {
            string Giris = database.usercontrol(veri.kad,veri.Pass);
            if(Giris== "Ba�ar�l�")
            {
                kullan�c�ad� = veri.kad;
                birles modelverisis = new birles();
                dataController database = new dataController();

                var data = database.veri();
                modelverisis.lista = data;
                return View("../mesajlar/mesajlar",modelverisis);

            }

            return View("Index");





        }

        public IActionResult mesajat(string kad,string mesaj)
        {
            return View();
        }



    }
}
