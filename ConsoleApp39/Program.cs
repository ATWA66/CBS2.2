User User1 = new User("13.12.1918");
Console.WriteLine("enter login:");
User1.login = Console.ReadLine();
Console.WriteLine("enter name:");
User1.name = Console.ReadLine();
Console.WriteLine("enter surname:");
User1.surname = Console.ReadLine();
Console.WriteLine("enter age:");
User1.age = Convert.ToInt32(Console.ReadLine());
User1.ShowInfo();
class User
{
    public string login { get; set; }
    public string name{ get; set; }
    public string surname { get; set; }
    public string startDate { get; set; }
    public int age { get; set; }
    public User(string startDate)
    {
        this.startDate = startDate;
    }
    public void ShowInfo()
    {
        Console.WriteLine(login+"\n"+name+","+surname+", age:"+ age);
    }
}