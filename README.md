#Login Form with F#

This is a Login Form which i created and it takes you to my LinkedIn Profile. The form will only take you to my profile if all of your details have been entered correctly.
For example if you enter anything random in the email section it will tell you to enter all you details correctly. You have to enter a valid email address.

## Sample Images

![image](https://github.com/omg775/LoginForm/assets/113525658/3922bf0e-9e96-4b17-a678-7f3bb87efd97)

![image](https://github.com/omg775/LoginForm/assets/113525658/b524db34-340d-45ac-9e9f-c1e1c9e5f152)

![image](https://github.com/omg775/LoginForm/assets/113525658/ba88da6e-6969-4966-8581-edbee4fae4f2)

![image](https://github.com/omg775/LoginForm/assets/113525658/0b1d4ad1-a56f-4fc8-8f88-18dc2195e1f9)


## Technologies used


- [F#](https://fsharp.org)
- [WebSharper](https://websharper.com)
- [ASP.NET Core](https://dotnet.microsoft.com/en-us/apps/aspnet)

## Preview

You can see a live preview of the website [here](https://linkedinloginform.azurewebsites.net/).

## Project Architecture 

- **Client.fs**: contains the client-side code including all logic and functionality 
- **wwwroot/index.html**: The main HTML file using websharper templating
- **wwwroot/styles.css**: Styles for the page.


## Getting Started

To get a local copy up and running follow these simple steps.

### Prerequisites

Before you start, ensure you have the following installed:

- Aleast version6 of [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)
- npm 

### Installation

1. Clone the repo
```sh
git clone https://github.com/omg775/LoginForm.git
```
2. Navigate to the project directory
```sh
cd project 14
```

3. Build the project using the following command:
```sh
dotnet build
```

4. Run the project:
```sh
dotnet run
```
5. Open your web browser and navigate to [https://localhost:64371/](https://localhost:64371/) to view the application.
