using EnqueueIt;
using Microsoft.Extensions.Logging;

class Program
{
    static void Main(string[] args)
    {
        //setup the app to be able to enqueue the jobs
        GlobalConfiguration.Current.Configuration 
            .LoadFromFile() // load EnqueueIt configs from EnqueueIt.json file
            .UseRedisStorage() // connect the redis server
            .UseSqlServerStorage(); // connect to sql server database

        // create console logger for this app
        using var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        ILogger logger = loggerFactory.CreateLogger<Program>();
        // add enqueueit logging to this app logger
        loggerFactory.ConfigureEnqueueIt();

        // Register a recurring job every 5 seconds.
        BackgroundJobs.Subscribe("Show Time", () => PrintTime(), RecurringPattern.EverySeconds(5));

        // Enqueue a job to run as soon as possible in the background
        BackgroundJobs.Enqueue(() => Console.WriteLine("First job."));

        Servers.Start(); // start the jobs server
    }

    public static void PrintTime()
    {
        Task.Delay(2000).Wait(); //let the job wait 2 seconds
        Console.WriteLine($"Performed at: {DateTime.Now.ToLongTimeString()}");
    }
}