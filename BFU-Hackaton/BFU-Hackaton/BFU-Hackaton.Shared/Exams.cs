using System;
using System.Collections.Generic;
using System.Text;

namespace BFU_Hackaton
{
    public class Exams
    {
        public string day { get; set; }
        public string time { get; set; }
        public string room { get; set; }
        public string subject { get; set; }
        public string teacher { get; set; }
        public string spec { get; set; }
        public string type { get; set; }
        public string session { get; set; }

        public class RootObject
        {
            public List<Exams> EXAMS { get; set; }
        }
    }

    
}
