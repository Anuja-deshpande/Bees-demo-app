using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text.Json;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Bees> a = new List<Bees>();

            int objectsToCreate = 10;

            // Create an array to hold all your objects
            Worker[] WorkerBees = new Worker[objectsToCreate];
            Queen[] QueenBees = new Queen[objectsToCreate];
            Drone[] DroneBees = new Drone[objectsToCreate];

            for (int i = 0; i < objectsToCreate; i++)
            {
                WorkerBees[i] = new Worker();
                QueenBees[i] = new Queen();
                DroneBees[i] = new Drone();

            }
            a.AddRange(WorkerBees);
            a.AddRange(QueenBees);
            a.AddRange(DroneBees);
           
           

            //foreach (Bees ele in a)
            //{
            //    int num = random.Next(0, 80);
            //    // Console.WriteLine(num);
            //    // Console.WriteLine(ele.Damage(num));
            //    // Console.WriteLine(ele.Dead);
            //    // Console.WriteLine(ele.GetType().Name );

            //    //listView1.Items.Add(new ListViewItem(new[] { ""+ele.GetType().Name, ""+ num, ""+ ele.Damage(num), ""+ele.Dead }));

              
            //}
            return View(a);
        }

        [HttpPost]
        public string Damage(string Health, string Type, string dead)
        {
            string output = "";
            Random random = new Random();
            int num = random.Next(0, 80);
            Bees bee = null;
            switch (Type)
            {
                case "Worker":
                    // code block
                    bee= new Worker();
                    bee.Damage(num);
                    break;
                case "Queen":
                    // code block
                    bee= new Queen();
                    bee.Damage(num);
                    break;
                case "Drone":
                    // code block
                    bee= new Drone();
                    bee.Damage(num);
                    break;
            }

            var opt = new JsonSerializerOptions() { WriteIndented=true };
            string strJson = System.Text.Json.JsonSerializer.Serialize<Bees>(bee, opt);
            strJson =strJson +" Persentage reduction =" +num;
            Console.WriteLine(strJson);
            return strJson;
        }
    }
}
