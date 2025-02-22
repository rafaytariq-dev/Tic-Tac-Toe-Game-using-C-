# Tic-Tac-Toe Game (C# Windows Forms)

This repository contains a simple yet fully functional Tic-Tac-Toe game developed using C# Windows Forms with turn-based gameplay, win/draw detection, and score tracking..

## Features

* **Turn-based Gameplay:** Players take turns marking cells with "X" or "O".
* **Win Detection:** The game accurately identifies winning combinations (rows, columns, diagonals).
* **Score Tracking:** Tracks and displays the scores of both players.
* **Draw Detection:** Detects and declares a draw when no winning moves are possible.
* **GUI-based Interaction:** A user-friendly graphical interface for easy gameplay.

## How to Run

1.  **Clone the Repository:**
    ```bash
    git clone [repository URL]
    ```
2.  **Open in Visual Studio:** Open the `.sln` file using Microsoft Visual Studio.
3.  **Build and Run:** Build the project and run the executable.

## Code Structure

* **`Form1.cs`:** Contains the main form logic and event handlers.

    * **`Form1()`:** Initializes the form, components, and button tags.
    * **`ButtonClick(object sender, EventArgs e)`:** Handles button click events, updates the game state, checks for a winner, and switches players.
    * **`CheckWinner()`:** Checks for winning combinations and highlights winning buttons.
    * **`ResetBoard()`:** Resets the game board and all related components.
    * **`ScoreCard()`:** Updates and displays player scores.
    * **`drawMatch()`:** Checks for a draw condition.

## Code Explanation

### `Form1()`

* Initializes the form and its components.
* Assigns unique tags (numbers) to each button for identification.
* Attaches the `ButtonClick` event handler to all nine buttons.
* Sets the background color of all buttons to beige.

### `ButtonClick()`

* Displays the current player's turn in `label2`.
* Extracts the row and column from the clicked button's `Tag`.
* Updates the game state in the 2D array.
* Calls `CheckWinner()` to determine if a player has won.
* Switches the current player.

### `CheckWinner()`

* Initializes `PlayerWon` as `false`.
* Checks all possible winning combinations (rows, columns, diagonals).
* Highlights the winning buttons in green.

### `ResetBoard()`

* Resets all components on the screen, including the game array, buttons, and labels.

### `ScoreCard()`

* Increments and updates the player scores.

### `drawMatch()`

* Checks if all possible winning combinations are false and declares a draw.

## Contributing

Feel free to contribute to this project by submitting pull requests or reporting issues.
