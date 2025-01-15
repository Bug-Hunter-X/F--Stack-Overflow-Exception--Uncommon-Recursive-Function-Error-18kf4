let mutable x = 0
let mutable y = 0

let rec loop1 () =
    if x < 100000 then
        (x <- x + 1; loop1 ()) // Correct recursive call condition
    else
        ()

let rec loop2 () =
    if y < 100000 then
        (y <- y + 1; loop2 ()) // Correct recursive call condition
    else
        ()

loop1 ()
loop2 ()
printf "%d %d" x y