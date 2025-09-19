Inventory Management Application
INSY214 Visual Programming – August-December 2025

--------------------------------------------------------
Author:
Name: Tanyaradzwa Samupindi
Course: INSY214 Visual Programming
--------------------------------------------------------
Description:
This is a Windows Forms Inventory Management Application developed in C# using .NET 8.0.
It allows users to manage products efficiently by adding, editing, deleting, searching, importing, and 
exporting product data. 
The application includes features for product quantity management and user login/logout functionality.

--------------------------------------------------------
System Requirements:
- Windows 10 or later
- .NET 8.0 Runtime installed
- Minimum 1GB RAM
- At least 100MB free disk space

--------------------------------------------------------
Installation via ClickOnce:
1. Navigate to the "ClickOnce" folder included in the submission.
2. Double-click the file "InventoryApp.application" to launch the ClickOnce installer.
3. Follow the on-screen instructions to install the application.
4. Once installed, you can launch the application from the Start Menu or Desktop shortcut (if chosen during installation).

--------------------------------------------------------
Usage Instructions:

Login:
- Admin account:
  - Username: admin
  - Password: admin123
- User account:
  - Username: user
  - Password: user123

MainForm:
- Add: Add a new product to inventory.
- Edit: Edit the selected product.
- Delete: Remove a product from inventory.
- Export CSV: Export the current list of products to a CSV file.
- Import CSV: Import products from a CSV file.
- Search: Search products by name using the search box.
- Logout: Log out of the application and return to the login screen.
- Totals: View total number of products and total inventory value at the bottom.

ProductForm:
- Fields:
  - Name: Enter the product name.
  - Category: Select product category from the dropdown.
  - Price: Enter product price (must be a positive number).
  - Quantity: Enter product quantity (must be a positive integer).
- Buttons:
  - Save: Save the product details and return to MainForm.
  - Cancel: Cancel the operation and return to MainForm.

--------------------------------------------------------
ClickOnce Publish Location:
- The ClickOnce installer is located inside the "ClickOnce" folder.
--------------------------------------------------------
Data Storage:
- All product data is stored locally in JSON format within the application's directory.
- Imported and exported CSV files allow for easy backup and data sharing.

--------------------------------------------------------
Notes:
- Ensure that the target machine has .NET 8.0 runtime installed.
- This application is designed for single-user local use; multi-user network functionality is not 
implemented.
- The UI/UX has been optimized for simplicity and usability, including visual feedback on buttons and intuitive navigation.

--------------------------------------------------------
Submission Contents:
1. ClickOnce folder containing the installer ("InventoryApp.application")
2. Short demonstration video (max 2 mins) showing key features and installation process
