using System;

namespace LessonHomeWork3Ramification
{
    public class Ramification
    {
		public static double Task1(double A, double B)
		{
			if (A > B)
			{
				return (A + B);
			}
			else if (A == B)
			{
				return (A * B);
			}
			else
			{
				return (A - B);
			}
		}
		public static string Task2(double X, double Y)
		{
			string Temp = "0";
			if (X > 0 && Y > 0)
			{
				Temp = ("1 part");
			}
			else if (X < 0 && Y < 0)
			{
				Temp = ("3 part");
			}
			else if (X > 0 && Y < 0)
			{
				Temp = ("4 part");
			}
			else if (X < 0 && Y > 0)
			{
				Temp = ("2 part");
			}
			else if (X == 0 && Y > 0)
			{
				Temp = ("2-1 part");
			}
			else if (X == 0 && Y < 0)
			{
				Temp = ("3-4 part");
			}
			else if (X < 0 && Y == 0)
			{
				Temp = ("2-3 part");
			}
			else if (X > 0 && Y == 0)
			{
				Temp = ("1-4 part");
			}
			else
			{
				Temp = ("Centre");
			}
			return Temp;
		}
		public static (double max, double average, double min) Task3(double A, double B, double C)
		{
			double max = 0;
			double min = 0;
			double average = 0;

			if (A >= B && A >= C)
			{
				max = A;
			}
			else if (B >= A && B >= C)
			{
				max = B;
			}
			else if (C >= A && C >= B)
			{
				max = C;
			}
			if (A <= B && A <= C)
			{
				min = A;
			}
			else if (B <= A && B <= C)
			{
				min = B;
			}
			else if (C <= A && C <= B)
			{
				min = C;
			}
			if (A <= max && A >= min)
			{
				average = A;
			}
			else if (B <= max && B >= min)
			{
				average = B;
			}
			else if (C <= max && C >= min)
			{
				average = C;
			}
			return (max, average, min);
		}
		public static double Task4(double A, double B, double C)
		{
			double Dis = B * B - 4 * A * C;

			if (Dis == 0)
			{
				return ((-B) / (2 * A));
			}
			else if (Dis < 0)
			{
				return (0);
			}
			else if (Dis > 0)
			{
				return (-(B / (2 * A)) + Math.Sqrt(Dis / 4 * A * A));
			}

		}
	}
}
