# Entregable Entity Framework Core - Sistema de Ventas
 
## Descripción
 
Aplicación de consola desarrollada en C# utilizando Entity Framework Core y SQL Server para la gestión de un sistema de ventas.
 
El sistema permite realizar operaciones CRUD sobre las siguientes entidades:
 
- Categorías
- Productos
- Clientes
- Órdenes
- Detalle de Órdenes
 
## Tecnologías Utilizadas
 
- .NET 10
- C#
- SQL Server
- Entity Framework Core

 
## Patrones y Principios Aplicados
 
### Generic Repository Pattern
 
Implementado mediante:
 
- IRepository<T>
- RepositoryBase<T>
 
### SOLID
 
- SRP (Single Responsibility Principle)
- Separación por capas:
- Modelos
- Repositorios
- Servicios
- Menús

## Base de Datos
 
Tablas implementadas:
 
- Categorias
- Productos
- Clientes
- Ordenes
- OrdenDetalle
 
## Funcionalidades
 
### Categorías
 
- Listar
- Agregar
- Actualizar
- Eliminar (Eliminacion logica)
 
### Productos
 
- Listar
- Agregar
- Actualizar
- Eliminar (Eliminacion logica)
 
### Clientes
 
- Listar
- Agregar
- Actualizar
- Eliminar (Eliminacion logica)
 
### Órdenes
 
- Listar
- Agregar
- Actualizar
- Eliminar  (Eliminacion logica)
 
### Detalle de Órdenes
 
- Listar
- Agregar
- Actualizar
- Eliminar  (Eliminacion logica)
 
## Instalación
 

Ejecutar proyecto:
 
```bash
navegar hasta la carpeta que contine el archivo Program.cs y ejecutar:

dotnet clean
dotnet restore
dotnet run
```
 
## Autor
 
Anthony Bueno
``