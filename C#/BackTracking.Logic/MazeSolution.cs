using System;

namespace BackTracking.Logic
{
	public class MazeSolution
	{
		public bool HasSolution { get; private set; }
		public int[][] Solution { get; private set; }

		public static MazeSolution NoSolution {
			get {
				return new MazeSolution (false, new int[][] {
					new int[] { 0, 0, 0, 0 },
					new int[] { 0, 0, 0, 0 },
					new int[] { 0, 0, 0, 0 },
					new int[] { 0, 0, 0, 0 }
				});
			}
		}

		public MazeSolution (bool hasSolution, int[][] solution)
		{
			this.HasSolution = hasSolution;
			this.Solution = solution;
		}
	}
}

