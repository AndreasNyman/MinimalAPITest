This project is a minimal ASP.NET Core Web API for managing a list of students.
It provides endpoints to:

List all students (GET /students)
Get a student by ID (GET /student?id=1)
Add a new student (POST /students)
Update a student (PUT /students)
Delete a student by ID (DELETE /student?id=1)

All data is stored in memory, and the API uses simple HTTP requests to perform CRUD operations on the student list.
