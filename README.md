```bash
####################################################################
#   _____                   _    ____            _             _   #
#  |  ___|__  _ __ ___  ___| |_ / ___|___  _ __ | |_ _ __ ___ | |  #
#  | |_ / _ \| '__/ _ \/ __| __| |   / _ \| '_ \| __| '__/ _ \| |  #
#  |  _| (_) | | |  __/\__ \ |_| |__| (_) | | | | |_| | | (_) | |  #
#  |_|  \___/|_|  \___||___/\__|\____\___/|_| |_|\__|_|  \___/|_|  #
#                                                                  #
####################################################################                                                    
```

## Pre-requisites
* .NET SDK
* Git

## Setup

### Install dependencies

#### .NET SDK
Go to Microsoft.NET main page (https://dotnet.github.io/) and follow the instructions.

#### Git
Go to Git main page (https://git-scm.com/), download and install.

### To get source code from parental repository
```bash
> $ git clone https://github.com/nanielito/ForestControl.git
```

## Build Project

You can build the project through command line:
```bash
> $ dotnet build
```

You can clean the project through command line:
```bash
> $ dotnet build
```

Or let these steps to be executed automatically by your IDE of preference.

## Console Application 

You can execute the console application through command line:
```bash
> $ dotnet run
``` 
Or using an IDE of your preference if you configure a "Run Command".

### Test Cases

There is a directory called _"testCases"_ into _"/src/resources"_ path, you must place your test cases there to be ran by the console application.

#### Test Case File Format

A test case file must have the following format:
* First line must define two consecutive integers separated by a space which represents a rectangle area.
* The following lines must be grouped in pairs following this rule:   
  * A initial line which defines two consecutive integers separated by a space plus a character.
    * The integers represent a position (X, Y) into the rectangle.
    * The character represents a direction (N for North, S for South, E for East, W for West).
  * The following line defines a string formed by characters M,L,R which represent a group of action to be executed  
    * M for moving forward.
    * L for turning left.
    * R for turning right.
* The test case file extension must be _".txt"_.

Example:
```bash
5 5
3 3 E
L
3 3 E
MMRMMRMRRM
1 2 N
LMLMLMLMMLMLMLMLMM
```

## Unit tests

You can execute the unit test through command line:
```bash
> $ dotnet test
```

Or using an IDE of your preference if you configure a "Run Test Command".

## Git Rules

### Commit messages:
Use the following prefix to classified the actions made:
* #N for adding new features.
* #M for updating features.
* #R for removing features or some piece of code.
* #F for fixing some bug on features.

### Branches
Use the following prefix to create branches:
* feature/FUNCTIONALITY-NAME for normal development.
* fix/ISSUE-DESCRIPTION for bug's fix.

## Version
v0.1.0

## Author
* **DER** - *Initial work* - [nanielito](https://github.com/nanielito)

## Licence
ISC