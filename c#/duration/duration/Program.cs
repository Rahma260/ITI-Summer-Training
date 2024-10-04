namespace duration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            duration d1 = new duration(1, 10, 15);
            Console.WriteLine( d1.ToString());
            duration d11 = new duration(3600);
            Console.WriteLine(d11.ToString()); ;
            duration d2 = new duration(7800);
            Console.WriteLine(d2.ToString());
            duration d3 = new duration(666);
            Console.WriteLine(d3.ToString());

            d3 = d1 + d2;

            Console.WriteLine(d3.ToString());
            d3 = d1 + 7800;
            Console.WriteLine(d3.ToString());
            d3 = 666 + d3;
            Console.WriteLine(d3.ToString());
            d3 = d1++;
            Console.WriteLine(d3.ToString());
            d3 = --d2;
            Console.WriteLine(d3.ToString());
            if (d1 > d2)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");


            if (d1 <= d2)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");

            DateTime obj = (DateTime)d1;
            Console.WriteLine(obj.ToString());
        }
    }
}
