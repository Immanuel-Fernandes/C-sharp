class IfTest
{
	private int even = 0, odd = 0;
	private float[] weight;
	private float[] height;
	int i, count, count1, count2;


	public void SetVal(int[] a)
	{
		count = 0;
		count1 = 0;
		count2 = 0;
		Count();		
	}

	public static void Main()
	{
		float[] weight ={ 45.0F,55.0F,47.0F,51.0F,54.0F };
		float[] height ={ 176.5F,174.2F,168.0F,170.7F,169.0F };

		
	private Count()
	{
		for (i = 0; i <= 4; i++)
		{
		
			if(weight[i] <50.0 && height[i] > 170.0)
			{
				count1 = countl + 1; // Executed when condition is true
			}					
			count = count + 1; // Always executed
		}

		count2 = count - count1;
	
		System.Console.WriteLine("Number of persons with ... ");
		System.Console.WriteLine("Weight<50 and height>170 = "+count1);
		System.Console.WriteLine("Others = "+ count2);
	}
}

class IfTestClient