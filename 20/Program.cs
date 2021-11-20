using System;
using System.Collections.Generic;

namespace _20
{
    class Program
    {
        public static string n;
        public static string p;
        static void Main(string[] args)
        {

            User u = new User();
            u.inputUser();
            bool c;
            do
            {
                System.Console.WriteLine();
                System.Console.Write("Enter Your Name Bank: ");
                n = Console.ReadLine().ToUpper();
                System.Console.Write("Enter Your Password :");
                p = Console.ReadLine();
                System.Console.WriteLine();

                Bank b = new Bank();
                c = b.Check(n, p);
                if (c)
                {
                    b.menu(n, p);
                }
                else
                System.Console.WriteLine("--------------- Name Bank Or Password Not valid ----------------");
                System.Console.WriteLine();
            } while (c);
        }
    }
    class User
    {
        public int mojodi;
        public string pass;
        public string NameBank;
        public string shomareHesab;
        static public List<User> user1 = new List<User>();

        public void inputUser()
        {
            User u = new User();

            u.shomareHesab = "6037697555751053";
            u.NameBank = "MELAT";
            u.mojodi = 12500000;
            u.pass = "1234";
            user1.Add(u);

            User u1 = new User();
            u1.shomareHesab = "603769751234623";
            u1.NameBank = "TEJARAT";
            u1.mojodi = 15500000;
            u1.pass = "4567";
            user1.Add(u1);
        }

    }
    interface rules
    {
        bool Check(string n, string p);
        void menu(string n, string p);
        void Mojodi(string n, string p);
        void BardashatHesab(string n, string p);
        void KartBeKart(string n, string p);

    }
    class Bank : rules
    {
        public bool Check(string n, string p)
        {
            foreach (var item in User.user1)
            {
                if (item.pass == p && item.NameBank == n)
                {
                    return true;
                }
            }
            return false;
        }

        public void menu(string n, string p)
        {
            string check;
            do
            {
                System.Console.WriteLine("_____________________________________________________________________________________________");
                System.Console.WriteLine();
                System.Console.WriteLine("            | Mojoodi |            | Bardasht |            | Kart Be Kart | ");
                System.Console.WriteLine();
                System.Console.Write("ENTER : ");
                string m = Console.ReadLine().ToLower();
                System.Console.WriteLine();
                switch (m)
                {
                    case "mojoodi":
                        Mojodi(n, p);
                        break;
                    case "bardasht":
                        BardashatHesab(n, p);
                        break;
                    case "kart be kart":
                        KartBeKart(n, p);
                        break;
                    default:
                        System.Console.WriteLine("************* not availble *************");
                        break;
                }
                System.Console.WriteLine();
                System.Console.Write("Darkhast Digari Darid ? ( y - n )  : ");
                check = Console.ReadLine();
                
                
            } while (check == "y");
            if (check=="n")
                {
                    System.Environment.Exit(0);
                }


        }
        public void Mojodi(string n, string p)
        {
            foreach (var item in User.user1)
            {
                if (item.pass == p && item.NameBank == n)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("================================================================================================");
                    System.Console.WriteLine();
                    System.Console.WriteLine(" Car Number : {0} \n Mojoodi : {1}", item.shomareHesab, item.mojodi.ToString("0,0"));
                    System.Console.WriteLine();
                    System.Console.WriteLine("================================================================================================");
                    
                }
            }
        }
        public void BardashatHesab(string n, string p)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("================================================================================================");
            System.Console.WriteLine();
            System.Console.Write(" Cheghadr Money Mikhahid?    ");
            int pool = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            foreach (var item in User.user1)
            {
                if (pool <= item.mojodi)
                {
                    if (item.pass == p && item.NameBank == n)
                    {
                        item.mojodi = item.mojodi - pool;
                        System.Console.WriteLine(" =============> Money Khod Ra Bardarid <=========== ");
                        System.Console.WriteLine();
                        System.Console.Write("Mande Mujoodi Mikhahid?  ( y - n ) :  ");
                        System.Console.WriteLine();
                        string answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            System.Console.WriteLine("Mojoodi Shoma : {0} ", item.mojodi.ToString("0,0"));
                            System.Console.WriteLine();
                            System.Console.WriteLine("================================================================================================");
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("==============|| Mojoodi Nadarid ||=============");
                    System.Console.WriteLine();
                    System.Console.WriteLine("================================================================================================");
                }
            }


        }

        public void KartBeKart(string n, string p)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("================================================================================================");
            System.Console.WriteLine();
            System.Console.Write("Shomare Hesab Maghsad Ra Vared Konid :  ");
            long m = long.Parse(Console.ReadLine());
            System.Console.Write("Mablagh Ra Vared Konid :  ");
            int pool = int.Parse(Console.ReadLine());
            foreach (var item in User.user1)
            {
                if (pool <= item.mojodi)
                {
                    if (item.pass == p && item.NameBank == n)
                    {
                        item.mojodi -= pool;
                        System.Console.WriteLine();
                        System.Console.WriteLine("            -----------  Kart Be Kart ba Movafaghiat anjam shod  ----------");
                        System.Console.WriteLine(); 
                        System.Console.WriteLine("      Az Card ---> {0} \n      Be Card ---> {1}\n      Mablagh ---> {2}\n\n      Mande Heab ---> {3}", item.shomareHesab, m,pool.ToString("0,0") ,item.mojodi.ToString("0,0"));
                        System.Console.WriteLine();
                        System.Console.WriteLine("================================================================================================");
                    }
                }
                else
                {
                    System.Console.WriteLine("==============|| Mojoodi Nadarid ||=============");
                    System.Console.WriteLine();
                    System.Console.WriteLine("================================================================================================");
                }
            }

        }

    }

}
