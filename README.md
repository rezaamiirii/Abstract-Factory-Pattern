# Vehicle Factory  

Welcome to the **Vehicle Factory** application, a C# console application that allows users to create and describe different types of vehicles using the Abstract Factory design pattern. With support for Tesla and Harley-Davidson vehicles, this project serves as an educational example of the Abstract Factory pattern in action.  

## Features  

- **Vehicle Creation**: Easily create vehicles based on user input.  
- **Abstract Factory Pattern**: Designed using the Abstract Factory design pattern for scalability and flexibility.  
- **Simple Console Interface**: User-friendly command-line interface for interaction.  

## Getting Started  

### Prerequisites  

To run this application, you need:  

- [.NET SDK](https://dotnet.microsoft.com/download/dotnet) (version 8.0 or higher)  

### Installation  

1. **Clone the repository**:  
    ```bash  
    git clone https://github.com/rezaamiirii/Abstract-Factory-Pattern.git  
    ```  

2. **Navigate to the project directory**:  
    ```bash  
    cd Abstract-Factory-Pattern 
    ```  

3. **Restore dependencies**:  
    ```bash  
    dotnet restore  
    ```  

4. **Build the project**:  
    ```bash  
    dotnet build  
    ```  

5. **Run the application**:  
    ```bash  
    dotnet run  
    ```  

## Usage  

Once you run the application, you will be prompted to select a vehicle type. Simply type either `Tesla` or `Harley-Davidson` and press Enter. The application will respond with a description of the vehicle.  

You can continue to create vehicles or type `exit` to quit the application.  

### Example:
Welcome to the Vehicle Factory!

Select a vehicle type (Tesla or Harley-Davidson) or type 'exit' to quit:
tesla
Tesla is known for its electric vehicles and advanced technology.

Select a vehicle type (Tesla or Harley-Davidson) or type 'exit' to quit:
harley-davidson
Harley-Davidson is a legendary motorcycle manufacturer known for its cruiser bikes.

Select a vehicle type (Tesla or Harley-Davidson) or type 'exit' to quit:
exit
Thank you for using the Vehicle Factory! Goodbye.

## Folder Structure  

The project is organized into the following folders:
VehicleFactory/
│
├── Interfaces/ # Contains interfaces for vehicles and factories
│
├── Factories/ # Contains concrete implementations of factories
│
├── Vehicles/ # Contains vehicle implementations
│
├── Program.cs # The main entry point for the application
└── VehicleDescription.cs # Additional vehicle description logic, if any

## Contributing  

Contributions are welcome! Please follow these steps to contribute to this project:  

1. **Fork the repository**.  
2. **Create a new branch**:  
    ```bash  
    git checkout -b feature/YourFeature  
    ```  
3. **Make your changes** and commit them:  
    ```bash  
    git commit -m "Add some feature"  
    ```  
4. **Push to the branch**:  
    ```bash  
    git push origin feature/YourFeature  
    ```  
5. **Open a Pull Request**.  

## Acknowledgements  

- Inspired by the design patterns in software engineering.  
- Thank you to the open-source community for continuous support and contributions.  

## Contact  

For further inquiries or suggestions, feel free to reach out:  

- [Reza Amiri](https://github.com/rezaamiirii)  
- Email: rezaamiirii1@gmail.com
