# HelpDesk

Sistema de gestión de mesa de ayuda desarrollado para administrar y dar seguimiento a solicitudes de soporte técnico.

## Descripción

**HelpDesk** es una aplicación de escritorio desarrollada en **C# con Windows Forms**, orientada a la gestión de solicitudes de soporte, usuarios y demás procesos relacionados con la atención de incidencias.

El proyecto fue desarrollado aplicando el paradigma de **Programación Orientada a Objetos (POO)** y una arquitectura **N-Capas**, buscando mantener una adecuada separación de responsabilidades entre las diferentes partes de la aplicación.

## Tecnologías utilizadas

* **Lenguaje:** C#
* **Interfaz gráfica:** Windows Forms
* **Paradigma:** Programación Orientada a Objetos (POO)
* **Arquitectura:** N-Capas
* **Gestor de base de datos:** Microsoft SQL Server
* **Control de versiones:** Git y GitHub

## Arquitectura

El sistema utiliza una arquitectura **N-Capas**, separando las responsabilidades principales de la aplicación en diferentes capas:

* **Entities:** representa las entidades y modelos de datos del sistema.
* **BLL:** contiene la lógica de negocio y las reglas de funcionamiento.
* **DAL:** se encarga del acceso y comunicación con la base de datos.
* **UI:** contiene la interfaz gráfica desarrollada con Windows Forms.

Esta separación facilita el mantenimiento, organización y evolución del sistema.

## Base de datos

La información del sistema es gestionada mediante **Microsoft SQL Server**.

El repositorio incluye los scripts necesarios para la creación y configuración de la base de datos utilizada por la aplicación.

## Funcionalidades

El sistema permite gestionar los principales procesos relacionados con una mesa de ayuda, incluyendo:

* Gestión de usuarios.
* Gestión de solicitudes de soporte.
* Registro y seguimiento de incidencias.
* Administración de información relacionada con las solicitudes.
* Consulta y actualización de información.
* Control de acceso según los roles definidos en el sistema.

## Requisitos

Para ejecutar el proyecto se requiere:

* Windows.
* Visual Studio.
* .NET compatible con la versión utilizada por el proyecto.
* Microsoft SQL Server.
* SQL Server Management Studio (SSMS), recomendado para administrar la base de datos.

## Instalación

1. Clonar el repositorio:

```bash
git clone https://github.com/MGarcia7783/HelpDesk.git
```

2. Abrir la solución de HelpDesk en **Visual Studio**.

3. Crear y configurar la base de datos en **SQL Server** utilizando los scripts incluidos en `HelpDesk.DataBase`.

4. Configurar la cadena de conexión de acuerdo con la instancia de SQL Server utilizada.

5. Restaurar las dependencias del proyecto.

6. Compilar y ejecutar la aplicación desde Visual Studio.

## Estructura del repositorio

```text
HelpDesk/
│
├── HelpDesk.DataBase/
│   └── Scripts de base de datos
│
├── HelpDesk.Solution/
│   ├── HelpDesk.Entity/
│   ├── HelpDesk.Bll/
│   ├── HelpDesk.Dal/
│   └── HelpDesk.UI/
│
└── README.md
```

## Autor

**Mario Ramón García Mairena**

Proyecto desarrollado con fines académicos.
