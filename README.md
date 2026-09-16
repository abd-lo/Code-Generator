# Code-Generator

A Windows Forms developer tool that auto-generates C# CRUD boilerplate code (Data Access + Business Logic layers) from a simple list of field names and types — instead of hand-writing the same repetitive ADO.NET code for every table.

## Features
- Enter a table name, class names, and a comma-separated list of `type name` pairs (or paste an existing class and strip the `get`/`set` accessors automatically).
- Generates, per selected option:
  - Public/private constructors
  - `GetAll` (Data + Business layer)
  - `AddNew` (Data + Business layer)
  - `Update` (Data + Business layer)
  - `Delete` (Data + Business layer)
  - `FindByID` (Data + Business layer)
  - `Save` (insert-or-update logic)
- Produces parameterized ADO.NET `SqlCommand` code (protected against SQL injection) with automatic type-safe `DBNull` handling on read (`int`, `short`, `byte`, `string`, `DateTime`, `double`, `float`, `bool`).
- Output is shown in a syntax-highlighted code box (FastColoredTextBox) for easy copy-paste into a real project.
- "Check All / Uncheck All" controls to quickly toggle which methods get generated.

## Tech Stack
- C# / .NET Framework 4.7.2, Windows Forms
- FastColoredTextBox (syntax highlighting for generated code)

## How to Run
1. Open `CodeGenCrud.sln` in Visual Studio.
2. Restore NuGet packages if prompted.
3. Build and run (F5).
4. Fill in the table/class names and fields, tick the methods you want, and click **Generate**.

## Project Structure
- `Form1.cs` — UI logic and all code-generation templates.
- `clsAddnewData.cs` — supporting data class.
