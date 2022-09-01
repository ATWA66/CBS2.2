double tax = 18;
Console.WriteLine("enter your name");
string name= Console.ReadLine();
Console.WriteLine("enter your surname");
string surname = Console.ReadLine();
Employee Employee1 = new Employee(name,  surname);
Console.WriteLine("enter your compani position(jun of mid):");
string pos =Console.ReadLine();
Console.WriteLine("enter your expirience in years:");
int exp = Convert.ToInt32(Console.ReadLine());
Employee1.salaryInfo(ref tax, exp, pos);
partial class Employee 
{ 
    public string name { get; set; }
    public string surname { get; set; }
    public Employee(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }
    public void salaryInfo(ref double tax, int exp, string position)
    {
        double salary;
        switch (position)
        {
            case "jun":
                {
                    salary = (500 + exp * 100);
                    tax = salary * (tax / 100);
                    break;
                }
            case "mid":
                {
                    salary = (700 + exp * 100);
                    tax = salary * (tax / 100);
                    break;
                }
            default:
                {
                    Console.WriteLine("You entered not existing position");
                    return;
                }
        }
        Console.WriteLine("Your profile:\n"+ name + "," + surname + "\nposition:" + position + "    salary:" + salary + "   tax:" + tax);
    }
}


