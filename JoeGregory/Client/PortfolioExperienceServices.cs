using Microsoft.AspNetCore.Components;

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
                    <p>Hi, my name is Joseph Gregory. Welcome to my porfolio page built with <a class='description-link' href='https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor'>.Net C# Blazor</a> and used some <a class='description-link' href='https://mudblazor.com/'>MudBlazor components</a> as well as built my own. I originally went to school and majored in Mechanical engineering at Grand Valley State University in Michigan. 
                    Throughout my mechanical engineering career, I worked developing new innovative consumer products such as  <a class='description-link link-primary' href='https://www.whirlpoolcorp.com/whirlpool-corporation-debuts-new-zera-food-recycler-on-indiegogo/'>Zera</a>
                    and I also worked in manufacturing helping automate industrial processes such as developing CM Industry's <a class='description-link' href='https://cmindustryinc.com/innovation/'>steel pallets</a> production line </p>
                    <p>I've always had an inclination for programming and a deep curiosity for learning the many many layers that make modern computers work. I built my first website
                    back in the days when you could get AOL cds on cereal boxes and I worked on many hobby projects along the way.</p>
                    <p>During my mechanical engineering degree, many of my projects were software based including a <a class='description-link' href='https://www.gvsu.edu/engineering/carlson/feht/download'>Finite Element Heat Transfer</a> simulator (written with Python and PyQt) GUI that I gave to the school for their FEHT course in the ME program. 
                    I've developed websites as a freelancer along the way and programmed microcontrollers and other prototypes for startups.</p>
                    <p>While I don't regret the path I've taken, it became clear to me later in life that this is what I enjoyed doing the most. I may not have gone to school 
                    for computer science but studying it from the outside and from a different background gave me an opportunity for a different perspective. </p>
                    <p>I am currently looking for a role as a C# developer. I really like the ecosystem that Microsoft has built for .Net and its many applications. I would like to 
                    grow a long career in this world. I hope you can consider giving me an opportunity. I consider myself a hard worker, team player, and self-learner. I look forward to bringing value to your team and company while learning from you.
                    Please take a look around my porftolio page (built using Blazor) and feel free to contact me if you have any questions.</p>
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
                    <p>Students can create account, stacks, and study sessions that follow a particular order or are random, collecting metrics of their results along the way.</p>
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
                    <p>The goal of Plugin Democracy is to eliminate the bottlenecks that our current political system introduces. A political system is like any other machine. Its components can be analized to find its bottlenecks and inefficiencies. Many political problems, such as corruption, can have a technical solution by open-sourcing the control of public administration and forcing transparency.</p>
                    <p>The application is currently in used in <a class='description-link' href=''>gated communities</a> in Mexico where it has helped them organize to enack ordenances and make improvements to public spaces.</p>
                    <p>I will be submitting Plugin Democracy to <a class='description-link' href='https://www.ffwd.org/'>fastforward</a> at the end of 2023 where I hope to gather more contributors for the project.</p>
                    <p>The next features that I plan on implemeting in the near future are around the management of a community's accounting by its residents which includes the approval/rejection of public spending democratically in projects and administrator roles. However, as the code base is growing, I plan to refactor the project into C# starting with the backend before implementing these new features. I believe a strongly typed language like C# becomes very useful as the code base grows. I will evaluate if I will keep the frontend in React or if I will migrate to Blazor. However, I will developed the phone applications (and possibly desktop applications for accountants and such) within the .Net ecosystem.</p>
                    <p>If you have any more questions about the project, please reach out to me!</p>
                    ")
                 });
        }

    }
}
