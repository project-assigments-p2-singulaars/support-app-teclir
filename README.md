# SupportApp

SupportApp es una aplicación que gestiona proyectos, personas y asignaciones, con autenticación y autorización integradas utilizando ASP.NET Core, Entity Framework Core, y FluentValidation.

## Requisitos

- .NET 8.0
- SQL Server
- Herramientas de desarrollo como Rider o VS Code

## Instalación

1. **Clonar el Repositorio:**
  - ```bash
  - git clone [https://github.com/tu_usuario/support-app.git](https://github.com/project-assigments-p2-singulaars/support-app-teclir.git)
  - cd SupportApp

2. **Restaurar Dependencias:**
 Ejecuta el siguiente comando para restaurar las dependencias del proyecto: dotnet restore

3. **Configurar la Base de Datos:**
Asegúrate de tener SQL Server instalado y configura la cadena de conexión en appsettings.Development.json:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost,1433;Database=Support;User=sa;Password=<Root1234>;TrustServerCertificate=True"
  },

4. **Aplicar Migraciones:**
Aplica las migraciones para crear la base de datos: dotnet ef database update

## Ejecución 
Para ejecutar la aplicación, utiliza el siguiente comando: dotnet run 

## Endpoints API 

GET /api/projects: Obtiene todos los proyectos.
POST /api/projects: Crea un nuevo proyecto.
GET /api/projects/{id}: Obtiene un proyecto por ID.
PUT /api/projects/{id}: Actualiza un proyecto por ID.
DELETE /api/projects/{id}: Elimina un proyecto por ID.

Para más detalles sobre los endpoints y cómo usarlos, consulta la documentación de Swagger disponible en http://localhost:5005/swagger/index.html








