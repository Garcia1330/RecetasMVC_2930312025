Proyecto: Administración de Recetas (ASP.NET MVC - .NET Framework)
-------------------------------------------------------
Estructura mínima entregada (Code First - Entity Framework):

- Models/
    - Receta.cs (modelo con DataAnnotations: Nombre PK, Instrucciones, TiempoPreparacion)
    - RecetasContext.cs (DbContext usando connection string "RecetasContext")

- Controllers/
    - RecetasController.cs (CRUD completo: Index, Details, Create, Edit, Delete)

- Views/Recetas/
    - Index.cshtml, Create.cshtml, Edit.cshtml, Details.cshtml, Delete.cshtml

- Web.config: Contiene la cadena de conexión apuntando al servidor suministrado y con el nombre de BD requerido: Db_2930312025
  Connection string name en el proyecto: "RecetasContext"

Instrucciones para usar:
1) Abrir Visual Studio.
2) Crear nuevo proyecto ASP.NET Web Application (.NET Framework) vacio o MVC.
3) Copiar/pegar las carpetas y archivos dentro del proyecto.
4) Restaurar paquetes NuGet (EntityFramework, Microsoft.AspNet.Mvc) si es necesario.
5) Ejecutar la aplicación. Al acceder al controlador Recetas, EF creará la base de datos Code-First con el nombre Db_2930312025 usando la connection string de Web.config.

IMPORTANTE:
- El campo Nombre es clave primaria y obligatorio.
- Se implementaron validaciones server-side (DataAnnotations) y hooks para client-side (jquery.validate) en las vistas (las cuales requieren bundles/scripts de la plantilla MVC para validación cliente).

Entrega:
- Este archivo ZIP contiene todo el proyecto solicitado.
