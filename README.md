# Prueba Técnica Rubén Lucena

Código de la prueba técnica Senior Developer Code Challenge de SAGE

## Proyecto

Generada una API para la búsqueda, inserción, modificación y eliminado de usuarios para la app StarWars+ para ayudar a nuestro clientes Stormtroopers a mejorar su puntería en la gestión de usuarios.

## Uso
La api cuenta con un Swagger para documentar y poder testear las diferentes llamadas, al ejecutar la API se redirigirá al contoller de Swagger. 

La API cuenta con una base de datos en SQLLite incluída en el proyecto y rellenada con 3 usuarios. En caso de que la base de datos no se encuentre rellena y habiendo usado Entity Framework, en la carpeta Migrations hay un fichero llamado AwesomeNetDBContextModelSnapshot.cs que contiene la creación de la base de datos y la inserción de los 3 usuarios.

## Estructura
El proyecto está dividido en varias carpetas, Controllers, Models, Repositories y Services

## Consideraciones
Debido a que el tiempo de la prueba era de 1h aproximadamente (tardé un poco más de 1h) e intentando encontrar la solución más óptima para poder enviar la prueba con persistencia de datos no me ha sido posible hacer la llamada a la API de consulta swapi.

## Cosas que me habría gustado añadir
De haber tenido un poco más de tiempo me habría gustado usar [Refit ](https://github.com/reactiveui/refit) para hacer la llamada a la api de Swapi. 
También me habría gustado realizar un test unitario.
