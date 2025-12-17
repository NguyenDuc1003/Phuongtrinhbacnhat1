public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Giải phương trình bậc nhất ax + b = 0");
        Console.Write("Nhập a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập b: ");
        double b = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phương trình có vô số nghiệm.");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
        }
        else
        {
            double x = -b / a;
            Console.WriteLine($"Nghiệm của phương trình là x = {x}");
        }
    }
}