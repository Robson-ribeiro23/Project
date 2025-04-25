using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera2025.Class
{
    internal class Local
    {
        public string CEP, num, street, estate, city, reference;

        public Local(string CEP, string num, string street, string estate, string city, string reference)
        {
            this.CEP = CEP;
            this.num = num;
            this.street = street;
            this.estate = estate;
            this.city = city;
            this.reference = reference;


        }
    }
}

