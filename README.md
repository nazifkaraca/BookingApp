# BookingApp

BookingApp is a hotel reservation system developed using a layered architecture, comprising Business, Data, and WebAPI layers. This design ensures modularity, maintainability, and scalability, facilitating efficient management of hotel bookings and related operations.

![image](https://github.com/user-attachments/assets/84749e85-08c8-4c53-98a2-27d15074c37a)

---

## Features

- **User Registration and Authentication**: Secure user sign-up and login functionalities.
- **Hotel Management**: Capabilities to add, update, and remove hotel information.
- **Room Booking**: Users can search for available rooms and make reservations.
- **Booking Management**: View and manage existing bookings with ease.

## Technologies Used

- **Backend**: ASP.NET Core 8
- **Data Access**: Entity Framework Core
- **API Architecture**: RESTful services
- **Database**: Microsoft SQL Server

## Installation

To run this project locally, follow these steps:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/nazifkaraca/BookingApp.git
   ```

2. **Navigate to the Project Directory**:
   ```bash
   cd BookingApp
   ```

3. **Restore NuGet Packages**:
   ```bash
   dotnet restore
   ```

4. **Update Database**:
   ```bash
   dotnet ef database update --project BookingApp.Data
   ```

5. **Run the Application**:
   ```bash
   dotnet run --project BookingApp.WebApi
   ```

## Usage

Once the application is running, you can access the API endpoints via `http://localhost:5000/api`. Use tools like Postman or Swagger UI to interact with the available endpoints for user registration, hotel management, room booking, and booking management.

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new branch (`feature/YourFeature`).
3. Commit your changes.
4. Push to the branch.
5. Open a Pull Request.

Please ensure your code adheres to the project's coding standards and includes appropriate tests.

## License

This project is licensed under the AGPL-3.0 License. See the [LICENSE.txt](LICENSE.txt) file for details.

## Contact

For inquiries or support, please contact [nazifkaraca](https://github.com/nazifkaraca).
