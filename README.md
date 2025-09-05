# 🛠️ Ejercicio Técnico – Implementación de CRUD de Producto en API .NET

## 🎯 Objetivos  
- 🏗️ Implementar el CRUD de `Product` en la API.  
- 🗄️ Configurar la entidad `Product` y gestionar correctamente sus **migraciones** en la base de datos.  
- 🌐 Asegurar que la solución respete las convenciones de **RESTful API**.  
- ✅ Validar correctamente los datos de entrada de cada operación.  
- 📐 Aplicar **buenas prácticas de programación**, principios **SOLID** y patrones de diseño cuando sean necesarios.  
- ⚡ Mantener la solución consistente.  

---

## 💡 Recomendaciones  

### ✔️ Validación de Requests  
- 🔍 Validar los datos de entrada en los endpoints obligatorios y opcionales.  
- 💬 Mantener mensajes de error claros, consistentes y devolver códigos HTTP correctos.  

### ✔️ Buenas Prácticas y Arquitectura  
- 🏗️ Seguir un enfoque de **arquitectura por capas**, favoreciendo una separación clara de responsabilidades.  
- 🧩 Aplicar principios **SOLID**.  
- 🛠️ Usar patrones de diseño cuando aporten valor (ejemplo: DTOs, Repository Pattern, CQRS).  
- 📖 Procurar un código legible, mantenible y preparado para escalabilidad.  

---

## 📋 Tareas  

> ℹ️ La solución ya cuenta con una base de datos **SQLite** configurada.  

### 1️⃣ Configuración de la Entidad `Product`  
- ⚙️ Configurar la entidad `Product` en el contexto de base de datos (`DbContext`).  
- 🗄️ Generar la migración correspondiente para crear la tabla `Products`.  
- ▶️ Aplicar la migración sobre la base de datos para asegurar que la estructura se cree correctamente.  

---

### 2️⃣ CRUD de Producto  
Implementar los endpoints necesarios para la gestión de productos:  

- **Obligatorios:**  
  - ➕ Crear un nuevo producto.  
  - 📄 Listar todos los productos.  

- **Opcionales:**  
  - ✏️ Actualizar un producto.  
  - 🔎 Obtener un producto por su Id.  
  - ❌ Eliminar un producto.  

---
