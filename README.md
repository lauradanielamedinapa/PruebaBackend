# PruebaBackend
Backend con C#, PostgreSQL, Entity Framework y Docker

Laura Daniela Medina Paipilla- +573134865169 - danielamedina1121@gmail.com

## Objetivo del Proyecto
- Establecer una conexión eficiente a una base de datos PostgreSQL utilizando Entity Framework.
- Crear migraciones y seed data para poblar la base de datos con marcas de autos.
- Desarrollar una API REST para obtener las marcas de autos desde la base de datos.
- Implementar pruebas unitarias efectivas con XUnit.
- Configurar Docker Compose para levantar los servicios de la API y PostgreSQL.

## Requisitos Previos

- Docker y Docker Compose instalados.
- (Opcional) .NET SDK si desea ejecutar el proyecto localmente sin Docker.
   
## Configuración con Docker
El proyecto incluye un archivo docker-compose.yml que configura dos servicios:
db: Un contenedor de PostgreSQL.
api: La API REST desarrollada con ASP.NET Core.
Para levantar los servicios, ejecuta el siguiente comando en la raíz del proyecto: docker-compose up --build, así se podrán descargar las imágenes necesarias, construir la API y ejecutar tanto la base de datos como el servidor web.

## Endpoint de la API
Es posible acceder a la API en la siguiente URL: GET http://localhost:5000/api/marcasautos, este endpoint devolverá todas las marcas de autos desde la base de datos.

## Migraciones y Seed Data
Este proyecto incluye una configuración de seed data en AutoContext.cs, por lo que cuando la base de datos se inicialice, se poblará automáticamente con tres marcas de autos (Toyota, Ford, Honda).

## Pruebas Unitarias
Las pruebas unitarias están implementadas utilizando XUnit. Para ejecutar las pruebas localmente: dotnet test
El archivo de pruebas se encuentra en la carpeta tests/MarcasAutosControllerTests.cs.

## Docker Compose
El archivo docker-compose.yml configura los siguientes servicios:
PostgreSQL: El contenedor de la base de datos, accesible en el puerto 5432.
API REST: El contenedor de la API, accesible en el puerto 5000



## Tecnologías Utilizadas
- C# / ASP.NET Core: Para el desarrollo de la API REST.
- Entity Framework Core: Para el manejo de la base de datos y migraciones.
- PostgreSQL: Base de datos para almacenar las marcas de autos.
- XUnit: Para las pruebas unitarias.
- Docker & Docker Compose: Para el despliegue y manejo de entornos.




