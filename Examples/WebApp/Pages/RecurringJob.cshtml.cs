using EnqueueIt;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recur;

namespace WebApp.Pages;

public class RecurringJobModel : PageModel
{
    private readonly ILogger<ScheduleJobModel> _logger;

    public RecurringJobModel(ILogger<ScheduleJobModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        BackgroundJobs.Subscribe<TestJobsService>("Waiting", service => service.Wait(10), RecurringPatterns.EverySeconds(25));
    }
}
