# F# Stack Overflow Exception

This repository demonstrates a common but easily overlooked error in F#: stack overflow exceptions caused by runaway recursion.  The provided code uses recursive functions without proper termination conditions, leading to excessive stack usage and the eventual exception.

## Understanding the Bug
The `bug.fs` file contains two recursive functions, `loop1` and `loop2`.  Each function increments a counter and calls itself recursively until a condition (x < 100000 and y < 100000) is met. However, because the condition is only checked *after* the recursive call, the function continues to call itself an unbounded number of times. This creates a very deep call stack, resulting in a `StackOverflowException`.

## Solution
The `bugSolution.fs` file provides a corrected version. The key change involves ensuring that the recursive call happens *only* if the condition is true, preventing the stack from growing indefinitely.  This is accomplished by modifying the recursive call condition.   A more robust solution would also add input validation and error handling.

## How to Run
1. Clone this repository.
2. Open `bug.fs` and `bugSolution.fs` in a F# IDE (e.g., Visual Studio, VS Code with the Ionide extension).
3. Run the code. Observe that `bug.fs` crashes while `bugSolution.fs` runs successfully.

This example highlights the importance of carefully designing recursive functions to avoid stack overflow errors. Always ensure that a proper base case exists that will eventually stop the recursion.