using System;
	class two_dim_array
	{
		public static void main()
		{
			int[,]a=new int[2,3];
			for(int i=0; i<a.GetLength(0); i++)
			{
				for(int j=0; j<a.GetLength(1); j++)
				{
					a[i,j]=Convert.ToInt32(Console.ReadLine());
				}
			}
			for(int i=0; i<a.GetLength(0)); i++)
			{
				for(int j=0; j<a.GetLength(1); j++)
				{
					Console.WriteLine(a[i,j]);
				}
			}
		}
	}	