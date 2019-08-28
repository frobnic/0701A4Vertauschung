namespace _0701A4Vertauschung
{
    class Program
    {
        static void schwapp(out int a, out int b)
        {
            int t;

            if (a > b)
            {
                t = a;
                a = b;
                b = t;
            }
        }

        static void Main(string[] args)
        {
            int x = 7, y = 2;

            schwapp(out x, out y);

            
        }
    }
}
