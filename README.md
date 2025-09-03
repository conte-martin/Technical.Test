# 🛠️ Ejercicio Técnico – Implementación de CRUD de Producto en API .NET

## 🎯 Objetivos  
- 🔍 Analizar y comentar oportunidades de mejora que identificas en el CRUD `Category`.  
- 🏗️ Implementar el CRUD de  Product en la API.  
- 🌐 Asegurar que la solución respete las convenciones de **RESTful API**.  
- ✅ Validar correctamente los datos de entrada de cada operación.  
- 📐 Aplicar **buenas prácticas de programación**, principios **SOLID** y patrones de diseño de ser necesario.  
- ⚡ Mantener la solución consistente.  

---

## 📋 Tareas  

### 1️⃣ Revisión de la Entidad `Product`  
Analizar la clase `Product` (que se detalla más abajo) y aplicar las **oportunidades de mejora** en sus propiedades:  

- 📝 Nombres que pueden generar ambigüedad.  
- 🔢 Tipos de datos que podrían no representar correctamente la información.  
- 🎛️ Definición de obligatoriedad u opcionalidad de los campos.  
- ⚖️ Uso de métricas físicas (`WeightKg`, `VolumeM3`).  
- 📅 Propiedades relacionadas con auditoría (`CreatedAt`, `IsDeleted`) y estado (`Status`).  

> ⚠️ **Nota:** No es necesario modificar los tipos de datos en este ejercicio, solo justificar qué aspectos mejorarías y por qué.  

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

### 3️⃣ Validación de Requests  
- ✅ Validar los datos de entrada en los endpoints obligatorios y opcionales.  
- 💬 Asegurar que los mensajes de error sean claros y consistentes.  

---

### 4️⃣ Buenas Prácticas y Arquitectura  
- 🏗️ Seguir el enfoque de **arquitectura limpia** con separación por capas.  
- 🧩 Aplicar principios **SOLID**.  
- 🛠️ Usar patrones de diseño cuando aporten valor.  
- 📖 Mantener un código legible, mantenible y preparado para escalabilidad.  

---

### 5️⃣ Mejoras Técnicas  
- 🚀 Comentar brevemente las mejoras adicionales que consideres necesarias en la API para soportar la funcionalidad de producto.  

---

## 🗂️ Entidad `Product` (base a revisar)  

```csharp
public class Product
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public required long Code { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int WeightKg { get; set; }
    public int? VolumeM3 { get; set; }
    public int Rating { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public bool? IsDeleted { get; set; }
    public int Status { get; set; }
}
