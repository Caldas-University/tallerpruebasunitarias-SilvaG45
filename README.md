# Proyecto: Sistema de Validación de Retiros - Cuenta de Ahorros

Este proyecto implementa un sistema de validación para la gestión de retiros en cuentas de ahorros. La lógica de validación asegura que los retiros solo sean permitidos si se cumplen una serie de condiciones.

## Requisitos del Proyecto

El sistema de validación de retiros debe garantizar que el cliente cumpla con las siguientes condiciones antes de permitir un retiro de dinero:

1. La cuenta debe estar activa.
2. El cliente debe tener saldo suficiente.
3. El monto solicitado no debe exceder el límite de retiro diario.
4. La cuenta no debe estar bloqueada por fraude.
5. El monto debe ser múltiplo de 10.

## Estructura del Proyecto

El proyecto está dividido en dos partes principales:

- **CuentaAhorros**: Contiene la lógica de validación de los retiros.
- **CuentaAhorros.Tests**: Contiene las pruebas unitarias para asegurar que la lógica de validación funciona correctamente.

### Estructura de carpetas:

tallerpruebasunitarias-SilvaG45
│
├── CuentaAhorros (Proyecto principal)
│ ├── CuentaAhorros.csproj
│ ├── CuentaAhorros.cs
│
└── CuentaAhorros.Tests (Proyecto de pruebas unitarias)
├── CuentaAhorros.Tests.csproj
├── CuentaAhorrosTests.cs

## Instalación

### Requisitos previos

- [.NET SDK](https://dotnet.microsoft.com/download) versión 8.0 o superior.

### Pasos para configurar el proyecto

1. **Clonar el repositorio:**

   ```bash
   git clone <url-del-repositorio>
   ```

2. **Restaurar las dependencias de NuGet:**

   Desde la raíz del proyecto, ejecuta el siguiente comando para restaurar las dependencias:

   ```bash
   dotnet restore
   ```

3. **Compilar el proyecto:**

   Para compilar el proyecto y asegurarte de que no haya errores de compilación:

   ```bash
   dotnet build
   ```

### Ejecutar las pruebas

Para ejecutar las pruebas unitarias, usa el siguiente comando:

```bash
dotnet test
```
