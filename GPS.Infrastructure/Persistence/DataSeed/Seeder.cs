using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Security;
using GraduationProjecrStore.Infrastructure.Persistence.Configurations.Business;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace GraduationProjecrStore.Infrastructure.Persistence.DataSeed
{
    public static class Seeder
    {
        public static List<ApplicationUser> UserSeed()
        {
            var userId = Guid.NewGuid();

            var user = new ApplicationUser
            {
                Id = userId,
                UserName = "testuser",
                NormalizedUserName = "TESTUSER",
                Email = "testuser@example.com",
                NormalizedEmail = "TESTUSER@EXAMPLE.COM",
                EmailConfirmed = true,
                Address = "123 Main St",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                PhoneNumber = "1234567890",
                PhoneNumberConfirmed = true,
                PasswordHash = new PasswordHasher<ApplicationUser>()
                    .HashPassword(null!, "Test@123"),
            };

            return new List<ApplicationUser> { user };
        }

        public static (List<Student>, List<Supervisor>, List<Department>, List<Project>, List<College>) TableSeeder()
        {
            var departments = new List<Department>()
            {
                new Department()
                {
                    Id = 1,
                    Manager = "Nabil Mustafa",
                    Name = "IS"
                },
                new Department()
                {
                    Id = 2,
                    Manager = "Ehab Rushdy",
                    Name = "IT"
                },
                new Department()
                {
                    Id = 3,
                    Manager = "Mohamed ElMahdy",
                    Name = "CS"
                },
                new Department()
                {
                    Id = 4,
                    Manager = "Ahmed ElSayed",
                    Name = "DS"
                }
            };

            var supervisors = new List<Supervisor>()
            {
                new Supervisor
                {
                    Id = 1,
                    FirstName = "Ahmed",
                    LastName = "Youssef",
                    Position = "Professor",
                    Address = "Cairo University, Building A",
                    BirthDate = new DateTime(1975, 5, 20),
                    DepartmentId = 1
                },
                new Supervisor
                {
                    Id = 2,
                    FirstName = "Fatima",
                    LastName = "Ali",
                    Position = "Associate Professor",
                    Address = "Ain Shams University, Building B",
                    BirthDate = new DateTime(1980, 11, 15),
                    DepartmentId = 2
                },
                new Supervisor
                {
                    Id = 3,
                    FirstName = "Mohamed",
                    LastName = "Hassan",
                    Position = "Assistant Lecturer",
                    Address = "Alexandria University, Building C",
                    BirthDate = new DateTime(1990, 3, 10),
                    DepartmentId = 3
                }
            };

            var colleges = new List<College>()
            {
                new College()
                {
                    Id = 1,
                    Name = "Computer Science"
                },
                new College()
                {
                    Id = 2,
                    Name = "Science"
                },
                new College()
                {
                    Id = 3,
                    Name = "Engineering"
                },
            };

            var projects = new List<Project>()
            {
                new Project
                {
                    Id = 1,
                    UploadAt = DateTime.Now.AddDays(-30),
                    DepartmentId = 1,
                    SupervisorId = 1,
                    CollegeId = 1
                },
                new Project
                {
                    Id = 2,
                    UploadAt = DateTime.Now.AddDays(-20),
                    DepartmentId = 2,
                    SupervisorId = 2,
                    CollegeId = 2
                },
                new Project
                {
                    Id = 3,
                    UploadAt = DateTime.Now.AddDays(-10),
                    DepartmentId = 3,
                    SupervisorId = 3,
                    CollegeId = 3
                }
            };

            var students = new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    FirstName = "Omar",
                    LastName = "Mahmoud",
                    Address = "Nasr City, Cairo",
                    BirthDate = new DateTime(2002, 4, 10),
                    GPA = 3.7,
                    Level = 4,
                    DepartmentId = 1,
                    SupervisorId = 1,
                    ProjectId = 1
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Salma",
                    LastName = "Hussein",
                    Address = "Maadi, Cairo",
                    BirthDate = new DateTime(2001, 9, 23),
                    GPA = 3.9,
                    Level = 4,
                    DepartmentId = 2,
                    SupervisorId = 2,
                    ProjectId = 2
                },
                new Student
                {
                    Id = 3,
                    FirstName = "Youssef",
                    LastName = "Tariq",
                    Address = "Giza, El Haram",
                    BirthDate = new DateTime(2003, 2, 15),
                    GPA = 3.4,
                    Level = 3,
                    DepartmentId = 3,
                    SupervisorId = 3,
                    ProjectId = 3
                }
            };

            new Student
            {
                Id = 4,
                FirstName = "Youssef",
                LastName = "Tariq",
                Address = "Giza, El Haram",
                BirthDate = new DateTime(2003, 2, 15),
                GPA = 3.4,
                Level = 3,
                DepartmentId = 4,
                SupervisorId = 4,
                ProjectId = 1
            };

            return (students, supervisors, departments, projects, colleges);
        }
    }
}
