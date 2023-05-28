using EnqueueIt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class BackgroundJobModel : PageModel
{
    private readonly ILogger<BackgroundJobModel> _logger;

    public BackgroundJobModel(ILogger<BackgroundJobModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Microservices.Enqueue("microservice1", new { Message = "Hello from first service" });
        BackgroundJobs.Enqueue(() => Thread.Sleep(100));
    }
}
