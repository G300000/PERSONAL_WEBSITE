📌 Overview

This is a personal website developed using ASP.NET Core MVC, focusing on front-end design while applying the MVC architecture.
The project demonstrates the use of C#, Razor views, HTML, and CSS to create a structured and responsive web application.

⚠️ Note: This project cannot run directly on GitHub Pages because it uses C# and ASP.NET. It must be run locally or deployed to a supported hosting service.

🛠️ Technologies Used

C#

ASP.NET Core MVC

Razor Views (.cshtml)

HTML5 / CSS3

Visual Studio 2022

📂 Project Structure
├── Controllers
│   ├── HomeController.cs
│   └── ContactController.cs
├── Models
│   ├── Profile.cs
│   └── ErrorViewModel.cs
├── Views
│   ├── Home
│   │   └── Index.cshtml
│   ├── Shared
│   │   └── _Layout.cshtml
│   └── Error.cshtml
├── wwwroot
│   └── images (me.jpg)
├── Program.cs
├── appsettings.json
├── PersonalSite.sln
└── README.md

🚀 How to Run Locally
✅ Requirements

.NET SDK 6.0 or later

Visual Studio 2022
(with ASP.NET and Web Development workload)

▶ Run Using Visual Studio (Recommended)

Clone the repository:

git clone https://github.com/your-username/your-repo-name.git


Open Visual Studio 2022

Open:

PersonalSite.sln


Click Run (F5)

The site will open in your browser:

https://localhost:xxxx

▶ Run Using Command Line
cd PersonalSite
dotnet run


Then open:

http://localhost:5000
or
https://localhost:5001
