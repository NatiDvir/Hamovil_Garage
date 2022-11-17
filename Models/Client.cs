using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaMovil.Models
{
    public class Client
    {
        public int Id{ get; set; }
        public int car_Id { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        
        public Client()
        {

        }
    }
}
