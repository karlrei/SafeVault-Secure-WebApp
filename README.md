# SafeVault-Secure-WebApp

# SafeVault Secure Web Application

## Overview
SafeVault is a secure web application designed to manage sensitive user data. This project demonstrates secure coding practices including protection against SQL injection, XSS, authentication, and role-based authorization.

## Features
- ✅ Input validation and sanitization
- ✅ SQL injection prevention (parameterized queries)
- ✅ XSS protection (output encoding)
- ✅ Secure password hashing (bcrypt)
- ✅ Authentication system (login)
- ✅ Role-Based Access Control (RBAC)
- ✅ Unit testing for security vulnerabilities

## Technologies Used
- C# (ASP.NET Core)
- MySQL
- NUnit (Testing)
- BCrypt.NET

## Security Measures
- Parameterized database queries
- HTML encoding of user input
- Password hashing with bcrypt
- Role-based authorization middleware

## Testing
Includes tests for:
- SQL Injection attacks
- Cross-Site Scripting (XSS)
- Authentication validation
- Authorization checks

## How to Run
1. Clone the repository
2. Set up the database using `/Database/database.sql`
3. Configure connection string
4. Run the application
5. Execute tests using NUnit

## Author
Karl 
