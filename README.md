# 🛒 SmartMart Inventory Management System using Entity Framework Core

## Overview

The SmartMart Inventory Management System is a desktop application developed in C# using Entity Framework Core and SQL Server. The project simulates a retail store management module that tracks customers, products, and sales transactions. It demonstrates the use of relational databases, LINQ queries, and Entity Framework Core for efficient inventory and sales management.

The system enables store managers to analyze customer purchases, monitor sales activity, and generate category-wise sales insights through database-driven operations.

---

## Features

### 👥 Customer Management

* Maintain records of customers visiting the store.
* Store customer details such as name and city.

### 📦 Product Management

* Manage product information and categories.
* Track products available for sale.

### 💰 Sales Tracking

* Record sales transactions between customers and the store.
* Associate customers with purchased products.

### 🔍 Advanced LINQ Queries

#### Customer Purchase History

Displays customers along with the products they purchased and purchase dates.

#### Customers with No Purchases

Uses Left Outer Join to display all customers, including those who have not made any purchases.

#### Purchase Count per Customer

Shows the total number of products purchased by each customer.

#### Category-Wise Sales Analysis

Generates sales statistics by grouping transactions according to product categories.

---

## Technologies Used

* C#
* Windows Forms
* Entity Framework Core
* SQL Server
* LINQ
* Object-Oriented Programming (OOP)

---

## Database Entities

### Customer

* Customer ID
* Name
* City

### Product

* Product ID
* Product Name
* Category

### Sale

* Sale ID
* Customer ID
* Product ID
* Sale Date

---

## Concepts Implemented

### Entity Framework Core

* Database connectivity and ORM mapping.

### LINQ Queries

* Inner Joins
* Left Outer Joins
* Grouping
* Aggregation Functions

### Relational Database Design

* Customer-Product-Sales relationships.
* Foreign key associations.

### Data Visualization

* Displaying query results using DataGridView controls.

---

## Learning Outcomes

This project helped in understanding:

* Entity Framework Core fundamentals
* Relational database modeling
* LINQ query syntax and operations
* Join and Group By queries
* Sales data analysis
* Windows Forms development
* Database-driven application design

---

## Future Enhancements

* Product Stock Management
* Inventory Alerts for Low Stock
* Add, Update, Delete Operations
* Customer Purchase Reports
* Revenue Calculation Dashboard
* Search and Filter Features
* Authentication and Role-Based Access

---

## Conclusion

The SmartMart Inventory Management System provides a practical solution for tracking customers, products, and sales activities. By integrating Entity Framework Core with SQL Server and LINQ, the project demonstrates efficient database management, sales analytics, and inventory monitoring in a retail business environment.
