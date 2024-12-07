The Model-View-Controller (MVC) architecture is a design pattern used to organize code in a more modular and maintainable way. It separates an application into three main components:  

**Model:** Represents the data and the business logic of the application. It interacts with the database and handles data processing.

**View:** Represents the presentation layer. It displays data to the user and collects user input.

**Controller:** Acts as an intermediary between Model and View. It processes user input, interacts with the model, and updates the view.

---

Here is a MVC Task Manager, where you can view, add, and delete tasks.

mvc-example/
│
├── [index.php](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class25/index.txt)        # Entry point (controller)
├── models/
│   └── [TaskModel.php](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class25/TaskModel.txt)
├── views/
│   ├── [TaskView.php](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class25/TaskView.txt)
│   ├── [header.php](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class25/header.txt)
│   ├── [footer.php](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class25/footer.txt)
├── controllers/
│   └── [TaskController.php](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class25/TaskController.txt)
└── data/
    └── [tasks.json](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class25/tasks.txt)   # Mock database