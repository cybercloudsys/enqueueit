public class TestJobsService
{
    private readonly ILogger<TestJobsService> _logger;
    public TestJobsService(ILogger<TestJobsService> logger)
    {
        _logger = logger;
    }

    public void Wait(int seconds)
    {
        _logger.LogInformation("Job started");
        Task.Delay(seconds * 1000).Wait();
        _logger.LogInformation("Job completed");
    }
}