namespace Portfolio.Pages;

public partial class Home
{
    private Dictionary<string, string> languages = new() {
        {"C#", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/csharp/csharp-original.svg"},
        {"C", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/c/c-original.svg"},
        {"Java", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/java/java-original.svg" },
        {"Zig", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/zig/zig-original.svg"},
        {"Python", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/python/python-original.svg"},
        {"HTML", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/htmx/htmx-original.svg"},
        {"CSS", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/css3/css3-original.svg"}
    };

    private Dictionary<string, string> cloud = new()
    {
        {"Azure", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/azure/azure-original.svg"},
        {"Terraform", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/terraform/terraform-original.svg"},
        {"Docker", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/docker/docker-plain.svg"},
        {"DevOps", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/azuredevops/azuredevops-original.svg"},
        {"Git", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/git/git-original.svg"}
    };

    private Dictionary<string, string> frameworks = new()
    {
        {"ASP.NET CORE (Blazor)", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/dotnetcore/dotnetcore-original.svg"}
    };

    private Dictionary<string, string> tools = new()
    {
        { "Linux (Bash)", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/linux/linux-original.svg" },
        { "MAMP", "" }, 
        { "PostgreSQL", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/postgresql/postgresql-original.svg" },
        { "Postman", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/postman/postman-original.svg" },
        { "Swagger", "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/swagger/swagger-original.svg" }, // decent fallback
        { "Power Automate", "" }
    };


}