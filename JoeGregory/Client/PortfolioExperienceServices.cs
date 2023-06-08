using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;

namespace JoeGregory.Client
{
    public class PortfolioExperienceServices
    {
        public List<PortfolioExperience> PortfolioExperiences { get; set; }
        public PortfolioExperienceServices()
        {
            PortfolioExperiences = new List<PortfolioExperience>();

            PortfolioExperiences.Add(

                new PortfolioExperience
                {
                    Id = "personal",
                    ProjectName = new MarkupString("About Me"),
                    ValueProposition = new MarkupString("Self-taught C# developer who's enthusiastic, dedicated, and team-oriented."),
                    TechStack = new MarkupString("C#, JavaScript, Blazor, React, SQL, NoSQL"),
                    ProjectLink = "https://www.linkedin.com/in/josephegregory/",
                    GitHubRepoLink = "https://github.com/joe-gregory",
                    ImageOrVideoLink = "/Images/conNatalia.jpg",
                    IsVideo = false,
                    Description = new MarkupString(@"
                    <p>Hi, my name is Joseph Gregory; I'm an entry-level C# developer. I am thrilled to welcome you to my porfolio page crafted with <a class='description-link' href='https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor'>.Net C# Blazor</a>, <a class='description-link' href='https://mudblazor.com/'>MudBlazor components</a> and components I built (for example, the component that allows videos inside MudCards that you will see in other cards). You can find my resume, linkedin profile and github page on the top navigation bar.</p> 
                    <p>I graduated in Mechanical engineering at Grand Valley State University in Michigan. Throughout my mechanical engineering career, I worked developing new innovative consumer products such as  <a class='description-link link-primary' href='https://www.whirlpoolcorp.com/whirlpool-corporation-debuts-new-zera-food-recycler-on-indiegogo/'>Zera</a> and I also worked in manufacturing helping automate industrial processes such as CM Industry's <a class='description-link' href='https://cmindustryinc.com/innovation/'>steel pallets</a> production line </p>
                    <p>However, my fascination for programming and intricate layers of computer technology led me down a different path. While I cherish my engineering background, my true passion lies in programming and computer technology. I am currently seeking a role as a C# developer. I'm fascinated by the ecosystem that Microsoft has built with .Net and its diverse applications, and I aim to nurture a long-term career within it. I am a hard-working, team-oriented, and self-learner. I am eager to bring value to your team and learn from you as well.<p>
                    <p>Please take a moment to browse through my portfolio and contact me using the footer form below or use the convenient copy contact info buttons. I look forward to hearing from you soon!</p>
                    ")
                }
            );

            PortfolioExperiences.Add(
                 new PortfolioExperience
                 {
                     Id = "MudBlazor",
                     ProjectName = new MarkupString("MudBlazor Contributions"),
                     ValueProposition = new MarkupString("Contributing to the MudBlazor project to improve its UI components and enhance overall user experience"),
                     TechStack = new MarkupString("C#, Blazor, Material Design, CSS"),
                     ProjectLink = "https://github.com/MudBlazor/MudBlazor",
                     GitHubRepoLink = "https://github.com/joe-gregory/MudBlazor",
                     ImageOrVideoLink = "/Images/MudBlazor.png",
                     IsVideo = false,
                     Description = new MarkupString(@"
                        <p>MudBlazor is a Material Design component framework for Blazor catering to .NET developers and written entirely in C#.</p>
                        <p>In an effort to broaden my experience beyond individual projects, I've begun contributing to this open-source project. I chose MudBlazor because of my interest in Blazor and SPAs and the user experience they provide.</p>
                        <p>I submitted the following <a class='description-link' href='https://github.com/MudBlazor/MudBlazor/pull/6958'>pull request</a> which solves an UI issue with MudDrawers. When MudDrawers are in mini mode and have MudNavLinks inside, icons of the MudDrawer get unintentionally pushed vertically. This PR solves that issue by providing different CSS rules to MudNavLink when it is inside a mini MudDrawer.</p>                  
                        <p>Currently working on the drag-and-drop file uploads component, MudFileUpload, to address <a class='description-link' href='https://github.com/MudBlazor/MudBlazor/issues/6699'>6699</a>, <a class='description-link' href='https://github.com/MudBlazor/MudBlazor/issues/6311'>6311</a>, and <a class='description-link' href='https://github.com/MudBlazor/MudBlazor/issues/6451'>6451</a>.</p>                        
                        <p>I will continually update this card with my contributions.</p>
                        ")
                 });

            PortfolioExperiences.Add(
                 new PortfolioExperience
                 {
                     Id = "StudyStacks",
                     ProjectName = new MarkupString("Study Stacks"),
                     ValueProposition = new MarkupString("Study stacks helps students memorize concepts using flashcards and providing comprehensive metrics on their results."),
                     TechStack = new MarkupString("C# .Net, Razor Pages, JavaScript, Sql, Deployed to Azure"),
                     ProjectLink = "http://studystacks.net/",
                     GitHubRepoLink = "https://github.com/joe-gregory/StudyStacks",
                     ImageOrVideoLink = "https://www.youtube.com/embed/9pigruvPi-Q",
                     IsVideo = true,
                     Description = new MarkupString(@"
                    <p>I built Study Stacks using C# .Net <a class='description-link' href='https://learn.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-7.0&tabs=visual-studio'>Razor pages</a>. Razor pages allows you to take a page-focus approach to building a web application.</p>
                    <p>Study Stacks is featured on LinkedIn on the following <a class='description-link' href='https://www.linkedin.com/advice/0/what-some-benefits-challenges-using-flashcards'>article</a>!</p>                   
                    <p>Study Stacks is a web application that helps students memorize concepts using flashcards and providing comprehensive metrics on their results for different stacks and individual cards.</p>
                    <p>Learners can create an account, stacks, and study sessions that follow a particular order or are random. Metrics of their results are collected along the way.</p>
                    <p>The humble flash card is one of the most effective study tools out there:</p>
                    <p>One study that supports the use of flashcards is ""The Spacing Effect: A Case Study in the Failure to Apply the Results of Psychological Research"" (Dempster, 1988). This study demonstrated that individuals who used spaced repetition when learning a new subject had significantly better retention of the material, even on long-term follow-up.</p>
                    <p>Another study, ""Optimizing Learning in College: Tips From Cognitive Psychology"" (Putnam et al., 2016), suggested that techniques like active recall and spaced repetition are underutilized in education, despite their demonstrated effectiveness.</p>
                    <p>If you would like more information on this project or would like to contribute, please reach out!</p>
                    ")
                 });

            PortfolioExperiences.Add(
                 new PortfolioExperience
                 {
                     Id = "PluginDemocracy",
                     ProjectName = new MarkupString("Plugin Democracy"),
                     ValueProposition = new MarkupString("Plugin Democracy is a platform that provides tools for communities to operate as direct democracies."),
                     TechStack = new MarkupString("MERN stack: MongoDB, Express, React, NodeJS"),
                     ProjectLink = "https://www.plugindemocracy.com/",
                     GitHubRepoLink = "https://github.com/joe-gregory/Plugin-Democracy",
                     ImageOrVideoLink = "https://www.youtube.com/embed/rr54hiA-R44",
                     IsVideo = true,
                     Description = new MarkupString(@"
                    <p>Plugin Democracy is a nonprofit platform that I founded that allows communities to operate as Direct Democracies. This is the most ambitious and largest software project I've worked on by myself with over 5 thousand lines of code long. Here is a <a class='description-link' href='https://www.youtube.com/embed/b3VnGWQMneQ'>video</a> where I give a tour of the code and the aplication.</p>
                    <p>The React frontend is deployed on AWS S3 and the API runs in an AWS EC2 instance.</p>                    
                    <p>The goal of Plugin Democracy is to eliminate the bottlenecks that our current political system introduce. A political system is like any other machine. Its components can be analized to find its inefficiencies. Many political problems that involve transparency can have a technical solution by open-sourcing public administration.</p>
                    <p>The application is currently in use in <a class='description-link' href=''>gated communities</a> in Mexico where it has helped them organize to enact ordenances and make improvements to public spaces.</p>
                    <p>I will be submitting Plugin Democracy to <a class='description-link' href='https://www.ffwd.org/'>fastforward</a> at the end of 2023 where I hope to gather more contributors for the project.</p>
                    <p>The next features that I plan to implement in the near future are related to community's accounting which includes the approval/rejection of public spending democratically. However, as the code base is growing, I plan to refactor the project into C# starting with the backend before implementing these new features. I believe a strongly typed language like C# becomes very useful as the code base grows. I will evaluate if I will keep the frontend in React or if I will migrate to Blazor. However, I will developed the mobile applications (and possibly desktop applications for accountants and such) within the .Net ecosystem.</p>
                    <p>If you have any more questions about the project, please reach out to me!</p>
                    ")
                 });

            PortfolioExperiences.Add(
                 new PortfolioExperience
                 {
                     Id = "SoldaderaCoffee",
                     ProjectName = new MarkupString("Soldadera Coffee"),
                     ValueProposition = new MarkupString("Freelance project for coffee cold brew company."),
                     TechStack = new MarkupString("JS, HTML, CSS"),
                     ProjectLink = "https://soldaderacoffee.com/",
                     GitHubRepoLink = "",
                     ImageOrVideoLink = "/Images/SoldaderaCoffee.png",
                     IsVideo = false,
                     Description = new MarkupString(@"
                    <p>Soldadera is a coffee coldbrew company from the midwest that dedicates some of its resources into empowering women.</p>
                    <p>This is a website I made for this company. The website showcases a lot of their presence in the media, provides a means for customers to purchase products and also the ability to create blogs</p>
                    ")
                 });

            PortfolioExperiences.Add(
                 new PortfolioExperience
                 {
                     Id = "GameOfLife",
                     ProjectName = new MarkupString("Conway's Game Of Life"),
                     ValueProposition = new MarkupString("Conway's Game Of Life implemented in vanilla JS"),
                     TechStack = new MarkupString("JS, HTML, CSS"),
                     ProjectLink = "https://github.com/joe-gregory/Conways-Game-of-Life",
                     GitHubRepoLink = "https://github.com/joe-gregory/Conways-Game-of-Life",
                     ImageOrVideoLink = "https://www.youtube.com/embed/txiGKpUh8QY",
                     IsVideo = true,
                     Description = new MarkupString(@"
                    <p>I am a big fan of Conway's Game of Life, cellular automata and Stephen Wolframs work. This is an implementation I made of Conways Game of Life in vanilla JS.</p>
                    <p>It can readily be added to any website.</p>
                    <p><strong>Instructions to implement: </strong>there is an object constructor function that can be used to create the object that runs the simulation. Optional parameters are:
                    gameOfLife = new makeGame(rows, columns, counterLabel, ms)</p>
                    <p>Rows and columns expects an integer value for the size of the table. They default to 5 and 10, respectively. counterLabel is the text that appears next to the generations counter. It defaults to 'Generation: ' ms represents the milliseconds between updating the table. It defaults to 300.</p>
                    <p>Afterwards, call createandRender() on your new object.</p>
                    ")
                 });

            PortfolioExperiences.Add(
                 new PortfolioExperience
                 {
                     Id = "Alegra",
                     ProjectName = new MarkupString("Alegra Dental Care"),
                     ValueProposition = new MarkupString("Alegra Dental Care Orthodontist"),
                     TechStack = new MarkupString("JS, HTML, CSS"),
                     ProjectLink = "https://alegradentalcare.com/",
                     GitHubRepoLink = "",
                     ImageOrVideoLink = "/Images/Alegra.png",
                     IsVideo = false,
                     Description = new MarkupString(@"
                    <p>Alegra Dental Care is a freelance website I made for a dental office. The dental office offers restorative dentristry, orthodontics and smile design. Through the website, patients can book appointments.</p>")
                 });

            PortfolioExperiences.Add(
                 new PortfolioExperience
                 {
                     Id = "Gasi",
                     ProjectName = new MarkupString("Gasi"),
                     ValueProposition = new MarkupString("Freelance work for startup developed Android app and IoT MVP."),
                     TechStack = new MarkupString("Python, Kivy"),
                     ProjectLink = "",
                     GitHubRepoLink = "https://github.com/joe-gregory/Gasi-B1/",
                     ImageOrVideoLink = "/Images/Gasi.jpg",
                     IsVideo = false,
                     Description = new MarkupString(@"
<p>From my experience in consumer product development, I was hired to developed an MVP of a consumer device meant to measure the gas level in lp home tanks.</p>
<p>I developed an Android application that communicated with an IoT device that connected to the lp gas tank. I developed the application using Python and <a class='description-link' href='https://kivy.org/'>Kivy</a>, the open source Python app development framework.</p>
<p>A magnet was attached to a lp gas dial. I designed and 3D printed an attachment for the dial where a hall effect sensor was placed to read the displacement of the magnet as the dial moved. This sensor was connected to an Arduino Nano IoT board that later communicated the strength measured by the hall effect sensor to a backend. The readings were forwarded to the Android application.</p>
")
                 });

            PortfolioExperiences.Add(
                 new PortfolioExperience
                 {
                     Id = "Egr409",
                     ProjectName = new MarkupString("EGR 409 GVSU Machine Design"),
                     ValueProposition = new MarkupString("GUI to size mechanical components (shafts, screws, clutches, brakes, belts, gears, etc) for a mechanical engineering course at GVSU"),
                     TechStack = new MarkupString("Python, PySide, PyQt"),
                     ProjectLink = "",
                     GitHubRepoLink = "https://github.com/joe-gregory/EGR-409",
                     ImageOrVideoLink = "/Images/Egr409.PNG",
                     IsVideo = false,
                     Description = new MarkupString(@"
<p>EGR 409 is one of the final courses of the mechanical engineering curriculum at Grand Valley State University. Topics include design of screws, clutches, brakes, belts, gears, journal bearings, roller bearings, and planetary gear trains.</p>
<p>As the course advances, it focuses on design of mechanical systems. This GUI allows you to quickly select the size of bearings, shafts, etc. based on machine specs.</p>
<p>The GUI was built for Windows using Python and <a class='description-link' href='https://pypi.org/project/PySide/'>PySide</a> which provides Python bindings for the Qt cross-platform application and UI framework.</p>
")
                 });
        }

    }
}
