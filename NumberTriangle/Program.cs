using System;
using System.Text;

namespace NumberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Triangle(5));
        }

        static string Triangle(int n)
        {
            var builder = new StringBuilder();
            var count = 1;
            var center = (n / 2) + 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= center - i; j++)
                {
                    builder.Append("  ");
                }
                for (int j = 0; j < count; j++)
                {
                    if ((count - j) >= (i + 1))
                    {
                        builder.Append(count - j);
                    }
                    else
                    {
                        builder.Append(j + 1);
                    }
                    if (j < count - 1)
                    {
                        builder.Append(" ");
                    }
                }
                if (i < n - 1)
                {
                    builder.Append("\n");
                }
                count += 2;
            }
            return builder.ToString();
        }
    }
}
