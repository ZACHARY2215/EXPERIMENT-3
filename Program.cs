namespace BALAMAN_IT201_CRUD_DEMO_08
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

/*
########################################

EXPERIMENT 3.1 - C# Windows Form CRUD Demo
---------------------------------------

I. Project Desctiption: 

This C# Windows Forms project implements a basic CRUD (Create, Read, Update, Delete)
application for managing vehicle records using a SQL Server database. The program allows users to add, view,
update, and delete vehicle data, which includes details like make, model, year, price, and electric status.

It also allows users to upload and display vehicle images. The vehicle records are displayed in a DataGridView, 
and database interactions are managed using ADO.NET with SqlConnection and SqlCommand. The project features error 
handling and user feedback through message boxes.

II. Project Tasks:

Each group must select at least 5 tasks and implement the necessary modifications to the project. After completing
the tasks, submit a PDF document as evidence, which includes a brief discussion of the updates your group made.

[ ] Task 3.1.1 - Implement a "Clear" Button for Input Fields. Add a button that clears all the input fields (txtMake, txtModel, etc.) 
so users can easily reset the form after adding or updating records.

[ ] Task 3.1.2 - Add Input Validation. Ensure fields like Year and Price only accept valid numbers, and mandatory fileds like Make and Model
are filled before allowing the record to be added.

[ ] Task 3.1.3 - Add Confirmation for Delete. Before deleting a record, display a confirmation dialog to ensure the user really wants to delete
the selected vehicle.

[ ] Task 3.1.4 - Add a Color Theme. Implement a consistent color theme for the entire form (background color, button colors, and text colors).
Allow users to switch between light and dark themes to improve the user interface experience.

[ ] Task 3.1.5 - Add an Application Icon. Update the form to include a custom icon in the title bar and taskbar, giving the application a more
polished and identifiable appearance.

[ ] Task 3.1.6 - Add a Background Image or Gradient. Apply a subtle background image or gradient to the form to improve its appearance, ensuring 
it does not distract from the functional elements of the application.

[ ] Task 3.1.7 - Add an "About Us" Page. Create a new Windows Form that serves as an "About Us" page displaying group member information, including 
lastname, firstname, a formal imagem email address, and role in the project. Ensure the page has a consistent layout and design, using
appropriate font sizes and component colors for a professional look. Add a "Back" button to return to the main form.

[ ] Task 3.1.8 - Add Vehicle Dimensions (mm) to the Database and Forms. Update the database table to include new fields for vehicle dimensions (length, width, height in millimeters).
Modify the Windows Form to allow input for these fields, and display them in the DataGridView. Ensure data validation (e.g., numeric input only).
For example, include dimensions such as 4,885 mm in length, 1,840 mm in width, and 1,445 mm in height for vehicle like the Toyota Camry.

[ ] Task 3.1.9 - Add Vehicle Weight (kg) to the Database and Form. Add a new column to the database table for vehicle weight in kilograms. Update the form to allow users to input the 
vehicle's weight and display this information in the DataGridView. Ensure validation is in place to allow only numerical values for weight input.

[ ] Task 3.1.10 - Add Number of Seaters to Vehicle Information. Introduce a new column in the database to store the number of seaters for each vehicle.
Modify the form to include a field where users can input the number of seats, and display this data in the DataGridView. Validate the input to ensure only reasonable
values (e.g., 2-8) are entered.
 
 */