# 🛡️ Vikingos - Sistema de Expediciones

Este proyecto modela un sistema de gestión de expediciones vikingas, permitiendo representar vikingos, castas sociales, lugares a invadir y la lógica asociada a la toma de decisiones y reparto de botín.

---

## 📚 Tecnologías utilizadas

- C#
- .NET
- xUnit (para testing)

---

## 🧱 Estructura del proyecto

ParcialVikingos │ ├── Vikingos          → Biblioteca de clases (modelo del dominio) └── Vikingos.Tests    → Tests unitarios con xUnit

---

## Modelo del dominio

### Vikingos

- Clase abstracta `Vikingo`
- Tipos:
  - `Soldado`
  - `Granjero`

Cada vikingo:
- Tiene una `Casta`
- Puede ser o no **productivo**
- Puede o no **ir a una expedición**
- Puede **ascender socialmente**

---

### 🏛️ Castas

- `Casta` (abstracta)
- `Jarl`
- `Karl`
- `Thrall`

Características:
- Determinan si un vikingo puede ir a expedición
- Controlan el **ascenso social**
- Implementadas mediante **polimorfismo**

---

### 🌍 Lugares

- `Lugar` (abstracta)
- `Capital`
- `Aldea`
- `AldeaAmurallada`

Cada lugar:
- Define si **vale la pena invadirlo**
- Calcula el **botín obtenido**

---

### ⚔️ Expediciones

Una expedición:

- Contiene vikingos y destinos
- Permite:
  - Agregar vikingos (validando reglas)
  - Agregar destinos
  - Calcular si vale la pena
  - Calcular botín total
  - Realizar la expedición

---

## 🧪 Tests unitarios

Se implementaron tests con **xUnit** para validar:

### ✔ 1. Restricción de subida a expedición

- Un vikingo no válido no puede subir
- Se lanza una excepción

---

### ✔ 2. Expediciones que valen la pena

- Se verifica que todos los destinos sean rentables

---

### ✔ 3. Reparto de botín

- El botín se divide equitativamente entre los vikingos

---

### ✔ 4. Ascenso social

- Se prueba que un vikingo (Ragnar) asciende correctamente de `Karl` a `Thrall`

---

## ▶️ Cómo ejecutar el proyecto

### 1. Restaurar dependencias

dotnet restore

### 2. Compilar

dotnet build

### 3. Ejecutar tests

dotnet test

---

## 🧠 Conceptos aplicados

- Programación Orientada a Objetos (POO)
- Herencia
- Polimorfismo
- Composición
- Principios SOLID
- Open/Closed Principle (OCP)
- Testing unitario con xUnit

---

## Pregunta teórica

### ¿Se pueden agregar nuevos tipos de lugares sin modificar código existente?

Sí. Gracias al uso de la clase abstracta `Lugar` y polimorfismo, es posible agregar nuevas clases (por ejemplo `Castillo`) sin modificar código existente.

Esto cumple con el principio **Open/Closed**:
> El sistema está abierto a extensión pero cerrado a modificación.

---

## 👤Autor

Proyecto realizado como ejercicio integrador de modelado y testing en C# por Eric Aguirre de 6°7


---