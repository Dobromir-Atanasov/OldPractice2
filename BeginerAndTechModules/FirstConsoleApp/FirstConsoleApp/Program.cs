using System;

namespace FirstConsoleApp
{
	class MainClass
	{	
		public static void Main(string[] args)  // this is a method called ain

		{
			int action = 0;
			int x = 0;
			int y = 0;
			int result = 0;

			Console.WriteLine("What would you like to do");
			Console.WriteLine("(1) Add (2) Divide (3) Substract (4) Multiply");
			action = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("Please write the first number");
			x = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("Please write the second number");
			y = Convert.ToInt32 (Console.ReadLine ());
			if (action == 1)
			{
				result = x + y;
				Console.WriteLine("The sum of x and y is = " + result);
			}
			else
			{
				if (action == 2)
				{
					result = x / y;
					Console.WriteLine("The result of x / y is = " + result);
				}
				else
				{
					if (action == 3)
					{
						result = x - y;
						Console.WriteLine("The result of x - y is = " + result);
					}
					else
					{
						result = x * y;
						Console.WriteLine("The result of x * y is = " + result);
					}
				}
			}
			Console.ReadKey ();
		}
	}
}
