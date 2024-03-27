**Humanizer** es un paquete NuGet que da vida a su código. Ofrece una variedad de métodos y extensiones diseñadas para darle un toque humano a los datos de su aplicación. Con Humanizer, puede formatear elegantemente números, fechas, cadenas y más para que su código se comunique de forma más natural con los usuarios.

### OBJETIVO:
- Convertir cantidad de número a letra.

### PROYECTO
- Tipo: Console
- Version: Net 8.0

### INSTALACIÓN
- dotnet add package Humanizer --version 2.14.1


### CÓDIGO
```
using Humanizer;
using System.Globalization;

var culture = new CultureInfo("es-ES");
int amount = 2750; 

Console.WriteLine($"Cantidad en letra: {amount.ToWords(culture)} pesos 35/100 M.N.");
```

### RESULTADO

```
Cantidad en letra: dos mil setecientos cincuenta pesos 35/100 M.N.
```

### REFERENCIAS

https://www.nuget.org/packages/Humanizer/
https://github.com/Humanizr/Humanizer
