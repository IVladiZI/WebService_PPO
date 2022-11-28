using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService_PPO.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserPassword { get; set; }
        public DateTime UserDataCreate { get; set; }
    }
}
