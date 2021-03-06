# Book Collection
Book Collection is a REST API server for a collection of books.

## Setup
Book Collection requires the following programs:
* .Net Core Runtime 3.1.4
* .NET Core CLI
* Docker
* dotnet-ef

Clone this repo to your desired location and move into that directory.

Install the Microsoft SQL Server on Linux image:
```shell
docker pull mcr.microsoft.com/mssql/server:2017-latest
```

Create a container for the SQL server:
```shell
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Your_password123" \
-p 1433:1433 --name BookCollection \
-d mcr.microsoft.com/mssql/server:2017-latest
```

Navigate to the BookCollection project:
```shell
cd server/src/BookCollection
```

Update the database:
```shell
dotnet ef database update
```

Run the server:
```shell
dotnet run
```

The server will now be running on localhost:5001. The REST API can be found at 
/api/books while the web app can be found at /index.html.

## Testing
To run all tests, run the following inside the server directory:
```shell
dotnet test
```

## Usage
To run the REST API server, run the following command inside the 
server/src/BookCollection directory:
```shell
dotnet run
```

