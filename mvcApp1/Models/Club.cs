using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcApp1.Models
{
    public class Club
    {
        public int ClubId { get; set; }
        public String Name { get; set; }
        public String ChairName { get; set; }

        public int memberNum { get; set; }
    }
}