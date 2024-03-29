﻿using System;

class Program
{
	static void Main()
	{
		// 二维数组（2-Dimensional Array）。
		// 引例：表示一个推箱子游戏的地图。
		char[,] map = new char[8, 8]
		{
			{ '#', '#', '#', '#', '#', '#', '#', '#' },
			{ '#', '#', '!', '#', '#', 'o', '#', '#' },
			{ '#', '#', '.', '#', '#', 'x', '#', '#' },
			{ '#', '#', '.', '#', '#', '.', '#', '#' },
			{ '#', '.', '.', '.', '#', '.', '.', '#' },
			{ '#', '.', '.', '.', '.', '.', '.', '#' },
			{ '#', '.', '.', '#', '#', '#', '#', '#' },
			{ '#', '#', '#', '#', '#', '#', '#', '#' }
		};

		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
				Console.Write(map[i, j]);

			Console.WriteLine();
		}
	}
}
