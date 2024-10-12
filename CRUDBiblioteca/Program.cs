using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
// Aqu� estamos configurando el contexto de la base de datos para usar una base de datos en memoria llamada "BibliotecaDB".
builder.Services.AddDbContext<BibliotecaContext>(options =>
    options.UseInMemoryDatabase("BibliotecaDB"));

// Agregar soporte para controladores con vistas.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurar el pipeline de solicitud HTTP.
// Si la aplicaci�n no est� en modo de desarrollo, usa el controlador de errores.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // Redirigir a una p�gina de error personalizada en caso de excepciones.
    app.UseHsts(); // Utilizar HTTP Strict Transport Security (HSTS) para a�adir seguridad adicional en las conexiones HTTPS.
}

app.UseHttpsRedirection(); // Redirigir todas las solicitudes HTTP a HTTPS.
app.UseStaticFiles(); // Habilitar el uso de archivos est�ticos (como CSS, JavaScript, im�genes, etc.).

app.UseRouting(); // Habilitar el enrutamiento de las solicitudes.

app.UseAuthorization(); // Habilitar la autorizaci�n de solicitudes.

// Definir la ruta predeterminada para los controladores.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Usar el controlador "Home" y la acci�n "Index" como predeterminados.

app.Run(); // Ejecutar la aplicaci�n.
