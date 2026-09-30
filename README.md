# Cliente de Libros Físicos

Aplicación de escritorio (Windows Forms, .NET Framework 4.8) para administrar el catálogo de libros físicos de una librería. Es el **cliente** de un microservicio GraphQL: todas las operaciones se hacen contra el servidor en `http://localhost:8081/graphql`.

**Universidad de Ibagué · Facultad de Ingeniería**
Diseño de Soluciones — Segundo Taller 2026B

**Integrantes**

- Sara Zambrano Ortiz
- Alejandra González Cortes
- Misael Gallo Tangarife
- Santiago Guimel Bahena

---

## Funcionalidades

Todas se abren desde el menú **Libro físico** de la ventana principal.

| Operación | Qué hace |
|---|---|
| **Insertar** | Registra un libro nuevo: ISBN, título, autor, precio, número de páginas, fecha de impresión y tipo de tapa. |
| **Consultar** | Busca un libro por su ISBN y muestra toda su información, incluido el total a pagar. |
| **Actualizar** | Busca un libro por ISBN y permite modificar sus datos (el ISBN no cambia); pide confirmación antes de guardar. |
| **Eliminar** | Busca un libro por ISBN, muestra sus datos y lo elimina después de confirmar. |
| **Listar** | Muestra todos los libros en una tabla y permite filtrar por autor y/o tipo de tapa (el filtro se aplica en el servidor). |

Al insertar se valida que el ISBN, el título y el autor no estén vacíos, que el precio sea mayor que cero y que la fecha de impresión no sea futura. Los errores del servidor o de conexión se muestran en un mensaje claro.

---

## Requisitos

- Windows 10 u 11
- .NET Framework 4.8 (viene incluido en Windows 10/11)
- Para compilar, **una** de estas opciones:
  - Visual Studio 2022 Community con la carga de trabajo *Desarrollo de escritorio de .NET*, o
  - Visual Studio Build Tools 2022 con *Herramientas de compilación de escritorio .NET* (para compilar desde VS Code o la terminal)
- El **microservicio GraphQL de libros físicos** en ejecución en el puerto `8081`

Los paquetes NuGet no se incluyen en el repositorio: se descargan la primera vez que se compila, así que se necesita conexión a internet.

---

## Cómo ejecutarlo

1. Inicie el servidor GraphQL y verifique que responde en `http://localhost:8081/graphql`.
2. Compile y ejecute el cliente con alguna de estas opciones:

**Visual Studio:** abra `ClienteLibroFisico.sln` y presione **F5** (Visual Studio descarga los paquetes NuGet automáticamente).

**Terminal / VS Code (PowerShell)**, desde la carpeta del proyecto:

```powershell
$msbuild = & "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe" -latest -products * -find MSBuild\**\Bin\MSBuild.exe
& $msbuild ClienteLibroFisico.sln -t:restore -p:RestorePackagesConfig=true
& $msbuild ClienteLibroFisico.sln
.\ClienteLibroFisico\bin\Debug\ClienteLibroFisico.exe
```

Si el servidor no está encendido, la aplicación abre normalmente, pero cada operación muestra un mensaje indicando que no fue posible conectarse.

Para usar otra dirección de servidor, cambie la constante `URL_SERVIDOR` en `ClienteLibroFisico/Servicios/LibroFisicoService.cs`.

---

## Estructura del proyecto

```
ClienteLibroFisico/
├── Modelo/
│   ├── LibroFisico.cs          Clases de datos (libro, entradas para crear/actualizar, respuestas GraphQL)
│   └── TipoTapa.cs             Valores del enum de tapa (BLANDA / DURA) y sus nombres para mostrar
├── Servicios/
│   └── LibroFisicoService.cs   Todas las consultas y mutaciones GraphQL, y el manejo de errores
├── Vistas/
│   ├── GUIPrincipal.cs         Ventana principal con el menú
│   ├── EscenaLibreria.cs       Pantalla de inicio (información de la app e ilustración)
│   ├── GUIInsertarLibroFisico.cs
│   ├── GUIConsultarLibroFisico.cs
│   ├── GUIActualizarLibroFisico.cs
│   ├── GUIEliminarLibroFisico.cs
│   ├── GUIListarLibrosFisicos.cs
│   ├── GUIAcercaDe.cs
│   ├── EstiloVentana.cs        Estilo visual compartido por las ventanas de cada operación
│   ├── EstiloMenu.cs           Estilo de la barra de menú
│   └── Formato.cs              Formato de moneda y fecha, y mensajes al usuario
├── Program.cs                  Punto de entrada
└── App.config
```

Las ventanas solo llaman a `LibroFisicoService`; ninguna arma consultas GraphQL por su cuenta.

---

## Operaciones GraphQL utilizadas

| Tipo | Operación | Uso |
|---|---|---|
| Query | `librosFisicos` | Listar todos |
| Query | `librosFisicosFiltrados(autor, tipoTapa)` | Listar con filtros |
| Query | `libroFisicoPorIsbn(isbn)` | Consultar, y buscar antes de actualizar o eliminar |
| Mutation | `crearLibroFisico(input)` | Insertar |
| Mutation | `actualizarLibroFisico(isbn, input)` | Actualizar |
| Mutation | `eliminarLibroFisico(isbn)` | Eliminar |

Todas piden los campos completos del libro: `isbn`, `titulo`, `autor`, `precio`, `numeroPaginas`, `fechaImpresion`, `tipoTapa` y `totalPagar`. Las fechas se envían en formato `yyyy-MM-ddTHH:mm:ss`.

---

## Tecnologías

- C# · Windows Forms · .NET Framework 4.8
- [GraphQL.Client](https://github.com/graphql-dotnet/graphql-client) 6.1.0 con serializador System.Text.Json
