namespace Portfolio.Components;

using Markdig;
using Microsoft.AspNetCore.Components;

public partial class WorkTimeline
{
    private string sdMarkdown = """
        **Software Developer Intern** ||  *Northwestern Medicine*

        * Creating responsive front-end Razor components with custom CSS for Blazor app to help automate resource provisioning and streamline dev project setup for over 1000 employees.
        * Deploying custom Azure modules and APIM resources to the cloud using Terraform plans and Swagger, enabling reliable infrastructure via IaC and regulation for internal and external vendor API access.
        * Developing a Razor killswitch component and RESTful .NET Core API call to automate Azure API resource deallocation and ServiceNow change requests, eliminating manual workflows.
        * Participating in an Agile DevOps environment, running CI/CD pipelines, and contributing to the SDLC.
        """;

    private MarkupString HtmlContent =>
        new MarkupString(Markdown.ToHtml(sdMarkdown));
}