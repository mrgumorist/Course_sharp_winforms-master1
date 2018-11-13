using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_sharp_winforms
{
    [Serializable]
    public class User
    {
        public User()
        {

        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Age { get; set; }
        public DateTime TimeOfRegestration { get; set; }
        public DateTime LastLogin { get; set; }
        public int PriceOforders { get; set; } = 0;
        public string TypeOfAccount { get; set; }
        public int ID { get; set; }
        public int TotalPrice { get; set; } = 0;
        public string OrderStatus { get; set; } = "0";
        public bool IsBaned { get; set; } = false;
        [NonSerialized]
        public List<string> listOfTempBuying = new List<string>();

    }
}
