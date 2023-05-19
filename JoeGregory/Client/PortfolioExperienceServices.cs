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
                    <p>Hi, my name is Joseph Gregory. I originally went to school and majored in Mechanical engineering. 
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
        }

    }
}
