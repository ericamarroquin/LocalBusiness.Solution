# Local Businesses

### _This application will list restaurants and shops in a town_

### By Erica Marroquin

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySQL
* MySQL Workbench
* Swagger

## Description

This application utilizes a RESTful API "LocalBusiness" to list restaurants and shows in a town. "LocalBusiness" has GET, POST, PUT, and DELETE endpoints.

## API Endpoints



## Setup/Installation Requirements

### Installation Requirements
* [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-macos-x64-installer) must be installed for this project
* [MySQL](https://dev.mysql.com/downloads/) will be used for this project
  - MacOS must download [MySQL Community Server](https://dev.mysql.com/downloads/mysql/) and [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)
  - Windows can use [MySQL Web Installer](https://dev.mysql.com/downloads/installer/) to download both MySQL Community Server and MySQL Workbench

### Setup Instructions
* Clone this repository to desired location using `git clone` command
* Navigate to PierresTreats.Solution/PierresTreats
* Create an `appsettings.json` file in PierresTreats.Solution/PierresTreats
  - Open `appsettings.json` and add the following code, changing [YOUR-USERNAME-HERE] and [YOUR-PASSWORD-HERE] to your unique MySQL username and password, respectively:
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=erica-marroquin;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

### Create and update database
* Navigate to PierresTreats.Solution/PierresTreats
* Run the command `dotnet restore` to install all necessary packages
* Run the command `dotnet ef database update`
  - This will use the already existing "Migrations" folder to create the database

### Running the application
* To run the application, navigate to PierresTreats.Solution/PierresTreats
  - Run the command `dotnet run`
  - If a host does not automatically show in your browser, enter, in your browser, the URL given in the console message when starting `dotnet run` from the previous step

## Known Bugs

* Same flavor can be added to treat multiple times 

## License

[MIT License](https://opensource.org/licenses/MIT)

## Contact Information

Erica Marroquin | [Email](mailto:ericamarroquin03@gmail.com) | [LinkedIn](https://www.linkedin.com/in/erica-marroquin/)