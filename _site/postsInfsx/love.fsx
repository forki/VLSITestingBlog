(*** raw ***)
---
layout: page
title: your post title
----

(**
Literate sample
===============
run it in Visual Studio or MonoDevelop).
*)

/// The Hello World of functional languages!
let rec factorial x = 
  if x = 0 then 1 
  else x * (factorial (x - 1))

let f10 = factorial 10

(**
Hiding code
-----------

If you want to include some code in the source code, 
but omit it from the output, you can use the `hide` 
command.
*)

(*** hide ***)
/// This is a hidden answer
let hidden = 42