module App

open Fable.Core.JsInterop
open Sutil
open Sutil.Attr

importAll "./index.css"

let app() =
    Html.div [
        Html.h1 [
            class' "text-3xl font-bold underline"
            Html.text "Hello world!"
        ]
    ]

app() |> Program.mountElement "sutil-app"

