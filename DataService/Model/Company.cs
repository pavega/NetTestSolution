using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Model
{
    public class Company
    {
        public string name { get; set; }
        public string catchPhrase { get; set; } 
        public string bs { get; set; }

        public Company() { }

        public Company(string name, string catchPhrase, string bs)
        {
            this.name = name;
            this.catchPhrase = catchPhrase;
            this.bs = bs;
        }
    }
}
