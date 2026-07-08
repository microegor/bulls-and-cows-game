# Bulls and Cows Game

A simple console implementation of the classic **Bulls and Cows** logic game written in C#.

The goal of the game is to guess a randomly generated four-digit number with unique digits. After each attempt, the program gives feedback using bulls and cows:

* **Bull** — a correct digit in the correct position.
* **Cow** — a correct digit in the wrong position.

The game continues until the player guesses the full number and gets 4 bulls.

## Features

* Random four-digit number generation
* Unique digits in the secret number
* Console-based gameplay
* Feedback after every guess
* Attempt counter
* Simple and beginner-friendly C# code

## Tech Stack

* C#
* .NET 8

## Getting Started

### Prerequisites

Make sure you have the .NET SDK installed.

You can check your installed version with:

```bash
dotnet --version
```

The project requires .NET 8 or higher.

## Installation

Clone the repository:

```bash
git clone https://github.com/microegor/bulls-and-cows-game.git
```

Go to the project directory:

```bash
cd bulls-and-cows-game
```

## Run the Game

Start the application with:

```bash
dotnet run
```

## How to Play

When the game starts, the computer generates a random four-digit number with unique digits.

Enter your guess in the console:

```text
Enter your guess: 1234
```

After each guess, the game shows the number of bulls and cows.

Example:

```text
Bulls: 1, Cows: 2
```

This means:

* 1 digit is correct and in the correct position.
* 2 digits are correct but placed in the wrong positions.

You win when you get:

```text
Bulls: 4, Cows: 0
```

## Example Game

```text
Welcome to the Bulls and Cows game!
I have generated a random four-digit number with unique digits.
Try to guess it.

Enter your guess: 1234
Bulls: 1, Cows: 2

Enter your guess: 5678
Bulls: 0, Cows: 0

Enter your guess: 4321
Bulls: 0, Cows: 4

Enter your guess: 3412
Bulls: 4, Cows: 0

Congratulations! You guessed the number in 4 attempts.
```

## Rules

* The secret number has 4 digits.
* All digits are unique.
* Each guess should be a four-digit number.
* The game ends when all 4 digits are guessed in the correct positions.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
