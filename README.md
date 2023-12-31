# Car Simulation Project Readme

## Project Overview

This project, named **Car_Simulation**, is a C#/Windows/WPF application developed for the IST331 course at Penn State during the Fall 2022 semester. The purpose of the application is to simulate various driver actions on a virtual car, displaying the corresponding changes in instrumentation and controls.

## Design and Implementation

### 1. Project Setup

- The project is a C#/Windows/WPF application.
- .NET Framework version 5.0 is used.
- The Visual Studio solution and project are named **Car_Simulation**.

### 2. Window Design

- The main window title is set to **IST331_Car_Simulation**.
- The window is designed to simulate a driver's actions in a vehicle.

### 3. Driver Actions and Controls

- The driver's actions are simulated using appropriate Windows controls for each action.
- Each control is carefully selected to accurately represent the corresponding driver action.

### 4. Display of Driver Actions

- For each driver action, the application displays informative text to indicate what action has occurred.
- Instrumentation outcomes are displayed prominently to highlight changes.

### 5. Instrumentation Design

- The application includes instrumentation outcomes for various car components.
- Changes in instrumentation are displayed clearly using icons, text, or controls as deemed appropriate.

### 6. Exit Button

- An "Exit" button is provided to gracefully end the program.

## Simulation Lab Requirements

### 1. Part 1: Designing Controls

- The user interface is designed to work with a single keyboard/mouse action for each driver's action.
- Visual feedback is provided for the user to see the affected instrumentation/function.

### 2. Part 2: Designing Instrumentation

- All instrumentation affected by driver actions is displayed in a user-friendly manner.
- The display is designed for easy comprehension by the user.

### 3. Part 3: C# Coding

- The C# code handles events triggered by simulated driver actions.
- Clear and concise code updates the appropriate instrumentation.
- Instrumentation changes are visually apparent.

## Driver Actions and Corresponding Instrumentation

| Object Taken         | Action On                | Different States of the Objects | Initial State | Instrumentation Affected          |
|----------------------|--------------------------|---------------------------------|---------------|-----------------------------------|
| Drive Door           | Open, Closed             | Closed                          | Dome Light, Dash-door icon, Door chime |
| Windshield Wiper     | On, Off (keep it simple) | Off                             | Wipers are on/off                  |
| Gear Shift Position  | Park, Rev, Neutral, Drive | Park                            | P/R/N/D lights                    |
| Turn Signal          | Left, Off, Right          | Off                             | Left/Right/Off arrows              |
| Driver Window        | Up, Down                 | Up                              | Window Up/Down                    |
| Dome Light switch    | On, Off, Auto             | Off                             | Dome Light on/off                 |
| Ignition (using key) | No Key, Off, Accessory, On| No Key                          | Door chime, Wipers                |
| Head Lights Switch   | On, Off                  | Off                             | Headlights On/Off                 |
| Brake Pedal          | Pressed, Released        | Released                        | Brake Lights On/Off               |
| Driver Seat          | Occupied, Not            | Not                             | Dash-Seat Belt icon               |
| Seat Belt            | Buckled, Not             | Not                             | Dash-Seat Belt icon               |

## How to Run the Simulation

1. Open the solution in Visual Studio.
2. Build and run the project.
3. Simulate driver actions using the provided controls.
4. Observe changes in instrumentation and controls.
5. Exit the program using the "Exit" button.

Feel free to explore the code and customize the simulation as needed for educational purposes. For any questions or issues, please contact the project creator.

**Note:** The simulation does not include the actual movement of the vehicle; it focuses solely on the simulation of driver actions and their effects on the car's instrumentation.
