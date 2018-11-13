using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Course_sharp_winforms
{
    static class Helper
    {

        public const   int PriceOfFirst=6;
        public const  int PriceOfSecond = 3;
        public const int PriceOf3 = 4;
        public const int Drink =2;
        public const int PriceOf4 = 8;
        public const int PriceOfSalad1 = 3;
        public const int PriceOfSalad2 = 4;
        public const string path =@"Listik.txt";
        static public int IDSelected { set; get; } = -1;
        static XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
        static public List<string> ListOfTypesUsers = new List<string>() { "Admin", "Client", "Courier", "Cook" };
        static public int GetID()
        {
            var temp = SingleTon.getInstance();
            int ID=temp.users.Count + 1;

            return ID;
        }
      
        public static void Serialize()
        {
            var temp = SingleTon.getInstance();

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, temp.users);
                }
            }
            catch
            {

            }
        }


        public static void Deserialize()
        {
            try
            {
                List<User> newuser;
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    newuser = (List<User>)formatter.Deserialize(fs);
                }
                var tetmp =SingleTon.getInstance();
                tetmp.users = newuser;
            }
            catch
            {
                
            }
            
            
        }
      public static void PrintF1()
        {




            



        }
    }
}






