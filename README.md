# Hangman

#### C# Basic Web Applications Exercise for [Epicodus](https://www.epicodus.com/), 03.12.2020

#### By **Adela Darmansyah and Andrew Philpott**

## Pair Program WFH Summary 

* Hangman Project
* Attend the Epicodus Trade Show
* Objects within objects
* Implement unique IDs
* Use RESTful naming convention for Http routes
* Struggles:

The home page welcomes you to hangman and has a link to the game index

Game index will have a link to create a game, after creating the game we should route to the newly created games show page
the game index will have the list of games (called by the static getallgames)
There will be a list of links to each of the different games


for a games show page we should have a link going back to the game index page


## RESTful Http Routes

<details>
  <summary>Click to expand!</summary>
| Route Name | URL Path | HTTP Method | Purpose |
| :--------- | :------- | :---------- | :------- |
| Index | / | GET | Homepage: displays welcome message & link to create new game |
| Create | /games/{id} | POST | Create a new game object |
| Index | /games | GET | Displays list of all games |
| Index | /games/{id} | GET | Displays a specific game: the hangman and guessed letters |
| Show | /games/{id}/over | GET | Displays gameover |
| New | /games/{id}/guess/new | GET | Offers a form for user to input their guess (1 letter) |
| Create | /games/{id}/guess | POST | Create a new guess object |
| Index | /games/{id}/guess | GET | Displays lists of all correct and incorrect guesses |
| Show | /games/{id}/guess/correct | GET | Displays a list of all correct guesses |
| Show | /games/{id}/guess/incorrect | GET | Displays a list of all incorrect guesses |  
</details>
 
## Parking Lot

* Timestamp of start of a game
* Game show page will have a link to show the differences between that specific game score versus the average scores of all games

## Setup/Installation Requirements

* Download [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* Clone this [repository](https://github.com/ayohana/anagram.git/)
* Open the `Command Line Interface`.
  * Navigate into the `Hangman` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the application.
    * Type in the command `dotnet run` to run the application.
  * Navigate into the `Hangman.Tests` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the tests.
    * Type in the command `dotnet test` to run the tests. 

## Known Bugs

No known bugs at this time.

## Support and contact details

Feel free to provide feedback via email: adela.yohana@gmail.com and andrewphilpott92@gmail.com

## Technologies Used

* C#
* [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* MVC Pattern

### License

This C# console application is licensed under the MIT license.

Copyright (c) 2020 **Adela Darmansyah**
