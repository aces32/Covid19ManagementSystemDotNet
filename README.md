# COVID-19 PCR test management system

this management system that will help the government to manage and process requests for PCR tests

## Architecture Used

Clean Architecture (.Net core 5.0).

```python
Code Structure

#Src
  - #API
     - COVID-19PCR.TestManagement.Api (API Endpoint)
  - #Core
     - COVID-19PCR.TestManagementI.Application (Application Logic - implemented in the features folder) 
     - COVID-19PCR.TestManagement.Domain (Database Model)
  - #Infrastructure
     - COVID-19PCR.TestManagement.Infrastructure (Logging, Mail e.t.c...)
     - COVID-19PCR.TestManagement.Persitence (Database Repository, dbcontext and logic)
#test
     - COVID-19PCR.TestManagement.IntegrationTests
     - COVID-19PCR.TestManagement.UnitTests

```

## Technologies Used

```python
# COVID-19PCR.TestManagement.API
- Swagger for API documentation
- Mediatr - sends a request to the application logic via Irequest Handler

# COVID-19PCR.TestManagement.Application
- Automapper
- FluentValidation - Api requests validations
- Mediatr - Receives requests from the API and carries out appropriate implementation

# COVID-19PCR.TestManagement.Domain
- Ef core

# COVID-19PCR.TestManagement.Infrastructure
- SendGrid
- Serilog for logging

# COVID-19PCR.TestManagement.Persitence
- Ef Core

# COVID-19PCR.TestManagement.IntegrationTests
- xunit
- Ef Core inmemory

# COVID-19PCR.TestManagement.UnitTests
- Xunit
- Moq
- Shouldly
``` 

## Assumptions Made
```python
# An individual can only book for a covid test once and can rebook once he/she cancels
# An administrator cannot make multiple booking for the same locations at the same date

```

## Database Structure
![image](https://user-images.githubusercontent.com/29570486/137643679-43297396-2778-4d2c-ae67-48f28ae084a3.png)

```

