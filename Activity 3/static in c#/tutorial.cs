using System;
static class Tutorial
{
	public static string Topic = "Static class";
}

class Vehicle
{
	public static string Model_color = "Black";
}

class Nparks
{
	static public int t = 104;
	public static void total()
	{
		Console.WriteLine("Total number of national parks" +
						" present in India is :{0}", t);
	}
}

class G1
{
	static G1()
	{
		Console.WriteLine("Example of Static Constructor");
	}
	public G1(int j)
	{
		Console.WriteLine("Instance Constructor " + j);
	}
	public string g1_detail(string name, string branch)
	{
		return "Name: " + name + " Branch: " + branch;
	}
}
	public class GFG
{
	static public void Main()
	{
		Console.WriteLine("Topic name is : {0} ", Tutorial.Topic);
    
		Console.WriteLine("Color of XY model is : {0} ",
									Vehicle.Model_color);

		Nparks.total();

		G1 obj = new G1(1);
		Console.WriteLine(obj.g1_detail("Sunil", "CSE"));
    
		G1 ob = new G1(2);
		Console.WriteLine(ob.g1_detail("Sweta", "ECE"));
	}
}
