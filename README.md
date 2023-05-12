![image](https://github.com/ameyvaidya/AzureFunctionsPostgresqlTemplate/assets/5148671/de8c5a31-0efa-4b75-aca6-0155461d5fbe)

# Azure Function with Postgresql Solution Template

## Motivation
If you are using .NET chances are your project or organization will ask you to write azure function. While its relatively easy to start with SQL server, for PostgreSQL you need to some minimum amount of configuration at least.
Doing this repetitively is just waste of time. This repository aims to add basic features as well as some of the advanced features.


## Features (Done vs In-progress)
1. .NET 6 support  :white_check_mark:
2. Queue trigger :white_check_mark:
3. Postgre SQL using Entity framework :white_check_mark:
4. Queue message uses UTF-8 using latest Storage queue library :white_check_mark:
5. Azure Keyvault support
6. Single message at a time mode - Configure Azure function in such way that it will only fetch one message from queue then move on to next one. (Optional settings) :white_check_mark:
7. Serilog sink - Application Insights
