
var RatMaze = require('./RatMaze');

var maze = [
    [1, 0, 0, 0],
    [1, 1, 0, 1],
    [0, 1, 0, 0],
    [1, 1, 1, 1]
];

var solution = RatMaze.solveMaze(maze);
RatMaze.printSolution(solution);
