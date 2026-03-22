# 🍽️ QR Menu System API

A backend system for managing a QR-based restaurant menu using ASP.NET Core Web API.

---

## 🚀 Features

- 📋 Menu management (CRUD operations)
- 🧾 Order creation and tracking
- 🪑 Table management system
- 🔄 Order status updates
- 📡 RESTful API architecture
- 📄 Swagger API documentation

---

## 🛠️ Technologies Used

- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQL Database
- Swagger / OpenAPI

---

## 📡 API Endpoints

### Menu
- GET `/api/MenuItems`
- POST `/api/MenuItems`
- PUT `/api/MenuItems/{id}`
- DELETE `/api/MenuItems/{id}`

### Orders
- GET `/api/Orders/active`
- POST `/api/Orders`
- POST `/api/Orders/{orderId}/addItem`
- PUT `/api/Orders/{id}/status`

### Tables
- GET `/api/Tables`
- POST `/api/Tables`
- PUT `/api/Tables/{id}/status`

---

## ▶️ How to Run

1. Open the solution file in Visual Studio 2022
2. Run the project
3. Open Swagger UI:
https://localhost:7046/swagger


---

## ⚠️ Notes

- This project is a backend API.
- Root URL may return 404 — this is expected.
- Use Swagger UI to test the endpoints.

---

## 💡 Future Improvements

- Frontend integration (React / Angular)
- Authentication & Authorization (JWT)
- Real-time order tracking
- Admin dashboard

---

## 👨‍💻 Developer

**Berat Demir**