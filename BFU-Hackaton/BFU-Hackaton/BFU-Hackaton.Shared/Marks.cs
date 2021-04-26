using System;
using System.Collections.Generic;
using System.Text;

namespace BFU_Hackaton
{
    public class Marks
    {

            public int number { get; set; }
            public string year { get; set; }
            public string semestar { get; set; }
            public string subject { get; set; }
            public string mark { get; set; }
            public string session { get; set; }
            public string day { get; set; }
            public string credits { get; set; }
            public string note { get; set; }

        public class RootObject
        {
            public List<Marks> MARKS { get; set; }
        }
    }
}
