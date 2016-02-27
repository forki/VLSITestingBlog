#load @"../packages/FSharp.Formatting.2.14.0/FSharp.Formatting.fsx"
open FSharp.Literate
open System.IO

let source = @"C:\Users\pnsak\Documents\GitHub\VLSITestingBlog\"
let codeDirectory = Path.Combine(__SOURCE_DIRECTORY__, "posts/")
let postsDirectory = Path.Combine(source, "_posts/")

Literate.ProcessDirectory(codeDirectory, outputDirectory = postsDirectory,
    format = OutputKind.Html, lineNumbers = true, generateAnchors = true)