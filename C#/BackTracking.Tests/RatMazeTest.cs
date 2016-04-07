using NUnit.Framework;
using System;
using BackTracking.Logic;

namespace BackTracking.Tests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void SolvableMazeHasSolution ()
		{
			// arrange
			var maze = new int[][] {	
				new int[] { 1, 0, 0, 0 },
				new int[] { 1, 1, 0, 1 },
				new int[] { 0, 1, 0, 0 },
				new int[] { 1, 1, 1, 1 }
			};

			var expectedSolution = new int[][] {
				new int[] { 1, 0, 0, 0 },
				new int[] { 1, 1, 0, 0 },
				new int[] { 0, 1, 0, 0 },
				new int[] { 0, 1, 1, 1 }
			};

			// act
			RatMaze ratMaze = new RatMaze(maze);
			var solution = ratMaze.SolveMaze();

			// assert
			Assert.That(solution.HasSolution);
			CollectionAssert.AreEqual(expectedSolution, solution.Solution);
		}

		[Test ()]
		public void UnsolvableMazeDoesntHaveSolution()
		{
			// arrange
			var maze = new int[][] {
				new int[] { 1, 1, 1, 1 },
				new int[] { 0, 1, 0, 0 },
				new int[] { 0, 0, 1, 0 },
				new int[] { 0, 1, 0, 0 }
			};

			var expectedSolution = new int[][] {
				new int[] { 0, 0, 0, 0 },
				new int[] { 0, 0, 0, 0 },
				new int[] { 0, 0, 0, 0 },
				new int[] { 0, 0, 0, 0 }
			};

			// act
			RatMaze ratMaze = new RatMaze(maze);
			var solution = ratMaze.SolveMaze();

			// assert
			Assert.That(!solution.HasSolution);
			CollectionAssert.AreEqual (expectedSolution, solution.Solution);
		}
	}
}