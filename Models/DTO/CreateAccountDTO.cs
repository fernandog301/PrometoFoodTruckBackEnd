using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrometoFoodTruckBackEnd.Models.DTO
{
    public class CreateAccountDTO
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}