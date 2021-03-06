# _Pierre's Sweet and Savory Treats_

#### _Epicodus Project - Last Updated June 5, 2020_

#### By _**Matt Stroud**_

## Description

_An Epicodus individual project focused on creating a RESTful MVC C# app connected to a MySQL database._  
_The user will be able to view all treats and their corresponding flavors, as well as flavors and their corresponding treats._  
_After the user registers, they will have access to create, update, and delete treats and flavors._


## Specs
### User Stories
* As a user, I want to be able to view all treats and flavors.
* As a user, I want to be able to view all flavors of a specific treat.
* As a user, I want to be able to view all treats that have a specific flavor.
* As a logged in user, I want to be able to create new flavors and treats.
* As a logged in user, I want to be able to update/edit existing flavors and treats.
* As a logged in user, I want to be able to delete existing flavors and treats.

### Behaviors
| Behavior                                                   | Input                            | Output                                 |
|:-----------------------------------------------------------|:---------------------------------|---------------------------------------:|
| Program will allow user to view all favlors and treats     | Visits Splash Page               | Display all flavors & treats           |
| Program will allow user to view all flavors for a treat    | Visits treats/treatId            | Display all flavors for treatId        |
| Program will allow user to view all treats for a flavor    | Visits flavors/flavorId          | Display all treats for flavorId        |
| Program will allow user to register                        | Visits Register Page             | Display user registration form         |
| Program will allow user to log in                          | Visits Log In Page               | User is logged in                      |
| Program will allow user to log out                         | Clicks log out                   | User is logged out                     |
| Program will allow user to create a new treat              | Visits /treats/create            | Display treat create form              |
| Program will allow user to create a new flavor             | Visits /flavors/create           | Display flavor create form             |
| Program will allow user to edit an existing treat          | Visits /treats/treatId/edit      | Display edit form for treatId          |
| Program will allow user to edit an existing flavor         | Visits /flavors/flavorId/edit    | Display edit form for flavorId         |
| Program will allow user to delete an existing treat        | Visits /treats/treatId/delete    | Display confirmation button            |
| Program will allow user to delete an existing flavor       | Visits /flavors/flavorId/delete  | Display confirmation button            |

### RESTful Routing
| Path                     | Route          | Method |
|:-------------------------|:---------------|-------:|
| /                        | Home->Index    | GET    |
| /Flavors/Create          | Flavors->Create | GET    |
| /Flavors/Create          | Flavors->Create | POST    |
| /Flavors/Details/{id}    | Flavors->Details | GET, POST   |
| /Flavors/Edit/{id}      | Flavors->Edit  | GET, POST   |
| /Flavors/Delete/{id}       | Flavors->Delete    | GET, POST   |
| /Flavors/AddTreat/{id}         | Flavors->AddTreat | GET, POST |
| /Flavors/DeleteTreat | Flavors->DeleteTreat | POST |
| /Treats/Create          | Treats->Create | GET    |
| /Treats/Create          | Treats->Create | POST    |
| /Treats/Details/{id}    | Treats->Details | GET, POST   |
| /Treats/Edit/{id}      | Treats->Edit  | GET, POST   |
| /Treats/Delete/{id}       | Treats->Delete    | GET, POST   |
| /Treats/AddFlavor/{id}         | Treats->AddFlavor| GET, POST |
| /Treats/DeleteFlavor | Treats->DeleteFlavor | POST |
| /Account/Register    | Accounts->Register | GET, POST |
| /Account/Login       | Accounts->Login    | GET, POST |
| /Account/Logout      |Account -> Logout   | POST |

### Stretch Goals
* Add User Role based functionality.
* Add Order form for logged in users.

## Setup/Installation Requirements
> This application requires the .NETCore SDK - [Find your version here](https://dotnet.microsoft.com/download/dotnet-core/2.2)

1. Create a SweetSavory.Solution directory.
```
mkdir SweetSavory.Solution
```
2. Navigate inside your new directory.
```
cd SweetSavory.Solution
```
3. Clone this repository to your directory.
```
git clone https://github.com/mlstroud/SweetSavory.git
```
4. Setup Database - Run the MySQL commands below:
```
CREATE DATABASE `matt_stroud`;

USE `matt_stroud`;
```
5. Navigate to SweetSavory subdirectory and create appsettings.json
```
touch appsettings.json
```
6. Paste the following text into your appsettings.json file.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=matt_stroud;uid=YOURUSERNAMEHERE;pwd=YOURPASSWORDHERE;"
  }
}
```
>NOTE: Replace the username and password with your own.
>If you choose to use your own database, update the value here and run the following MySQL commands:
```
DROP DATABASE `matt_stroud`;
CREATE DATABASE `YOUR_DATABASE_HERE`;
USE `YOUR_DATABASE_HERE`;
```
7. Apply database migrations.
```
dotnet ef database update
```
8. Run the application with the following command:
```
dotnet run
```
9. Open URL in browser:
```
http://localhost:5000/
```

## Known Bugs
 
## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/mlstroud/SweetSavory/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core
* MVC
* MySQL
* Entity Framework Core
* RESTful Design
* Git

### License

This software is licensed under the MIT license.

Copyright © 2020 **_Matt Stroud_**