!!! The file UniCatalog_database.sql contains a script that creates the exact database I used.

UniCatalog is an electronic catalog, made with .net, that follows the following modules:

1. Education Cycles
     Usually, facultees offer license and masters as education cycles. The application can manage theese (adding, deleting or viewing them)
2. Study Programs
     Study programs are a subdivision of education cycles and they represent the training routes that the student wants to go for.
3. Study Years
     Each training route lasts a number of years. This number of years is represented by the study years and is mentioned when creating a new study program.
4. Courses
     Courses are what the students attend to, in order to learn and pass the years. Courses have an identifying code which is used when wanting to delete a course.
5. Students
     In order to register a new student the application wants a lot of data, but the most important one is the registration number which can be used to delete the student.
6. Groups
     A group has this codification : {C}{F}{P}{A}, where C is the education cycle, F the is education form(which can be with or without frequency), P is the study program and A is the last number of the year when the students enetered the study program.
7. Professors
     When registering professors, the most important data is the employee brand, which is used for deleting a professor from the database.   
8. Users
     Users can register as secretary, administrator or professor (a user can be multiple of them at the same time).
9. Grades
     Grades can be added and visualised in the catalogue (included in the main menu of the application).

The application allows: visualising, deleteting, and adding data for theese modules.

The application opens on a login window, where you can opt for registering a new account in case you do not have one. All the data stores into a database (for which I put the script - see line 1). I used SQL Server Management Studio for this project.
The application is easy to navigate on: after logging in, you are presented with a main menu where you can access new forms which represent the different modules, with a "back" button that takes you to the previous form.


