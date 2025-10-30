# Proyecto de Gestión Básica de Restaurante – Rama `josue-avance`

Este proyecto es una aplicación de escritorio desarrollada en Windows Forms (WinForms) con .NET, orientada a la gestión básica de un restaurante. La rama `josue-avance` contiene los primeros avances estructurales del sistema, incluyendo la base visual, lógica de navegación y componentes reutilizables para una experiencia moderna y funcional.

## 🧱 Estructura actual

- **FormPrincipal**: Ventana principal que gestiona la navegación entre módulos del sistema.
- **LoginPage**: Formulario de inicio de sesión con interfaz limpia y preparada para validación.
- **MenuForm**: Formulario hijo que contiene un panel y un `FlowLayoutPanel` donde se visualizan tarjetas personalizadas para cada módulo (clientes, pedidos, productos, etc.).

## 🎨 Características implementadas

- Diseño modular con `UserControl` para tarjetas reutilizables y adaptables a distintos tipos de datos.
- Preparación para bordes redondeados, estilos modernos y animaciones suaves.
- Integración de `MenuStrip` con render personalizado para mejorar la experiencia visual.
- Organización clara de formularios y carpetas para facilitar la expansión del sistema.

## 🚀 Próximos pasos

- Agregar propiedades públicas a las tarjetas (`Título`, `Descripción`, `Imagen`) para que puedan recibir datos dinámicos.
- Mostrar tarjetas en `MenuForm` según datos simulados o reales (clientes, productos, pedidos).
- Documentar el flujo de navegación, estructura de carpetas y lógica de interacción entre formularios.
- Integrar validaciones, lógica de negocio y conexión con base de datos para operaciones CRUD.
- implementacion de form para gestion de usuarios de la aplicacion "agregar,editar y eliminar " usuarios.

## 🧠 Autor

Desarrollado por **Josue**.