[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/ozVFrFMv)
# CSCI 1260 — Project
### How to Build and Run the Project
```Bash
git clone https://github.com/etsucs-scott/project-3-JW33R.git
dotnet run --project src/Minesweeper.Cli
```
### Simple ways the game works
```Bash
Board Sizes - 8x8, 12x12, 16x16
Input commands: R(reveall) row col, F(flag) row col
Seed Usuage: You will be prompted to enter a seed and if you decide to it will decide where the bombs are placed and if you don't enter any then it will create one for you. Also if you put 1-3 into the seed it will also pick for you
```
### High Scores
```Bash
High scores are stored in a csv file. You will only save your stats to a csv if you win the game
```
### Board Symbols
```Bash
# - UnRevealed
. - Revealed
f - flag
Numbers - how many bombs are adjacent to that space
b - bomb
```
### How to run Unit Tests
```Bash
In Visual Studio click test and then click run tests
```
