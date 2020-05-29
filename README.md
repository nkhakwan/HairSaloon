# _Claire Hair Saloon Clients and Stylists Database_

#### _Epicodus Week11 Friday Review Project_

#### By _**Khan Sahab**_

## Description

_A web site that allows Clair to add clients and Stylists to her Website and also link clients with their Stylists. More than one Clients can be linked to a stylists but only one Stylists is allowed per client. This website allows to delete and Edit both the clients and Stylists _

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the commands dotnet restore, dotnet build, and dotnet run.
5. CREATE DATABASE `nauman_khakwani`
6. Tables: They are included in separate nauman_khakwani.sql file too, present in the root of the directory
7. 
CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `StylistId` int NOT NULL,
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

8. 
CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Skills` varchar(255) DEFAULT NULL,
  `StylistName` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



## Known Bugs
 
None. Both Basic and additional requirements of Delete and Edit have been fulfilled.
 
## Support and contact details

_Have a bug or an issue with this application? Email post_khan@yahoo.com_

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* MSBuild
* Razor
* Git and GitHub
* mysql database
* Entity

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User can add clients by clicking add new clients** | User Input:"add client” | Output: " Name of the client displayed with his/her stylists and with stylists skills" |
| **User can view a particular client** | User Input:”click on a particular client” | Output: "Name of that client is displayed. For now no other property like addresses etc were added" |
| **User can add stylists by clicking add new stylists** | User Input:"add a new stylist” | Output: " Name of the Stylist with skill included in the displayed list" |


### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Khan Sahab_**