using EnqueueIt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class ScheduleJobModel : PageModel
{
    private readonly ILogger<ScheduleJobModel> _logger;

    public ScheduleJobModel(ILogger<ScheduleJobModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        BackgroundJobs.Schedule<TestJobsService>(service => service.Wait(10), DateTime.Now.AddSeconds(30));
    }
}
