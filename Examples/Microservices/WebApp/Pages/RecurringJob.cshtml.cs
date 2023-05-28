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
        Microservices.Subscribe("Hello1", "microservice1",
            new { Message = "Hello from first service every 30 seconds" },
            RecurringPatterns.EverySeconds(30));
        BackgroundJobs.Subscribe("Hello2", () => Thread.Sleep(5),
            RecurringPatterns.EverySeconds(30));
    }
}
