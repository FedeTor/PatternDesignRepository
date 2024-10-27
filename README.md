📂 **Proyecto - API de Gestión de Productos**

Este es un proyecto de API para la gestión de productos, desarrollado como parte de mi portfolio profesional. La arquitectura implementa el patrón de diseño Repository, lo cual permite 
separar la lógica de acceso a datos de la lógica de negocio, mejorando así la flexibilidad y mantenibilidad del código.

🛠️ **Tecnologías Utilizadas**

- **Lenguaje**: C# (.NET Core)
- **Framework**: ASP.NET Core Web API
- **ORM**: Entity Framework Core para la gestión de la base de datos.
- **Base de Datos**: SQL Server.
- **Logger**: SeriLog para la gestión de logs.
- **Inyección de Dependencias**: Gestión nativa de .NET Core

🎨 **Patrones de Diseño y Arquitectura**

Este proyecto incorpora varios patrones de diseño y principios para mantener el código limpio, escalable y fácil de mantener:

- **Repository Pattern**: Abstrae el acceso a la base de datos, permitiendo cambiar de proveedor de datos sin impactar la lógica de negocio.
- **Dependency Injection**: Gestiona las dependencias entre componentes y servicios.
- **DTOs (Data Transfer Objects)**: Facilitan el transporte de datos entre capas, protegiendo la integridad de las entidades.
- **Error Handling y Logging**: Estructura la gestión de errores y logs, optimizando la detección y solución de problemas en producción.

🏛️ **Arquitectura**

El proyecto está diseñado con una arquitectura modular basada en Clean Architecture, que separa la lógica de negocio (Domino y Aplicación) de la infraestructura y la capa de presentación. 
Esto facilita el mantenimiento y escalabilidad de la aplicación.

**Las capas principales incluyen**:

- Domain: Entidades y lógica de negocio.
- Application: Lógica de aplicación, patrones de diseño.
- Infrastructure: Configuración de acceso a bases de datos y lógica específica del proveedor.
- Presentation: Exposición de la API mediante controladores.

👨‍🏫 **Buenas Prácticas Implementadas**

-**ncipios SOLID**: Código modular, con baja dependencia entre clases y alta cohesión.
- **POO** (Programación Orientada a Objetos): Uso de encapsulación, herencia y polimorfismo para crear componentes reutilizables y flexibles.
- **DRY** (Don't Repeat Yourself): Minimiza la repetición innecesaria de código.

🗃️ **Base de Datos**

La base de datos predeterminada es SQL Server.

⚙️ **Instrucciones de Ejecución**

**Requisitos Previos**
- .NET 7.0 SDK o superior
- SQL Server u otro motor de base de datos compatible.
- IDE compatible con .NET (Visual Studio o VS Code).
**Configuración del Proyecto**
- Clona el repositorio: https://github.com/FedeTor/PatternDesignRepository.git
- Configura la base de datos: En el archivo appsettings.json, ajusta la cadena de conexión a la base de datos.
- Ejecuta la aplicación.

**Probar la API**
La API documentada con Swagger estará disponible en https://localhost:7084/swagger
Además se agregó una carpeta "Documentación" con la coleccion de postman, solo queda descargarla e importarla si se desea utilizar.

📜 **Endpoints Principales**
**Los endpoints principales disponibles en la API son**:

- GET /api/products/all: Obtiene todos los productos
- GET /api/products/get: Obtiene un producto por ID
- POST /api/products/create: Agrega un nuevo producto
- PUT /api/products/update: Actualiza un producto existente
- DELETE /api/products/delete: Elimina un producto
