using System;
using System.Collections.Generic;

namespace project.Models
{
    public class Workouts
    {
        public string type { get; set; }
        public string musclesused { get; set; }
        public List<string> exercises { get; set; }
    }
}
