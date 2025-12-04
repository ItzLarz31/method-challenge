# Hero Battle Simulator

A console-based superhero battle simulator built with C# that demonstrates object-oriented programming principles including inheritance, encapsulation, and polymorphism. This project was created as part of the Code:You program to showcase proficiency with C# methods and class structures.

## About the Project

In this interactive game, you play as a hero who must defeat multiple villains to restore order to the city. Each battle is determined by power levels, with random elements that keep gameplay exciting. Watch out for villains who play dirty and the legendary boss with a power level over 9000!

## Features

- **Dynamic Character System**: Object-oriented design with a base `Character` class and specialized `Hero` and `Villain` classes
- **Level-Based Combat**: Heroes and villains battle based on power levels with strategic outcomes
- **Random Events**: Unpredictable number of enemies, dirty tricks, and rare boss encounters
- **Progressive Difficulty**: Hero levels up after each victory, facing increasingly challenging opponents
- **Interactive Gameplay**: Personalized experience with custom hero names and ages

## Technologies Used

- C# (.NET)
- Object-Oriented Programming (OOP)
- Console Application

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher recommended)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/itzlarz31/method-challenge.git
   ```

2. Navigate to the project directory:

   ```bash
   cd method-challenge
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

### Running the Application

Run the application using the .NET CLI:

```bash
dotnet run
```

Alternatively, you can run the compiled executable from the `bin` directory after building.

## How to Play

1. **Enter Your Hero Details**: When prompted, enter your hero's name and age (which determines their starting power level)

2. **Face the Villains**: Your hero will encounter a random number of villains (2-6) that must be defeated

3. **Battle Mechanics**:

   - If your hero's level is higher than the villain's, you win automatically
   - Equal levels result in a 50/50 chance of victory
   - Lower levels result in defeat
   - Villains have a 20% chance to "play dirty" and cut your power in half for that battle
   - There's a rare 10% chance to encounter an unbeatable boss

4. **Victory Conditions**:

   - Defeat all villains to win the game
   - Lose a single battle and your hero falls

5. **Level Progression**: Your hero gains a level after each victory, becoming stronger for the next encounter

## Project Structure

```
method-challenge/
├── Program.cs           # Main game loop and entry point
├── Character.cs         # Base character class with shared properties
├── Hero.cs              # Hero class with combat logic and level progression
├── Villain.cs           # Villain class with special abilities
├── BattleHandler.cs     # Manages battle simulation and outcomes
└── README.md            # Project documentation
```

## Example Gameplay

```
What is your name: Superman

How old are you: 25

You get a call about multiple villains in the area

Upon arriving you notice there is 4 enemies you have to take down.

Battle 1 for Superman is about to commence

His opponent has a power level of 18

Will he win?

Superman is the winner! They are simply stronger.

...
```

## Future Enhancements

Potential improvements for future versions:

- Hero's with unique abilities
- Named villains with special powers
- Item system for power-ups and equipment
- Add some error handling for wrong user inputs

## Author

Created by Shawn Dishman A.K.A ItzLarz31

## License

This project is open source and available for educational purposes.

## Acknowledgments

- Code:You program for providing the learning framework and project requirements
- Dragon Ball Z for the "over 9000" reference
