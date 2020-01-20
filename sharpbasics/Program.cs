using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace sharpbasics
{
    class Program
    {
        static void Main(string[] args)
        {
            genericwithcc();
            // nongeneric();
           // Console.WriteLine("Hello World!");
        }

        public static void nongeneric()
        {
            Hashtable table = new Hashtable();
            table.Add("UserName", "ea");
            table.Add("Password", "eakojohh");
            table.Add("Button", "Submit");
            table.Add("run", "fun");

            // Console.WriteLine("The username id :" + table["UserName"]);
            foreach (var d in table.Keys)
            {
                Console.WriteLine("value for " + d + " is " + table[d]);
            }

        }

        public static void generic()
        {
            string[] use1 = new string[] { "rasj", "3213", "sdfklfdk@ghsl.com" };
            string[] use2 = new string[] { "rasj", "32", "sdfklfdk@ghsl.com" };
            string[] use3 = new string[] { "rasj", "25653", "sdfklfdk@ghsl.com" };
            Dictionary<int, string[]> dicki = new Dictionary<int, string[]>();
            dicki.Add(1, use1);
            dicki.Add(2, use2);

            foreach (var v in dicki)
            {
                string[] useinfo = v.Value;
                foreach (var user in useinfo)
                {
                    Console.WriteLine(user);
                }

                //Console.WriteLine(v.Value);

            }
        }
        public static  void genericwithcc()
        {
            List<user> users = new List<user>();
            users.Add(new user {userid=09, name="bhakar",age=55,mail="bharg@kk.com",phone=54353453453});
            users.Add(new user { userid = 07, name = "beards",age=089, mail = "earbg@kk.com", phone=65686566654 });
            users.Add(new user { userid = 09, name = "samrds",age=099, mail = "samrg@kk.com", phone=64654684655 });
            Console.WriteLine("+----------------------------------------------------+");
            Console.WriteLine("| ID ||  Name  || Age ||  Email ID  " +"" +"  || Phone Number|");
            Console.WriteLine("|____||________||_____||______________||_____________|");
            foreach (var d in users)
            {
                Console.WriteLine("| "+d.userid+"  || "+d.name+" || "+d.age+"  || "+d.mail+" || "+d.phone+" |");
            }
            Console.WriteLine("|____||________||_____||______________||_____________|");


            var ull = from user in users where user.age == 99 select user;

           // var ull1 = users.Select(x => x.name);
            
            foreach(var user in ull)
            {
                Console.WriteLine(user.name); 
            }
        }

    }
    public class user

    { 
        public int userid { get; set; }
        public string name { get; set; }
        public int  age{ get; set; }
        public string mail { get; set; }
        public Int64  phone { get; set; }

    }
} 
