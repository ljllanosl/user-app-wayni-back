
# Prueba de Entrada (Backend)

Implementado en Visual Studio 2022 con ASP.NET Web Core Api


Para alojar la base de datos SQL Server es necesario instalar SQL Server Management Studio 20




## Instrucciones

Clonar el proyecto

```bash
  git clone https://github.com/ljllanosl/user-app-wayni-back
```

Ir al directorio del proyecto e instalar las dependencias

```bash
  dotnet restore
  dotnet build
```

Iniciar el proyecto

```bash
  dotnet run
```


## Variables de Entorno

Para realizar la conexión con la base de datos SQL Server de manera local, deberá añadir el siguiente campo en el archivo appsettings.json

```json
"ConnectionStrings": {
  "Wayni": "Server=[Nombre-del-servidor];Database=Wayni;Trusted_Connection=True; Encrypt=False"
},
```

En donde [Nombre-del-servidor] es el utilizado por el programa SQL Server Management Studio 20 para alojar las bases de datos localmente.


## Configuración SQL Server

Con el programa SQL Server Management Studio 20 se debe crear una base de datos llamada "Wayni". Esta base de datos se poblará con una query que será enviada via correo.
## Edición de la contraseña via API 

Para realizar las pruebas con el formulario de "Change Password" y en especial con el campo "Current Password" se puede actualizar la unica tabla de "User" con una contraseña propia via el metodo PUT con la id = 1

Un ejemplo de Request Body para ejecutarlo en Swagger o Postman:

```json
{
  "id": 1,
  "name": "John Smith",
  "username": "johnsmith",
  "password": "Password123",
  "email": "johnsmith@mail.com",
  "phone": "987654321"
}
```
## Proyecto Frontend

El proyecto se encuentra en este repositorio 

https://github.com/ljllanosl/user-app-wayni
