# admin-cms

### Iniciando o projeto
``` bash
  dotnet new mvc -f net5.0
```

### Instalando dotnet-aspnet-codegeneretor
``` bash
  dotnet tool install -g dotnet-aspnet-codegenerator
```

### Instalando dotnet entity framework
``` bash
  dotnet add package Microsoft.EntityFrameworkCore --version 5.0.16
```

### Instalando dotnet entity framework Design
``` bash
  dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.16
```

### Instalando dotnet entity framework Tools
``` bash
  dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.16
```
### Instalando package SqlServer
``` bash
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.16
```
### Instalando Newtonsoft.Json
``` bash
  dotnet add package Newtonsoft.Json
```

### Instalando Codegeneretor
``` bash
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
```

### Migrations Esrtrutura Inicial
``` bash
  dotnet ef migrations add EstruturaInicial
```
### Migrations Database Update
``` bash
  dotnet ef database update
```
### Gerando codegeneretor Administradores
``` bash
  dotnet aspnet -codegenerator controller -name AdministradoresController -m Administrador -dc ContextoCms --relativeFolderPath Controllers --useDefaultLayout
```

### Adicionando tabela de Paginas 
``` bash
  dotnet ef migrations add AddPaginas
  dotnet ef database update
```
### Gerando Scafold Paginas
``` bash
  dotnet aspnet-codegenerator controller -name PaginasController -m Pagina -dc ContextoCms --relativeFolderPath Controllers --useDefaultLayout
```

Assisti 10 mints da v´´ideo aula 4



