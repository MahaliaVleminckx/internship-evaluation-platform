# Internship Evaluation Platform

A web application for digitizing internship evaluations for students, mentors and teachers.

This project was developed as a **group project** during my studies at Howest. Together, we worked on transforming a paper-based internship evaluation process into a more accessible digital platform.

The application allows students and mentors to complete evaluations digitally, while teachers can review and compare the submitted evaluations. The platform was also designed with different user roles and reusable modules in mind.

> **Project status:** Partially completed. Several core evaluation, administration and teacher features were implemented, while some of the originally planned functionality remained unfinished.

## My Contribution

As part of the development team, I worked on several features across the mentor, teacher and admin sides of the application.

### Mentor evaluation workflow

I developed the functionality that allows mentors to complete evaluations for students and save their answers.

### Teacher evaluation overview

I worked on the teacher functionality for viewing completed evaluations from both students and mentors. I also implemented the **overlay mode**, which makes it possible to view the evaluations together and compare the results more easily.

### Administration

I developed functionality that allows administrators to:

* Create and manage users
* Create users with different roles, such as students, mentors and teachers
* Create modules

### Teacher module selection

I implemented the functionality that allows teachers to view their assigned modules and select the module they want to work with.

### Layout and UI

I also contributed to building and improving the overall layout and user interface of the application.

## Technologies

The project was developed as a web application using:

* C#
* ASP.NET
* .NET
* Razor views
* Entity Framework
* Microsoft SQL Server / SQL Server Express
* HTML
* CSS
* JavaScript

## Project Structure

The solution is divided into several projects and folders, including:

* `Howest.SelfEvaluation.Core` — core application logic and data-related functionality
* `Howest.SelfEvaluation.Web` — web application and user interface
* `docs` — project documentation

## Project Context

This project was created as part of a school assignment focused on digitizing internship evaluation workflows.

The application was designed around four main user roles:

**Student →** completes a self-evaluation
**Mentor →** evaluates the student
**Teacher →** reviews the submitted evaluations
**Admin →** manages users, modules and evaluation data

One of the goals of the project was to create a flexible evaluation system that could be reused for different courses or modules rather than being limited to a single internship.

## Team Project

This was a collaborative project developed together with my team. While I contributed to several important parts of the application, the complete project was not written by me alone.

Some planned functionality was left unfinished due to the available development time and team capacity.

The contribution section above highlights the parts I personally worked on.

## Running the Project

The project can be opened using **Microsoft Visual Studio**.

The application uses a local SQL Server Express database configuration. The connection string in `appsettings.json` is configured for a local development environment.
