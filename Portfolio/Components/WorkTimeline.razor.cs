namespace Portfolio.Components;

using Markdig;
using Microsoft.AspNetCore.Components;

public partial class WorkTimeline
{
    private string sdMarkdown = """
        * Collaborated in an agile dev team to launch MVP 1, building .NET Razor UI components, implementing backend API controllers, provisioning Azure Cosmos DB containers and services for DTO management.
        * Deploying custom Azure modules and APIM resources to the cloud using Terraform plans and Swagger, enabling reliable infrastructure via IaC and regulation for internal and external vendor API access.
        * Developing a Razor killswitch component and RESTful .NET Core API call to automate Azure API resource deallocation and ServiceNow change requests, eliminating manual workflows.
        * Participating in an Agile DevOps environment, running CI/CD pipelines, and contributing to the SDLC.
        """;

    private string rsMarkdown = """
        * Worked alongside professor to migrate core components of a multichannel secret sharing protocol from C to Zig, leveraging Zig’s modern safety and concurrency features to enhance performance and maintainability.
        * Utilized stream libraries to implement message sharing across machines versus across ports.
        * Implemented custom multithreading iPerf tests to benchmark and improve sharing speeds and throughput by 10x.
        """;

    private string atMarkdown = """
        * Developed Power Automation to retrieve and store requests from ServiceNow in Dataverse, and created a custom Power App to support CRUD operations, enhancing tracking efficiency for the team and manager. App still currently in prod and is used in all shareholder meetings.
        * Developed within a team, a Power Page frontend for technicians to monitor app health and assisted backend team with data retrieval automations.
        """;

    private string itMarkdown = """
        * Met expectations with high volume tickets by closing over 250 tickets that varied from user onboards, network failures, hardware issues, etc.
        * Redesigned company's form workflows-resulting in cost savings of tens of thousands of dollars from the previous service provider, by self-teaching Power Automate.
        * Interacted frequently with both STERIS and Hu-Friedy’s Active Directory as well as Azure and other Cloud services.
        * Collaborated seamlessly in a team-oriented IT environment, maintaining consistent communication across team members.
        """;
    private MarkupString HtmlContent =>
        new MarkupString(Markdown.ToHtml(sdMarkdown));

}