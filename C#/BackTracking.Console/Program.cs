using System;
using BackTracking.Logic;

namespace BackTracking.Console
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[][] maze = new int[][] {	
				new int[] {1, 0, 0, 0},
				new int[] {1, 1, 0, 1},
				new int[] {0, 1, 0, 0},
				new int[] {1, 1, 1, 1}
			};

			RatMaze ratMaze = new RatMaze(maze);
			ratMaze.SolveMaze();
			ratMaze.PrintSolution ();
		}
	}
}
