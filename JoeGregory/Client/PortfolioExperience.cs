using Microsoft.AspNetCore.Components;

namespace JoeGregory.Client
{
    public class PortfolioExperience
    {
        public string Id { get; set; }
        public MarkupString ProjectName { get; set; }
        public MarkupString ValueProposition { get; set; }
        public MarkupString TechStack { get; set; }
        public string ProjectLink { get; set; } = "";
        public string GitHubRepoLink { get; set; } = "";
        public string ImageOrVideoLink { get; set; } = "";
        public bool IsVideo { get; set; } = false;
        public MarkupString Description { get; set; }

    }
}
