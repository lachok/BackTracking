var RatMaze = require('./RatMaze');

describe('RatMaze', function() {
    
    it("should solve a solvable maze", function() {
        var maze = [
            [1, 0, 0, 0],
            [1, 1, 0, 1],
            [0, 1, 0, 0],
            [1, 1, 1, 1]
        ];
        
        var expectedSolution =[
            [ 1, 0, 0, 0 ],
            [ 1, 1, 0, 0 ],
            [ 0, 1, 0, 0 ],
            [ 0, 1, 1, 1 ]
        ];
        
        var solution = RatMaze.solveMaze(maze);
        
        expect(solution.hasSolution).toBe(true);
        expect(solution.solution).toEqual(expectedSolution);
    });
    
    it("should not solve an unsolvable maze", function() {
        var maze = [
            [1, 0, 0, 0],
            [1, 1, 1, 1],
            [0, 0, 1, 0],
            [1, 0, 0, 1]
        ];
                
        var solution = RatMaze.solveMaze(maze);
        
        expect(solution.hasSolution).toBe(false);
        expect(solution.solution).toBe(undefined);
    });
});