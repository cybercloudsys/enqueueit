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
        Microservices.Schedule("microservice1",
            new { Message = "Scheduled hello from first service" },
            DateTime.Now.AddSeconds(30));
        BackgroundJobs.Schedule(() => Thread.Sleep(5), DateTime.Now.AddSeconds(30));
    }

    public void Hello()
    {
        Thread.Sleep(1000);
    }
}
