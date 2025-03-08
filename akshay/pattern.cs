using System;
class abc 
{
	public void fun()
	{
		int a,b,i,j;
		a=Convert.ToInt32(Console.ReadLine());
		if(a%2==0)
		{
			b=a/2;
		}
		else
		{
			a--;
			b=a/2;
		}
		for(i=0;i<=a;i++)
		{
			for(j=0;j<=a;j++)
			{
				if(i==b || j==b || j==0 && i<=b ||i==0 && j>b || j==a && i>b || i==a && j<b)
				{
					Console.Write(" #");
				}
				else
				{
					Console.Write("  ");
				}
			}
			
			Console.WriteLine();
		}
	}
}
class main_cls
{
	public static void Main()
	{
		abc obj=new abc();
		obj.fun();
	}
}