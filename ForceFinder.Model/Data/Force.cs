using System;
using System.Collections.Generic;
using System.Text;

namespace ForceFinder.Model.Data
{
    public class Force
    {
        public int Id { get; set; }
        public int Mass { get; set; }
        public int Acceleration { get; set; }
        public double Total { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime UpdatedDate { get; set; }
        
    }
}
