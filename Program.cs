// See https://aka.ms/new-console-template for more information

using System;


var set = new int[] { 15, 12, -6, 8, -9, 12, 0 };


Console.WriteLine("Before sort");
foreach (int p in set)
	Console.Write(p + " ");

int temp = 0;
byte cnt = 0;
for (int j = 0; j <= set.Length - 2; j++)
{
	for (int i = 0; i <= set.Length - 2; i++)
	{
		// '>' Сортировка от A->Z.
		// '<' Сортировка от Z->A.
		if (set[i] > set[i + 1])
		{
			cnt++;

			temp = set[i + 1];
			set[i + 1] = set[i];
			set[i] = temp;
		}
	}
}

Console.WriteLine();
Console.WriteLine("After sorted:");

foreach (int p in set)
	Console.Write(p + " ");

Console.WriteLine("Replase operation: " + cnt);
