using System;

namespace EmployeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("create" + "\n" +
                "edit" + "\n" +
                "retrieve");
            int i = 0;
            string x;
            char c = 'y';
            Boolean flag = false;
            Employee[] E = new Employee[2];
            while (c == 'y')
            {
                Console.WriteLine("Enter the task");
                x = Convert.ToString(Console.ReadLine());
                if (x == "create")
                {
                    if (E[i] == null)
                    {
                        flag = false;
                        for (i = 0; i < 2; i++)
                        {
                            E[i] = new Employee();
                            E[i].create();
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
                else if (x == "edit")
                {
                    int l;
                    Console.WriteLine("Enter the ID to be edited");
                    l = Convert.ToInt32(Console.ReadLine());
                    while (i < 2)
                    {
                        if (E[i] == null)
                        {
                            flag = false;
                            break;
                        }
                        else if (E[i].Id == l)
                        {
                            flag = true;
                            E[i].edit();
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        Console.WriteLine("The required field is absent");
                    }
                    i = 0;
                }
                else if (x == "view")
                {
                    int l;
                    Console.WriteLine("Enter the ID to be viewed");
                    l = Convert.ToInt32(Console.ReadLine());
                    while (i < 2)
                    {
                        if (E[i] == null)
                        {
                            flag = false;
                            break;
                        }
                        else if (E[i].Id == l)
                        {
                            E[i].retrieve();
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
                c = Convert.ToChar( Console.ReadLine());

            }
        }
    }



    class Employee
{
    public int Id, Phone;
    public string Name, Designation, Dept, Gender;


    public void retrieve()
    {
        Console.WriteLine("ID:{0}", Id);
        Console.WriteLine("Name:{0}", Name);
        Console.WriteLine("Phone Number:{0}", Phone);
        Console.WriteLine("Designation:{0}", Designation);
        Console.WriteLine("Gender:{0}", Gender);
        Console.WriteLine("Department:{0}", Dept);

    }

    public void create()
    {
        Console.WriteLine("Enter ID:");
        Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Name:");
        Name = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter phone number:");
        Phone = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter designation:");
        Designation = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter gender:");
        Gender = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter department:");
        Dept = Convert.ToString(Console.ReadLine());

    }


    public void edit()
    {
        Console.WriteLine("What field would you like to edit?" +
            "1) ID" +
            "2) Name" +
            "3) Phone" +
            "4) Designation" +
            "5) Gender" +
            "6) Department");

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

            case "Phone":
                Console.WriteLine("Enter the new number");
                Phone = Convert.ToInt32(Console.ReadLine());
                break;

            case "Designation":
                Console.WriteLine("Enter the new designation");
                Designation = Convert.ToString(Console.ReadLine());
                break;

            case "Gender":
                Console.WriteLine("Enter the Gender");
                Gender = Convert.ToString(Console.ReadLine());
                break;

            case "Dept":
                Console.WriteLine("Enter the new department");
                Dept = Convert.ToString(Console.ReadLine());
                break;

            default:
                Console.WriteLine("Error");
                break;


        }
    }
}

}
