Invoice Instance = new Invoice(20002, "GBB", "SBX");
Instance.price();
class Invoice 
{
    public int account { get; }
    public string customer { get; }
    public string provider { get; }
    public Invoice(int account, string customer, string provider)
    {
        this.account = account;
        this.customer = customer;
        this.provider = provider;
    }
    private string article = "asdasdasfewr";
    private int quantity = 10;
    public void price()
    {
        string res = @"Without tax:";
        double price1=70;
        double price2;
        price1 *= quantity;
        res += Convert.ToString(price1);
        res += @"
with tax:";
        price2 = price1 * 20 / 100;
        price1 += price2;
        res += Convert.ToString(price1);
        Console.WriteLine(res);
    }
} 
