using System;
using System.Collections.Generic;
using System.Text;

namespace _03.LinQ {
    public class Student {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public List<int> Books { get; set; }
        public override string ToString() {
            return  $"{Name}_{Age}_{Score}"; ;
        }
    }
}
