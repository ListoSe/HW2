//int[] arr = new int[6];
//var rnd = new Random();
//for (int i = 0;i < 6; i++)
//{
//    arr[i] = rnd.Next(0,10);
//}
//foreach (int i in arr)
//{
//    Console.Write(i);
//}
//Console.WriteLine("\n");
//int even = 0, odd = 0, unic = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//        even++;
//    else odd++;

//}
//arr = arr.Distinct().ToArray();
//foreach (int i in arr)
//{
//    unic++;
//}
//Console.WriteLine($"\n{even} + {odd} + {unic}");

//Task 2
//int[] arr = new int[6];
//var rnd = new Random();
//int count = 0;
//for (int i = 0; i < 6; i++)
//{
//    arr[i] = rnd.Next(0, 10);
//}
//foreach (int i in arr)
//{
//    Console.Write(i);
//}
//Console.WriteLine();   
//int a = Convert.ToInt32(Console.ReadLine());

//foreach (int i in arr)
//{
//    if (i < a)
//        count++;
//}
//Console.WriteLine(count);

//Task 3
//int[] arr = { 1, 2, 3, 4, 1, 2, 3 };
//int[] arr2 = new int[3];
//int count = 0;
//arr2[0] = Convert.ToInt32(Console.ReadLine());
//arr2[1] = Convert.ToInt32(Console.ReadLine());
//arr2[2] = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == arr2[0])
//        if (arr[i+1] == arr2[1])
//            if (arr[i+2] == arr2[2])
//            { count++; i += 2; }
//}

//Console.WriteLine($"\n{count}");

//Task 4
//int[] arr1 = { 1, 2, 3, 4, 5, 6 };
//int[] arr2 = { 4, 5, 6, 7, 8, 9 };
//int[] arr3 = new int[arr1.Length + arr2.Length];

//for (int i = 0; i < arr3.Length; i++)
//{
//    if(i < arr1.Length)
//    {
//        arr3[i] = arr1[i];
//    }
//    else
//    {
//        arr3[i] = arr2[i-6];
//    }
//}
//foreach (int i in arr3)
//{
//    Console.Write(i);
//}
//arr3 = arr3.Distinct().ToArray();
//Console.WriteLine();
//foreach (int i in arr3)
//{
//    Console.Write(i);
//}

//Task 5
//int[,] Arr = { { 1, 2, 3,4 }, {4, 5, 6,4 } };
//int[] frr = new int[Arr.GetUpperBound(1)+1];
//int[] drr = new int[Arr.GetUpperBound(1) + 1];

//for (int i = 0;i < Arr.GetUpperBound(0) + 1; i++)
//{
//	for (int j = 0; j < Arr.GetUpperBound(1) + 1; j++)
//	{
//        if(i == 0)
//        {
//            frr[j] = Arr[i, j];
//        }
//        else
//        {
//            drr[j] = Arr[i, j];
//        }
//    }
//}
//int maxValue = 0;
//int minValue = 0;

//if (frr.Max<int>() > drr.Max<int>())
//{
//    maxValue = frr.Max<int>();
//}
//else
//{
//    maxValue = drr.Max<int>();
//}
//if (frr.Min<int>() < drr.Min<int>())
//{
//    minValue = frr.Min<int>();
//}
//else
//{
//    minValue = drr.Min<int>();
//}

//Console.WriteLine($"{maxValue}  {minValue}");
