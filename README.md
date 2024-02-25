# BodyWeightCalculatorTests

## Introduction
This repository contains a C# solution for calculating ideal body weight based on height and gender, along with unit tests to validate the functionality of the `BodyWeightCalculator` class.

## Table of Contents
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Tests](#tests)
- [Contributing](#contributing)
- [License](#license)

## Features
- **BodyWeightCalculator Class:** A class designed to calculate the ideal body weight based on height and gender.
- **Unit Tests:** A set of unit tests to verify the correctness of the `BodyWeightCalculator` class using the Microsoft Visual Studio testing framework.

## Installation
To use this solution, you'll need:
- Visual Studio or any other compatible IDE for C# development.
- Microsoft Visual Studio testing framework for running unit tests.

To get started:
1. Clone this repository to your local machine using `git clone <repository-url>`.
2. Open the solution in your preferred IDE.

## Usage
To use the `BodyWeightCalculator` class:
1. Create an instance of `BodyWeightCalculator`.
2. Set the `Height` and `Gender` properties.
3. Call the `CalculateIdealBodyWeight` method to get the ideal body weight.

Example:
```
BodyWeightCalculator calculator = new BodyWeightCalculator
{
    Height = 176,
    Gender = 'F'
};

double idealWeight = calculator.CalculateIdealBodyWeight();
```

## Tests
The unit tests are located in the `BodyWeightCalculatorTests` project.
To run the tests:
1. Open the solution in Visual Studio.
2. Build the solution.
3. Go to Test Explorer and run all tests.

## Contributing
Contributions are welcome! If you'd like to contribute to this project, feel free to submit a pull request.

## License
This project is licensed under the [MIT License](LICENSE).
