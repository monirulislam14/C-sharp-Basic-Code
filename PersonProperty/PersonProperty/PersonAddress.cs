using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProperty
{
    class PersonAddress
    {  
        public string HouseNo { set; get; }
        public string RoadNo { set; get; }
        public string Thana { set; get; }
        public string District { set; get; }
        public string Division { set; get; }

        public string PersonDetails()
        {
            if (HouseNo != null)
            {
                return (RoadNo +"\n"+ District);
            }
            else
            {
                return null;
            }
           
        }
    }
}
