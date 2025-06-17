# Hotel Management System

A simple management system application for Hotels and Hostels developed in C#.

## 🏨 About the Project

This project is a desktop application developed using C# Windows Forms for managing daily operations of hotel businesses. It works integrated with SQL Server database.

## ✨ Current Features

### 🔐 Security
- Secure login system with username and password
- Database-based user authentication

### 👥 Customer Management
- **New Customer Registration:**
  - First name, last name, gender information
  - Phone and email contact details
  - National ID number registration
  - Check-in and check-out date setting
- **Customer List:**
  - View all registered customers
  - Display customer details including ID, name, contact info, room number, fees, and dates
  - Customer selection functionality

### 🏠 Room Management
- **Room Selection System:**
  - Visual room buttons for rooms 101-109
  - Interactive room number assignment
  - Room status indicators (occupied/available - currently shows info messages)

### 💰 Pricing System
- **Automatic Price Calculation:**
  - Daily rate: 1850 TL
  - Automatic calculation based on stay duration
  - Real-time price updates when dates change

### 🎨 User Interface
- **Theme Support:**
  - Built-in dark/light theme system
  - Consistent color scheme across forms
- **Navigation:**
  - Main dashboard with navigation buttons
  - Form-to-form navigation system
  - Back to main menu functionality

## 🛠️ Technical Details

### Technologies Used
- **Language:** C# (.NET Framework)
- **UI Framework:** Windows Forms
- **Database:** SQL Server
- **Database Connection:** ADO.NET with SqlConnection

### Database Structure
The application uses a SQL Server database named `CagdasOtel` with the following tables:
- `Kullanicilar` - User authentication
- `MusteriEkle` - Customer information storage

### Database Schema (Customer Table)
- MusteriİD (Customer ID)
- Adi (First Name)
- Soyadi (Last Name)
- Cinsiyet (Gender)
- Telefon (Phone)
- Mail (Email)
- TC (National ID)
- OdaNo (Room Number)
- Ucret (Fee)
- GirisTarihi (Check-in Date)
- CikisTarihi (Check-out Date)

## 🚀 Getting Started

### Prerequisites
- .NET Framework
- SQL Server
- Visual Studio (recommended)

### Installation
1. Clone the repository
2. Set up SQL Server database named `CagdasOtel`
3. Create required tables (`Kullanicilar`, `MusteriEkle`)
4. Update connection string in the code if needed
5. Build and run the application

### Default Database Connection
```
Data Source=DESKTOP-EAR3I4G;Initial Catalog=CagdasOtel;Integrated Security=True;
```

## 📁 Project Structure

```
cagdasotels/
├── Form1.cs           # Login form
├── AnaSayfa.cs        # Main dashboard
├── FrmYeniMusteri.cs  # New customer registration
├── FrmMusteriler.cs   # Customer list view
├── FrmOdalar.cs       # Rooms form (basic structure)
└── Program.cs         # Application entry point
```

## 🔧 Current Functionality

1. **Login System:** Secure authentication with database validation
2. **Customer Registration:** Complete customer information entry with automatic price calculation
3. **Customer Management:** View and manage registered customers
4. **Room Assignment:** Visual room selection (rooms 101-109)
5. **Date Management:** Automatic stay duration and cost calculation
6. **Theme System:** Basic dark/light theme support

## 📋 Application Flow

1. User logs in through the login form
2. Main dashboard provides navigation options
3. Users can add new customers with room assignments
4. System automatically calculates costs based on dates
5. Customer list provides overview of all registrations

## 👨‍💻 Developer

**GitHub:** [@ycagdass](https://github.com/ycagdass)

## 📄 License

This project is developed for educational and commercial use in hotel management.

---

*This README reflects the current implemented features of the Hotel Management System as of the latest commit.*
