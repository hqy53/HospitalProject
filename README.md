# HospitalProject

## //ERD:
Department Table has 2 columns: DeptId (pk), DeptName\
Job Table has 6 columns: JobId (pk), JobTitle, Responsibility, Qualification, Offer, DeptId (fk)

The Department and Job tables have a 1-M relationships. A job belongs to one department. A department can have many jobs.

### ///Need To Be Done:

Leo (Lam) Nguyen: Bug fixed Appointment

Anubhav Sharma: Doctor, ListDoctorsForDepartment

Anurag Negi: Article, Author

Qianying (Kate) Huang: Role Based Authentication & Conditional Rendering for Job and Department 


### ////Done:
Leo (Lam) Nguyen:
- Update Site layout
- Appointment CRUD (Still has bugs!)
- Appointment Views(List, New, Edit, DeleteConfirm, Details, Error)
- Patient CRUD,
- Patient Views(List, New, Edit, DeleteConfirm, Details, Error)

Anubhav Sharma:
-CRUD for Doctor,
-admin user can update,create or delete information,
-view the links for adding, updating and deleting information,
-Added some styling to my pages as well as to the website

Anurag Negi:
-CRUD FOR ARTICLE (add,delete,edit,details,view)
-CRUD FOR AUTHOR (add,delete,edit,details)


Qianying (Kate) Huang: 
- Job CRUD, 
- Job Views(List, New, Edit, DeleteConfirm, Details, Error),
- Department CRUD,
- Department Views (List, New, Edit, DeleteConfirm, Details, Error)
- ListJobsForDepartment

### TODO ->:
ListAppointmentsForPatient\
ListAppointmentsForDoctor\
ListLogForAdmin




