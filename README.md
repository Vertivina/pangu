# vertivina
Un simple repositorio de prueba.<br/>
Si es posible, nos lo quedamos<br/>

Glosario:<br/>

*Para las migraciones (cada vez que se tiene que hacer cambios tanto a las clases como a la base): <br/>
 <br/>
  dotnet ef migrations add [Nombre de migración. Debe ser diferente a la anterior] <br/>
  dotnet ef database update<br/>
<br/>
Recordatorio: No borren las migraciones a menos que sea una verdadera emergencia o se quiera hacer desde cero
 <br/>
*Para autogenerar codigo: <br/>
 <br/>

  dotnet aspnet-codegenerator controller -name [Nombre de nuevo controlador] -m [Clase] -dc [Clase contexto] --relativeFolderPath     Controllers --useDefaultLayout --referenceScriptLibraries 
 <br/>
 Si existe algun problema con los comandos:
 *Asegurense de tener su .Net core actualizado
 *Realizen el dotnet restore
 
 
