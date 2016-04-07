
function printSolution (solution) {
    if(!solution.hasSolution) {
        console.log('No solution.');
        return;
    }
    
    for (var i = 0; i < solution.solution.length; i++) {
        console.log(solution.solution[i]);
    }
}

function solveMaze(maze) {
    // TODO
    
    throw new Error("solveMaze not implemented");
}

module.exports = {
    printSolution: printSolution,
    solveMaze: solveMaze
};