let mutable x = 0
let mutable y = 0

let rec loop1 () =
    x <- x + 1
    if x < 100000 then
        loop1 ()
    else
        ()

let rec loop2 () =
    y <- y + 1
    if y < 100000 then
        loop2 ()
    else
        ()

loop1 ()
loop2 ()
printf "%d %d" x y