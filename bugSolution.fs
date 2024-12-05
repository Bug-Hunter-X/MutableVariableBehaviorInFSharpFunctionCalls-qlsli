let x = ref 1
let y = ref 2

let swap x y =
    let temp = !x
    x := !y
    y := temp

swap x y
printf "x = %d, y = %d\n" !x !y