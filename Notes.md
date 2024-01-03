# Notes on Interoping with C++ and C#

## Preface?

So I'm working on a game/game engine and like alot of devs come from using an engine. My engine of choice was Unity until the [debacle](https://www.youtube.com/watch?v=O4dY0eUsaVI).
Now I want to actually build my own Engine/Editor/cool_piece_of_game_making_software.exe. So obviously you're gonna use c++, the best language ever made. It's C with a plus plus.

## File Sturcture
We have 3 Projects in the solution
- App
- Interop_cpp
- Interop_csharp

### App
has the actual app that you are running

### Interop_cpp
has the c++ code that you want to run in c#

### Interop_csharp
has c# code that helps csharpify the c++ code

## How it works to my knowledge
We write some c++ code and come c++ preprocessor code to tell say which functions are our public facing api.
For those of you who are new to this, when programming you can produce different types of stuff when programming.

#### Executables
- .exe

#### Shared Libraries
- .dll

#### Static Libraries
- .lib

What we are building is an .exe that needs to call some funtions in a .dll that we've written. The problem is our .exe(the app) is written in c# and our .dll is written in c++. But how do? .Net interopServices! And they work kinda neatly. You have to write an attribute for each function you want to call from the c++ api. And rewrite the class/structs with their own attributes describing how the data should be layed out. On the c/c++ side first it'd be nice to start by adding a `#define API __declspec(dllexport)`. Here we define `API` to be `__declpec(dllexport)`. Then for all of the functions we want to be public facing we have to wrap our header functions in an *'extern "c"'* block and add `API` to the front of each function.
> `API void Add(int a, int b);`


## How I wish it worked?
Programming magic! Visual studio should know I'm trying to reference c++ code and do all the work for me to call the code in c#.

## Outie
This is a very small amount of code produced by a programmer, you should not have many take aways other than *'oh yeah I can call c++ code in c#'*.
