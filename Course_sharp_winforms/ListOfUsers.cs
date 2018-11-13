using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Course_sharp_winforms
{

    public  class SingleTon
    {
        public List<User> users = new List<User>();
      
        private static SingleTon instance;

        private SingleTon()
        {
        }

        public static SingleTon getInstance()
        {
            if (instance == null)
                instance = new SingleTon();
            return instance;
        }
        public void Append(User user)
        {
            this.users.Add(user);
        }

       
    }
}
