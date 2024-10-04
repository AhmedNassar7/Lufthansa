# Lufthansa

This project is an **Airport Management System** C# Windows Forms Application designed for managing various operations at an airport. The system enables the creation, deletion, insertion, display, search, and modification of records in a binary file. The primary goal of the project is to build a simple airport management system that operates without a traditional database, using binary file handling for data storage.

## Project Overview

The Lufthansa provides the following core functionalities:

- `Create a new file`: Specify the file name to create a new binary file.
- `Delete an existing file`: Remove an existing binary file by specifying its name.
- `Insert data`: Input details then stored in a binary file.
- `Display data`: Read and show the contents of the binary file.
- `Search and Modify`: Find records by ID and update them as necessary.

### Binary File Management

This project specifically uses binary files for data storage and manipulation instead of a traditional database system. All records are managed in a structured binary format.

## Features

1. **File Operations:**
   - Create a new binary file.
   - Delete an existing binary file.
   - Validate file existence.

2. **Data Handling:**
   - Insert new data into a binary file.
   - Display all records from the file.
   - Search for a record by ID.
   - Update or modify a record.

3. **Techniques Implemented:**
   - Logical File Organization: Supports ordered and unordered file organizations.
   - Hashing: Uses a hashing technique for efficient data retrieval.
   - B+ Tree: Implements B+ Tree structure for indexing and managing records.

## Project Structure

The project includes the following main forms:

1. **Main Form (Form1)**:
   - Menu Strip (File)
   - Options: Create, Delete, Exit

2. **Insert Form**:
   - Textboxes for data input.
   - Save Button: Saves data to the binary file.
   - Back Button: Returns to the Main Form.

3. **Display Form**:
   - Display Button: Shows all data in the binary file.
   - Back Button: Returns to the Main Form.

4. **Search and Modify Form**:
   - Search by ID.
   - Update Button: Modify existing records based on the search.

## Getting Started

### Prerequisites

- Visual Studio with C# .NET support.
- Basic understanding of binary file handling in C#.

### Installation

1. Clone the repository:

```bash
git clone https://github.com/username/lufthansa.git
