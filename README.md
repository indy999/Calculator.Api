# Calculator.Api

This is the repository for building a basic calculator API.

# Project information

This is an .NET Core 6 API using NUnit and the in built Visual Studio Test runner.  This was build using Visual Studio 2022.

## Delivered Artifacts

- The Payment Gateway API has four calculator endpoints that can be reached at `https://localhost:7262/api/math/`
- There is swagger documentation which can be accessed by launching the API locally at `https://localhost:7262/swagger/index.html`

## Considerations/Assumptions

For the code and library architecture I have decided to include a traditional n-tier architecture with controller and service layer.  This is instead of a minimal API design which is supported now by .NET 6.  This is so we can discuss the pros and cons in interview.

## Application Logging and Error Handling

I used Serilog as a logging implementation writing to a log file.  I also have a global exception logging mechanism.  Thus keeping the main controller and service logic lean.

By default exceptions would return the 500 status code. I have a try catch around the application start up and logging any exceptions.

## Authentication and Security

The authentication mechanism here is used is a simple API key mechanism and would be more secure and is passed in the Authorization header in this implementation.  In a real world environment I would consider something more secure such as OAuth and private key via an identity provider e.g. Azure AAD.
