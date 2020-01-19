using System;

namespace wspoliniowosc
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] x = new int[3];
			int[] y = new int[3];
			int det;
			for (int i = 1; i < 4; i++)
			{
				Console.WriteLine("Podaj współrzędne puntktu: " + i);
				x[i - 1] = int.Parse(Console.ReadLine());
				y[i - 1] = int.Parse(Console.ReadLine());
			}
			det = x[0] * y[1] + x[1] * y[2] + x[2] * y[0] - x[2] * y[1] - x[0] * y[2] - x[1] * y[0];
			if (det == 0)
			{
				Console.WriteLine("punkty na płaszczyźnie są współliniowe");
			}
			else
			{
				Console.WriteLine("punkty na płaszczyźnie nie są współliniowe");
			}
		}
	}
}
