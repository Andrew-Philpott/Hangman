# Hangman

#### C# Basic Web Applications Exercise for [Epicodus](https://www.epicodus.com/), 03.12.2020

#### By **Adela Darmansyah and Andrew Philpott**

## Pair Program WFH Summary

* Hangman Project
* Struggles:

## Specs

<details>
  <summary>Click to expand!</summary>

| Spec | `Console` Input | `Console` Output |
| :-------------     | :------------- | :------------- |
| **Test** | input | output |
| **Test** | input | output |


</details>

## RESTful Http Routes

<details>
  <summary>Click to expand!</summary>
| Route Name | URL Path | HTTP Method | Purpose |
| :--------- | :------- | :---------- | :------- |
| Index | /game | GET | Displays the hangman and guessed letters |
| Show | /game/{id} | GET | Displays end of game |

| Index | /guess | GET | Displays a list of all guesses |
| New | /guess/new | GET | Offers a form for user to input their guess (1 letter) |
| Create | /guess | POST | Create a new guess object |
| Show | / |
| Index | / |
</details>

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
