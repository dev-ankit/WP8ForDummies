using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBinding
{
    public class Person
    {
        public String Name { get; set; }
        public String ProfileUrl { get; set; }

        public Person(String name, String url)
        {
            Name = name;
            ProfileUrl = url;
        }
    }
}
