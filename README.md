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

## Setup/Installation Requirements

### Installation Requirements
* [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-macos-x64-installer) must be installed for this project
* [MySQL](https://dev.mysql.com/downloads/) will be used for this project
  - MacOS must download [MySQL Community Server](https://dev.mysql.com/downloads/mysql/) and [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)
  - Windows can use [MySQL Web Installer](https://dev.mysql.com/downloads/installer/) to download both MySQL Community Server and MySQL Workbench

### Setup Instructions
* Clone this repository to desired location using `git clone` command
* Navigate to LocalBusiness.Solution/LocalBusiness
* Create an `appsettings.json` file in LocalBusiness.Solution/LocalBusiness
  - Open `appsettings.json` and add the following code, changing [YOUR-USERNAME-HERE] and [YOUR-PASSWORD-HERE] to your unique MySQL username and password, respectively:
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=erica-marroquin;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

### Create and update database
* Navigate to LocalBusiness.Solution/LocalBusiness
* Run the command `dotnet restore` to install all necessary packages
* Run the command `dotnet ef database update`
  - This will use the already existing "Migrations" folder to create the database

### Running the API
* To run the API, navigate to LocalBusiness.Solution/LocalBusiness
  - Run the command `dotnet run`
  - Follow the below API endpoints to query the database

## Using Swagger
Swagger allows a user to view API endpoints in the browser. For the purpose of this API, Swagger allows the user to complete GET, POST, PUT, and DELETE requests all while using the Swagger interface. To use, click on the request you'd like to complete and the panel will expand. The available parameters and responses will be shown. To perform the request, click on "Try it out" in the top right corner of the panel and enter any needed parameters. Click "Execute" and the server response code and response body will show.

For a GET request, entered parameters will be used to search the database for matching parameters. Not all parameters have to be entered for the request to complete. For a POST or PUT request, a request body will show when "Try it out" is clicked, where the user will directly edit the JSON parameters to be changed. For a DELETE request, only an ID parameter is needed to complete the request.

At the bottom of the page in the "Schemas" panel, all schemas created when using this API will be shown. For the purpose of this API, the only schema created is the Business schema.

## API Endpoints

Base URL: `http://localhost:5000`

### HTTP Requests for Businesses

```c#
GET /api/Business
POST /api/Business
PUT /api/Business
GET /api/Business/{id}
DELETE /api/Business/{id}
```

### Example Query

```
http://localhost:5000/api/Business/2
```

### Path Parameters
|  Parameter   | Type   | Required | Description                     |
|  ----------- | ------ | -------- | ------------------------------- |
| name         | string | true     | Return matches by name          |
| businessType | string | true     | Return matches by business type |
| phone        | string | true     | Return matches by phone number  |

### Example Query for Searching by Parameter
```
http://localhost:5000/api/Business/?name=viva
```

### JSON Body for POST and PUT Requests
When querying a POST or PUT request, a JSON body is needed to add or edit information in the database, respectively. Use the following JSON body to do so.

```json
  {
    "businessId": {id},
    "name": "string",
    "businessType": "string",
    "phone": "string"
  }
```

## Known Bugs

* No known issues

## License

[MIT License](https://opensource.org/licenses/MIT)

## Contact Information

Erica Marroquin | [Email](mailto:ericamarroquin03@gmail.com) | [LinkedIn](https://www.linkedin.com/in/erica-marroquin/)