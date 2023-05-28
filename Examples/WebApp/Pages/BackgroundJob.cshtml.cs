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
        BackgroundJobs.Enqueue<TestJobsService>(service => service.Wait(20));
    }
}
