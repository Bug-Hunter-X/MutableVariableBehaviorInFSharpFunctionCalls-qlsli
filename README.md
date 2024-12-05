# F# Mutable Variable Bug

This repository demonstrates a common issue in F# involving mutable variables and their behavior within function scopes.  The `bug.fs` file contains code that attempts to swap two mutable variables using a function, but the swap doesn't persist outside the function's scope.  The solution is provided in `bugSolution.fs`. This unexpected behavior is often encountered by those new to F#'s handling of mutability.