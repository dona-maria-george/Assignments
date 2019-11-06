using System;

namespace BankG3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("The allowed functions are" +
                "\ncreate\n" +
                "\nview\n" +
                "\nedit\n" +
                "\ndebit\n" +
                "\ncredit\n");
            string x;
            char c = 'y';
            Boolean flag;
            Account[] C = new Account[2];
            while (c == 'y')
            {
                flag = true;
                Console.WriteLine("Enter the task");
                x = Convert.ToString(Console.ReadLine());
                if (x == "create")
                {
                    if (C[i] == null)
                    {
                        flag = false;
                        for (i = 0; i < 2; i++)
                        {
                            C[i] = new Account();
                            C[i].create();
                            Console.WriteLine("\n" + "Enter next value" + "\n");
                        }
                    }
                    else
                    {
                        flag = true;
                        Console.WriteLine("There is already a value in the field");
                    }
                    i = 0;
                }
                if (x == "edit")
                {
                    int l;
                    Console.WriteLine("Enter the ID to be edited");
                    l = Convert.ToInt32(Console.ReadLine());
                    while (i < 2)
                    {
                        if (C[i] == null)
                        {
                            flag = false;
                            break;
                        }
                        else if (C[i].Id == l)
                        {
                            flag = true;
                            C[i].edit();
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        Console.WriteLine("The required field is absent");
                    }
                    i = 0;
                }
                if (x == "debit")
                {
                    int l;
                    Console.WriteLine("Enter the ID to which amount has to be debited");
                    l = Convert.ToInt32(Console.ReadLine());
                    while (i <   2)
                    {
                        //Console.WriteLine(i);
                        //Console.WriteLine(C[i].Balance);
                        if (C[i] == null)
                        {
                            flag = false;
                            break;
                        }
                        if (C[i].Id == l)
                        {
                            C[i].debit();
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        Console.WriteLine("The required field is absent");
                    }
                    i = 0;

                }
                if (x == "view")
                {
                    int l;
                    Console.WriteLine("Enter the ID to be viewed");
                    l = Convert.ToInt32(Console.ReadLine());
                    while (i < 2)
                    {
                        if (C[i] == null)
                        {
                            flag = false;
                            break;
                        }
                        else if (C[i].Id == l)
                        {
                            C[i].view();
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        Console.WriteLine("The required field is absent");
                    }
                    i = 0;

                }
                if (x == "credit")
                {
                    int l;
                    Console.WriteLine("Enter the ID to which amount has to be credited");
                    l = Convert.ToInt32(Console.ReadLine());
                    while (i < 2)
                    {
                        //Console.WriteLine(i);
                        //Console.WriteLine(C[i].Balance);
                        if (C[i] == null)
                        {
                            flag = false;
                            break;
                        }
                        if (C[i].Id == l)
                        {
                            C[i].credit();
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        Console.WriteLine("The required field is absent");
                    }
                    i = 0;

                }
                Console.WriteLine("Would you like to continue? (Give y/n)");
                c = Convert.ToChar(Console.ReadLine());

            }
        }
    }





    class Account
    {
        public int Id;
        public string Name;
        public decimal Balance;


        public void view()
        {
            Console.WriteLine("ID:{0}", Id);
            Console.WriteLine("Name:{0}", Name);
            Console.WriteLine("Balance:{0}", Balance);

        }

        public void create()
        {
            Console.WriteLine("Enter ID:");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter balance:");
            Balance = Convert.ToDecimal(Console.ReadLine());

        }


        public void edit()
        {
            Console.WriteLine("What field would you like to edit?" +
                "\n1)ID\n" +
                "2)Name\n" +
                "3)Balance\n");

            switch (Console.ReadLine())
            {

                case "ID":
                    Console.WriteLine("Enter the new ID");
                    Id = Convert.ToInt32(Console.ReadLine());
                    break;

                case "Name":
                    Console.WriteLine("Enter the new name");
                    Name = Convert.ToString(Console.ReadLine());
                    break;

                case "Balance":
                    Console.WriteLine("Enter the new balance");
                    Balance = Convert.ToDecimal(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Error");
                    break;


            }
        }

        public void debit()
        {
            decimal damt;
            Console.WriteLine("Enter the amount to be debited:");
            damt=Convert.ToInt32( Console.ReadLine());
            if (damt < Balance)
            {
                Balance = Balance - damt;
                Console.WriteLine("Your amount has been debited\n" +
                    "Your current balance is: {0}",Balance);
            }
            else
                Console.WriteLine("No sufficient amount in account");
            
        }

        public void credit()
        {
            decimal c_amt;
            Console.WriteLine("Enter the amount to be credited:");
            c_amt = Convert.ToDecimal(Console.ReadLine());
            Balance = Balance +c_amt;
            Console.WriteLine("Your amount has been credited\n" +
                    "Your current balance is{0}: ", Balance);
        }
    }
}
