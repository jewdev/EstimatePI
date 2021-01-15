using System;

class MainClass {
  public static void Main (string[] args)
  {
    int n = 1000000;
    Console.WriteLine(EstimatePI(n));
  }

  private static double EstimatePI(int n)
	{
		double num_circle = 0;
		double num_total = 0;
		
		for (int i = 0; i < n; i++)
		{
			Random rnd = new Random();
			
			double x = rnd.NextDouble();
			double y = rnd.NextDouble();
			
			double distance = Math.Pow(x, 2) + Math.Pow(y, 2);
			
			if (distance <= 1)
				num_circle++;
			
			num_total++;
		}
		
		return 4 * num_circle / num_total;
	}
}