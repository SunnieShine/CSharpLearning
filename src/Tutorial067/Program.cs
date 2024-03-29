﻿using System;

class Program
{
	static void Main()
	{
		// 交错数组（锯齿数组，Jigsaw Array）。
		// 1、交错数组的初始化：
		//     new 后跟的数组类型，用两个中括号表示，
		//     其中第二个中括号是不写数值的，因为交错数组的第二个维度的长度是
		//     不定的，它是由具体在初始化器里给出的元素的长度来决定的，
		//     而且交错数组的每一个元素（数组）长度都可以不相同。
		// 2、初始化器语法：
		//     每一个元素要得当成是一个单独的一维数组，然后进行初始化。
		//     初始化的内容可以直接把一个实际的变量写在里面：
		//     int[] a = { 1, 2 };
		//     int[] b = { 3, 4 };
		//     int[][] arr = { a, b };
		//     当然，也可以直接把数组的初始化器部分抄写进整个初始化器的语句里去。
		//     不过此时是不能省略 new int[] 部分：
		//     int[][] arr =
		//     {
		//         new int[] { 1, 2 },
		//         new int[] { 3, 4, 5 }
		//     };
		//     如果省略掉 new int[] 部分后，整个初始化器就变成了初始化
		//     一个普通的方形数组了，而它的实例化类型是 int[,] 而不是 int[][]。
		//     int[][] arr = { { 1, 2 }, { 3, 4, 5 } }; // 错误的写法。

		int[][] arr = new int[][]
		{
			new int[] { 1, 2, 3 },
			new int[] { 3, 4, 5 },
			new int[] { 4, 5, 6 },
			new int[] { 7, 8, 9 }
		};

		int[,] brr = new int[,]
		{
			{ 1, 2, 3 },
			{ 3, 4, 5 },
			{ 4, 5, 6 },
			{ 7, 8, 9 }
		};
	}
}
