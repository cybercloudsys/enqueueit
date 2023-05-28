# Enqueue It
Easy and scalable solution for managing and executing background tasks and microservices seamlessly in .NET applications. It allows you to schedule, queue, and process your jobs and microservices efficiently.

Designed to support distributed systems, enabling you to scale your background processes and microservices across multiple servers. With advanced features like performance monitoring, exception logging, and integration with various storage types, providing complete control and visibility over your workflow.

Provides a user-friendly web dashboard that allows you to monitor and manage your jobs and microservices from a centralized location. You can easily check the status of your tasks, troubleshoot issues, and optimize performance.

## Benefits and Features
- Schedule and queue background jobs and microservices
- Run multiple servers for increased performance and reliability
- Monitor CPU and memory usage of microservices
- Log exceptions to help find bugs and memory leaks
- Connect to multiple storage types for optimal performance:
  - Main storage (Redis) for active jobs and services
  - Long-term storage (SQL databases such as SQL Server, PostgreSQL, MySQL, and more) for completed jobs and job history
- Web dashboard for monitoring jobs and microservices

## Packages

EnqueueIt is available for both .NET and Go. You can find the respective packages at the following links:

- [.NET Packages](https://github.com/cybercloudsys/enqueueit-dotnet)
- [Go Package](https://github.com/cybercloudsys/enqueueit-go)

As of version 0.3.0, the .NET packages support all EnqueueIt functionality, including the web dashboard and background jobs, which are exclusively available in the .NET package. The Go package was created as a lightweight alternative for running the EnqueueIt server, enabling the execution of microservices and seamless data synchronization between Redis and SQL databases. Additionally, the Go package supports the enqueueing and scheduling of microservices from Go, as well as the feature of reading microservice arguments.

## Links

- [Homepage](https://www.enqueueit.com)
- [Examples](https://github.com/cybercloudsys/enqueueit/tree/master/Examples)

## License

EnqueueIt\
Copyright © 2023 [Cyber Cloud Systems LLC](https://www.cybercloudsys.com)

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as
published by the Free Software Foundation, either version 3 of the
License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.

Any user of this program who modifies its source code and distributes
the modified version must make the source code available to all
recipients of the software, under the terms of the license.

If you have any questions about this agreement, You can contact us
through this email info@cybercloudsys.com