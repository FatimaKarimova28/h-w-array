// See https://aka.ms/new-console-template for more information
using System;

// Console.WriteLine("Hello, World!");


//int[] array = new int[] { 100, 300, 200, 50 };
//for (int i = 0; i < array.Length; i++)
//{
//	int minIndex = i;
//	for (int j = i; j < array.Length; j++)
//	{
//		if (array[minIndex] > array[j])
//		{
//			minIndex = j;
//		}
//	}
//    int k = array[i];
//    array[i] = array[minIndex];
//    array[minIndex] = k;



//    Console.WriteLine(array[i]);
//}





//int sum = 0;
//double avarage = 0;	
//int[] array = new int[] { 1, 2, 3, 4, 5 };
//for (int i = 0; i < array.Length; i++)

//{
//	sum += array[i];
//}

//avarage = sum / array.Length;
//Console.WriteLine(avarage);







int[] arr = new int[] { 500, 300, 60, 77 };

int temp;

for (int i = arr.Length - 1;i >= 0; i--)
{
	for (int j = 0; j < arr.Length ; j++)
	{
		if (arr[j] > arr[i])
		{
			temp = arr[i];
			arr[i] = arr[j];
			arr[i] = temp;	

		}
			
	}
	Console.WriteLine(arr[i]);
}






//	{

//	}
//}

