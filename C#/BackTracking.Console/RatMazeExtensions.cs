using System;
using BackTracking.Logic;

namespace BackTracking.Console
{
	public static class RatMazeExtensions
	{
		public static void PrintSolution(this RatMaze maze)
		{
			var solution = maze.SolveMaze().Solution;

			for (int i = 0; i < solution.Length; i++)
			{
				for (int j = 0; j < solution[i].Length; j++)
				{
					System.Console.Write(" " + solution[i][j] + " ");
				}
				System.Console.WriteLine ();
			}
		}
	}
}

