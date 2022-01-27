# Proof of concept - Ceii.Api with Repository and Services

## Lectura inicial
- [Dependency Injection](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)


## Introducción

### Utilización de repositorios
Los repositorios son clases que se encarga de interactuar con la base de datos en un nivel bajo. No deberían contener lógica compleja,
deben limitarse a la consulta de información de las entidades del dominio y abstraer a cierto nivel operaciones de CRUD.

### Utilización de servicios
Los servicios contienen una dependencia a uno o más repositorios dependiendo su necesidad. Son los encargados de combinar operaciones a otras
más complejas evitando colocar esa lógica dentro de los repositorios. Exponen y mapean entidades de dominio a viewmodels.

## Estructura de proyectos
Utilizando **Clean Architecture**:

### Poc.Api.Core
Contiene la definición de los controladores, y la creación de la aplicación web. Acá se definen todos los servicios e inyección de dependencias
necesarias para el funcionamiento correcto.
Los controladores únicamente se encargan de invocar a los servicios.

### Poc.Api.Application
Contiene toda la lógica de negocio. Acá se definen los mapeos necesarios, los viewmodel con los datos relevantes para los usuarios, la implementación y 
definición de servicios y repositorios.
Los repositorios y servicios deberán agruparse en sus propios directorios.

Los repositorios pueden:
- Acceder directamente a las entidades del dominio
- Acceder a la base de datos
- Realizar operaciones de CRUD
- Consultar información con objetos anónimos
- Abstraerse en operaciones genéricas (interfaces)

Los servicios pueden:
- Depender de uno o más repositorios
- Depender de un mapeador
- Acceder a las entidades del dominio que son expuestas por los repositorios

Cada una de estas unidades debe ser separada en su propia clase o archivo correspondiente.

### Poc.Api.Domain
Contiene la lógica de dominio. Todos los datos que son relevantes para almacenar, aunque no todos sean expuestos en su totalidad.
Acá se manejan las entidades y el contexto de la base de datos, su única función es modelar la información y exponerse a la capa de la aplicación.