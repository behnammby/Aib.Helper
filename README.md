# Aib.Helper

## Overview
Aib.Helper is a .NET Core library that provides essential utilities and components for the Aib ecosystem. It consists of multiple submodules, including **Common**, **Mdc**, and **MdcWeb**, which serve as helper libraries for the [Aib.Core](https://github.com/behnammby/Aib.Core) repository.

## Repository Structure

### 1. Common
A backend utility library that provides common functionalities, including database access and email handling.

- **Target Framework:** .NET Core 3.1
- **Dependencies:**
  - `Hashids.net` (1.3.0)
  - `Microsoft.EntityFrameworkCore` (3.1.7)
  - `NETCore.MailKit` (2.0.3)
  - `Pomelo.EntityFrameworkCore.MySql` (3.1.2)
- **References:**
  - `MdcWeb`

### 2. Mdc
A library for Blazor-based UI components.

- **Target Framework:** .NET Standard 2.0
- **Dependencies:**
  - `Microsoft.AspNetCore.Components` (3.1.0-preview1.19508.20)
  - `Microsoft.AspNetCore.Components.Web` (3.1.0-preview1.19508.20)

### 3. MdcWeb
A web-based library that serves as a foundation for UI components in **Aib.Helper**.

- **Target Framework:** .NET Core 3.0
- **Language Version:** C# 8.0
- **Root Namespace:** `Behnammby.MdcWeb`

## Usage
Aib.Helper is used as a dependency in [Aib.Core](https://github.com/behnammby/Aib.Core). To integrate it into a project, reference the necessary projects using `.csproj` dependencies.

## Installation & Setup
1. Clone the repository:
   ```sh
   git clone https://github.com/behnammby/Aib.Helper.git
   cd Aib.Helper
   ```
2. Restore dependencies:
   ```sh
   dotnet restore
   ```
3. Build the solution:
   ```sh
   dotnet build
   ```

## Contribution
Feel free to fork this repository and submit pull requests with improvements or fixes. Ensure your changes are well-documented and tested.

## License
This repository is licensed under the MIT License. See the LICENSE file for details.
