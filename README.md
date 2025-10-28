# 📝 ToDoList

A simple and efficient **Windows Forms To-Do List App** built in **C# (.NET Framework)**.  
It allows users to manage their daily tasks with ease — add, edit, delete, mark as complete, and even export tasks to a CSV file for backup or reporting.

---

## 🚀 Features

- ✅ Add, edit, and delete tasks  
- 🕒 Mark tasks as completed  
- 💾 Save tasks in a local database  
- 📤 Export all tasks to a CSV file  
- ⚙️ Simple Windows Forms interface built with C#  
- 🔐 Configurable database connection (update credentials before running)

---

## 🧰 Technologies Used

- **C#**
- **.NET Framework / Windows Forms**
- **SQL Local Database**
- **System.Data.SqlClient**
- **CSV Export (via StreamWriter)**

---

## 🛠️ Installation & Setup

### 1. Clone the repository
```bash
git clone https://github.com/your-username/ToDoList.git
```

### 2. Open the project

Open the solution file `(ToDoList.sln)` in Visual Studio.

### 3. Configure the database connection
In your project, locate the connection string (usually inside `App.config` or a database helper class) and update it to match your local SQL Server setup:
```bash
<connectionStrings>
  <add name="ToDoListDB"
       connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=ToDoListDB;Integrated Security=True"/>
</connectionStrings>
```
> 💡 **Note:** Make sure your local database exists and matches the expected table schema.  
> You can also create a new database and update the connection string accordingly.

### 4. Build and Run
- Press **F5** or click **Start Debugging** in Visual Studio.  
- The application will launch and connect to your local database.

---

### 🖥️ Usage
1. Add new tasks using the input field and “Add” button.
2. Edit or delete existing tasks directly from the task list.
3. Mark tasks as completed to keep track of progress.
4. Export all tasks to a CSV file by clicking the Export button — great for saving your list or sharing it.

---

### 📸 Screenshots
<img width="904" height="467" alt="Screenshot 2025-10-28 at 14 20 34" src="https://github.com/user-attachments/assets/9c2ab546-2af2-43c8-873e-57d1af0caece" />
<img width="1020" height="512" alt="Screenshot 2025-10-28 at 14 21 32" src="https://github.com/user-attachments/assets/14164bb1-d1e6-4b26-aca8-cab6b808a8bf" />
<img width="1024" height="719" alt="Screenshot 2025-10-28 at 14 21 38" src="https://github.com/user-attachments/assets/33cca40f-5caa-47a9-8a36-4c4e72c776af" />

---

### ⚙️ Project Structure
``` bash
ToDoList/
│
├── ToDoList.sln
├── /bin
├── /obj
├── /Properties
├── App.config
├── MainForm.cs
├── DatabaseHelper.cs
├── TaskModel.cs
└── README.md
```

---

### 💬 Author
Amer Sbeini

📧 sbeni2001@gmail.com
