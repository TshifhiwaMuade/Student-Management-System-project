**Student Management System**

**Authors:**
Tshifhiwa Muade , Jason Bond , Glory Binkataba , Oarabile Mbewe , Glacious Mukhewvho

**Take Note :**

**Add the Assembly Reference:**

 - In Visual Studio, right-click on your project in the Solution Explorer and select Add > Reference....
 - In the Reference Manager window, expand Assemblies, and then select Framework.
 - Scroll down to find Microsoft.VisualBasic. Check it, and click OK.

   - Install the Microsoft.VisualBasic NuGet Package:
   - If you don’t see Microsoft.VisualBasic is in the Reference Manager, but you may need to add it via NuGet.
   - Right-click on your project in Solution Explorer and select Manage NuGet Packages….

Go to the Browse tab, and search for Microsoft.VisualBasic, and install it.
Once you’ve added the reference, the error should be resolved, and you should be able to use Microsoft.VisualBasic.Interaction.InputBox without any issues.

Overview
A comprehensive Windows Forms application for managing student records with full Git version control integration. This system allows educational institutions to maintain student records.

Features
- Student Record Management
  - Add new students with validation
  - View all student records in a grid format
  - Update existing student information
  - Delete student records
  - Generate statistical reports
- Data Persistence: All records are stored in text files for easy access and modification
- Version Control: Full Git integration with tracked changes and collaboration support

 Technical Specifications
- Platform: Windows Forms
- Language: C#
- Storage: Text-based file system
  - `students.txt`: Main storage for student records
  - `summary.txt`: Statistical reports and analytics
- Version Control: Git & GitHub

Core Functionalities

1. Add New Student
- Input validation for:
  - Student ID
  - Name
  - Age (numeric validation)
  - Course
- Real-time error checking
  
- Automatic file update

2. View All Students
- DataGridView display
- Auto-refresh on data changes
- Formatted data presentation
- Sort and filter capabilities

3. Update Student Information
- In-place editing
- Field validation
- Automatic file synchronization
- Duplicate prevention

4. Delete Student Records
- Record selection from the grid
- Confirmation prompt
- Automatic file update
- Grid refresh post-deletion

5. Summary Report Generation
- Statistical calculations:
  - Total student count
  - Average age
- Real-time display
- Automatic report file generation

Error Handling
- File operation error management
- Input validation
- User feedback through informative messages
- Data integrity protection

Installation & Setup

1. Clone the repository:
```bash
git clone [https://github.com/TshifhiwaMuade/Student-Management-System-project.git]
```

2. Open the solution in Visual Studio

3. Build and run the application

Development Workflow

Git Integration
- Regular commits with meaningful messages
- Feature-based branching
- Clean commit history
- Continuous integration with GitHub

Best Practices
- Consistent code commenting
- Error handling implementation
- Input validation
- File operation safety checks

File Structure
```
StudentManagementSystem/
├── src/
│   ├── Forms/
│   │   ├── MainForm.cs
│   │   ├── AddStudentForm.cs
│   │   └── UpdateStudentForm.cs
│   ├── Data/
│   │   ├── students.txt
│   │   └── summary.txt
│   └── Utils/
│       └── ValidationHelpers.cs
├── docs/
└── README.md
```

Contributing
1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request



Acknowledgments
- PRG282 Course Instructors : Ikraam Sadek , Evangelistars Shayamano
