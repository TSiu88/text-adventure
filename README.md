# _[Text Adventure](https://github.com/TSiu88/text-adventure)_

#### _Exercise in C# for a Text-based Adventure, 02.27.2020_

#### By _**Tiffany Siu and Adela Darmansyah**_

[![Project Status: WIP – Initial development is in progress, but there has not yet been a stable, usable release suitable for the public.](https://www.repostatus.org/badges/latest/wip.svg)](https://www.repostatus.org/#wip)
![LastCommit](https://img.shields.io/github/last-commit/tsiu88/text-adventure)
![Languages](https://img.shields.io/github/languages/top/tsiu88/text-adventure)
[![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)](https://lbesson.mit-license.org/)

## Table of Contents
1. [Description](#description)
2. [Setup/Installation Requirements](#setup/installation-requirements)
    - [Requirements to Run](#requirements-to-run)
    - [Instructions](#instructions)
    - [Other Technologies Used](#other-technologies-used)
3. [Notable Features](#notable-features)
4. [Known Bugs](#known-bugs)
5. [Support and Contact Details](#support-and-contact-details)
6. [License](#license)
---
## Description

This program is a console application that is an interactive text-based adventure!  Solve the different puzzles to find your way to the exit and escape!  You can interact with different objects and settings using keywords for commands and items that are in ALLCAPS.  Commands include LOOK, MOVE, PICKUP, and TALK, with special command for USE (item) (object) to use items from your inventory on various other objects. 

This program is currently unfinished and under construction.

## Setup/Installation Requirements

### Requirements to Run
* _.NET Core_
* _Command Line Interface_

### Instructions

*This page may be viewed by:*

1. Download and install .NET Core from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)
2. Clone the [repository](https://github.com/TSiu88/text-adventure.git) from my [GitHub page](https://github.com/TSiu88)
3. Use a command line interface to move to the repository's directory with `cd project-directory`
4. Run `dotnet restore` and `dotnet build` to get the packages to run this program
5. Run `dotnet run` to start up the program in the command line interface 

### Other Technologies Used
* _C#_
* _Markdown_

## Notable Features
This project is a text-based adventure game where you can LOOK, PICKUP, USE, MOVE, and TALK to different objects to solve the puzzles and escape.

<!-- ## Screenshots

_Here are some snippets for examples of what it looks like:_

![Snippet of example 1 with full word examples](WordCounter/img/snippet3.png)

![Snippet of example 2 with invalid search word](WordCounter/img/snippet1.png)

![Snippet of example 3 with empty entries](WordCounter/img/snippet2.png) -->


## Known Bugs

_This program is still under construction and does not reach the end game._

## Support and Contact Details

_If there are any question or concerns please contact me at our emails [Tiffany Siu](mailto:tsiu88@gmail.com) or [Adela Darmansyah](mailto:adela.yohana@gmail.com). Thank you._

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Tiffany Siu, Adela Darmansyah_**

<!-- # Notes
#### Genre: Adventure, Escape, Dungeon

Game Class:
Constructor: name, difficulty, items

Goal: To escape by figuring out word puzzles

- Player: name, HP, items list/inventory
- NPC: some good, some bad; they give an item
- Items: May be good/bad, may increase/decrease HP

Commands:
- USE items like potions
- LOOK around to get more info
- PICKUP items
- TALK to NPCs
- MOVE (door, window, anything that comes in the way will be listed)
- ITEMS (potions, keys, letters, anything you'll need to use for puzzle)

Puzzles:
- At the end, enter a password
- Use the correct item on the correct puzzle, e.g. give something/someone an item
- Jumbled letters, figure out what the actual word is
- Solve riddles

Remaining Room Notes:
- Room 5 = in tower, need to find statue and answer riddle to receive rope ladder and tie to beam near balcony to climb down to ledge
- Room 6 = on ledge, look at trapdoor, look up and see something below balcony that couldn't see from in room 5, use something to get it to fall onto trapdoor to break it open (use stick to prod object to fall?)
- Room 7A = damp cave, connected to room 7B by narrow stairs, searching here gives clue that need to find password among other items hidden in previous rooms
- Room 7B = cavern connected to the ocean with a locked boat, need password to unlock and escape

How Player Takes Damage:
- From failing to open doors
- From items/NPCs

Difficulty:
- Player's starting HP differs
- Easy: Tutorial NPC will give more/better items
- Hard: Tutorial NPC will not give item at all 

Parking Lot:
- implement difficulty and health
- add bad NPCs/difficulty level differences
- add more interactions
-->