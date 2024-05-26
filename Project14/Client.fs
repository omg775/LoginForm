namespace Project14

open WebSharper
open WebSharper.JavaScript
open WebSharper.UI
open WebSharper.UI.Client
open WebSharper.UI.Templating
open WebSharper.Forms
open WebSharper.UI.Html

[<JavaScript>]
module Client =
    type IndexTemplate = Template<"wwwroot/index.html", ClientLoad.FromDocument>
    let isEmailValid (email: string) =
        let emailRegex = new RegExp(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")
        emailRegex.Test(email)

    [<SPAEntryPoint>]
    let Main () =
        let firstnameValid = Var.Create true
        let lastnameValid = Var.Create true
        let passwordValid = Var.Create true
        let emailValid = Var.Create true

        IndexTemplate.Main()
            .Click(fun e ->
                e.Event.PreventDefault()
                let email = e.Vars.Email.Value
                if String.length e.Vars.Password.Value <> 0 
                && String.length e.Vars.Email.Value <> 0 
                && String.length e.Vars.FirstName.Value <> 0 
                && String.length e.Vars.LastName.Value <> 0 
                && isEmailValid email then
                    JS.Window.Location.Assign
                     ("https://www.linkedin.com/in/om-gawde-692073272/") 
                 else
                    JS.Alert
                     ("Please make sure all your details have been entered correctly.")
            )
            .Doc()
        |> Doc.RunById "main"
