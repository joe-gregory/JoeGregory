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
                    ValueProposition = new MarkupString("Self taught C# developer with a mechanical engineering background. Teamplayer, responsible, dedicated."),
                    TechStack = new MarkupString("C#, JavaScript, Python, Sql, NoSql"),
                    ProjectLink = "https://www.linkedin.com/in/josephegregory/",
                    GitHubRepoLink = "https://github.com/joe-gregory",
                    ImageOrVideoLink = "/Images/conNatalia.jpg",
                    IsVideo = false,
                    Description = new MarkupString(@"
                    <p>Hi, my name is Joseph Gregory. Welcome to my porfolio page built with <a class='description-link' href='https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor'>.Net C# Blazor</a>, <a class='description-link' href='https://mudblazor.com/'>MudBlazor components</a> and some personally built (for example, the component that allows videos inside MudCards). I originally went majored in Mechanical engineering at Grand Valley State University in Michigan. 
                    Throughout my mechanical engineering career, I worked developing new innovative consumer products such as  <a class='description-link link-primary' href='https://www.whirlpoolcorp.com/whirlpool-corporation-debuts-new-zera-food-recycler-on-indiegogo/'>Zera</a>
                    and I also worked in manufacturing helping automate industrial processes such as CM Industry's <a class='description-link' href='https://cmindustryinc.com/innovation/'>steel pallets</a> production line </p>
                    <p>I've always had an inclination for programming and a deep curiosity for learning the many many layers that make computers work. I built my first website
                    back in the days when you could get AOL cds on cereal boxes and I worked on many hobby projects along the way.</p>
                    <p>During my mechanical engineering degree, many of my projects I decided to work on were software based including a <a class='description-link' href='https://www.gvsu.edu/engineering/carlson/feht/download'>Finite Element Heat Transfer</a> simulator (written with Python and PyQt) GUI that I gave to the school for their FEHT course in the ME program. 
                    I've developed websites and programmed microcontrollers and prototypes as a freelancer for startups.</p>
                    <p>While I don't regret the path I've taken, it became clear to me later in life that programming and computers is what I am most passionate about. I may have not gone to school 
                    for computer science but studying it from the outside and from a different background gave me an opportunity for a different perspective. </p>
                    <p>I am currently looking for a role as a C# developer. I really like the ecosystem that Microsoft has built with .Net and its many applications. I would like to 
                    grow a long career in this ecosystem. I hope you can consider giving me an opportunity. I consider myself a hard worker, team player, and self-learner. I look forward to bringing value to your team and company while learning from you.
                    Please take a look around my porftolio page (built using Blazor) and feel free to contact me if you have any questions.</p>
                    <p>You can contact me using the contact form on the footer or by using the convenient buttons to copy my contact information on the same form.</p>
                    ")
                }
            );

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
                    <p>I built Study Stacks a C# .Net <a class='description-link' href='https://learn.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-7.0&tabs=visual-studio'>Razor pages</a> project. Razor pages allows you to take a page-focus approach to building a web application.</p>
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
                    <p>The goal of Plugin Democracy is to eliminate the bottlenecks that our current political system introduces. A political system is like any other machine. Its components can be analized to find its inefficiencies. Many political problems, such as corruption, can have a technical solution by open-sourcing the control of public administration and forcing transparency.</p>
                    <p>The application is currently in used in <a class='description-link' href=''>gated communities</a> in Mexico where it has helped them organize to enact ordenances and make improvements to public spaces.</p>
                    <p>I will be submitting Plugin Democracy to <a class='description-link' href='https://www.ffwd.org/'>fastforward</a> at the end of 2023 where I hope to gather more contributors for the project.</p>
                    <p>The next features that I plan on implemeting in the near future are related to the management of a community's accounting by its residents which includes the approval/rejection of public spending democratically in projects and administrator roles. However, as the code base is growing, I plan to refactor the project into C# starting with the backend before implementing these new features. I believe a strongly typed language like C# becomes very useful as the code base grows. I will evaluate if I will keep the frontend in React or if I will migrate to Blazor. However, I will developed the mobile applications (and possibly desktop applications for accountants and such) within the .Net ecosystem.</p>
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
                    <p>Rows and columns expects an integer value for the size of the table. They default to 5 and 10, respectively. counterLabel is the text that appears next to the generations counter. It defaults to 'Generation: ' ms represents the milliseconds between updating the table. It defaults to 300. ms is the time between rendering generations.</p>
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
<p>I developed an Android application that communicated with with an IoT device that connected to the lp gas tank. I developed the application using Python and <a class='description-link' href='https://kivy.org/'>Kivy</a>, the open source Python app development framework.</p>
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
<p>As the course starting focusing on sizing mechanical components, I built a GUI to quickly go through the process of determining sizing and specs for components.</p>
<p>The GUI was built for Windows using Pythong and <a class='description-link' href='https://pypi.org/project/PySide/'>PySide</a> which provides Python bindings for the Qt cross-platform application and UI framework.</p>
")
                 });
        }

    }
}
