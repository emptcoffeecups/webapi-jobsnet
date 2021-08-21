# Comandos iniciais:
``` bash
  mkdir entity-framework
  cd entity-framework
  dotnet new mvc
```

# Comandos git:
``` bash
  git init
  git add .
  git commit -m "Iniciando projeto"
  code .gitignore # gerei o conteúdo para ignorar como (Windows, Linux, Mac, DotnetCore, VisualStudioCore) no link: https://www.toptal.com/developers/gitignore
  Criei o repositório e rodei os comandos
  git remote add origin git@github.com:torneseumprogramador/entity-framework.git
  git branch -M main
  git push -u origin main
```

# Componentes instalados:
``` bash
  dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9
  dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.9
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9
  dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.9
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
```

# Comandos para migração:
``` bash
dotnet tool install --global dotnet-ef
dotnet ef migrations add ClienteAdd
dotnet ef database update
```

# Instalação do code generator
``` bash
dotnet tool install -g dotnet-aspnet-codegenerator
```

# Gerando o scaffold de clientes
``` bash
dotnet aspnet-codegenerator controller -name CandidatosController -m Candidato -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout

dotnet aspnet-codegenerator controller -name ProfissoesController -m Profissao -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout


-- Original
dotnet aspnet-codegenerator controller -name ClientesController -m Cliente -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout
```

# Gerando o scaffold de um Controlador webapi
``` bash
dotnet aspnet-codegenerator controller -name CandidatosController -async -api -m Candidato -dc DbContexto -outDir Controllers

dotnet aspnet-codegenerator controller -name ProfissoesController -async -api -m Profissao -dc DbContexto -outDir Controllers
```