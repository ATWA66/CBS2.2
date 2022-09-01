Converter Instance = new Converter(39.1621, 38.7730, 8.0686);
Console.WriteLine("Welcome, what do you want to convert:\n1.grn\n2.usd\n3.eur\n4.pln\n");
string moneyType = Console.ReadLine();
Console.WriteLine("enter the sum:\n");
double sum = Convert.ToDouble(Console.ReadLine());
if (moneyType == "1")
{
    Console.WriteLine("Convert to:\n1.usd\n2.eur\n3.pln\n");
    moneyType = Console.ReadLine();
    sum = Instance.convertGrn(moneyType,sum);
    Console.WriteLine("Result: " + sum);
}
else
{
    sum = Instance.convertToGrn(moneyType, sum);
    Console.WriteLine("Result: " + sum);
}
class Converter
{
    public double usd { get; set; }
    public double pln { get; set; }
    public double eur { get; set; }
    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }
    public double convertGrn(string moneyType, double sum)
    {
        switch (moneyType) 
        {
            case "1":
                {
                    sum /= usd;
                    return sum;
                }
            case "2":
                {
                    sum /= eur;
                    return sum;
                }
            case "3":
                {
                    sum /= pln;
                    return sum;
                }
            default:
                {
                    Console.WriteLine("You entered an unexisting type");
                    return sum;
                }
        }
    }
    public double convertToGrn(string moneyType, double sum)
    {
        switch (moneyType)
        {
            case "1":
                {
                    sum *= usd;
                    return sum;
                }
            case "2":
                {
                    sum *= eur;
                    return sum;
                }
            case "3":
                {
                    sum *= pln;
                    return sum;
                }
            default:
                {
                    Console.WriteLine("You entered an unexisting type");
                    return sum;
                }
        }
    }
}

