#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/Acme.StudentOnBoardingAbp.Web/Acme.StudentOnBoardingAbp.Web.csproj", "src/Acme.StudentOnBoardingAbp.Web/"]
COPY ["src/Acme.StudentOnBoardingAbp.Application/Acme.StudentOnBoardingAbp.Application.csproj", "src/Acme.StudentOnBoardingAbp.Application/"]
COPY ["src/Acme.StudentOnBoardingAbp.Domain/Acme.StudentOnBoardingAbp.Domain.csproj", "src/Acme.StudentOnBoardingAbp.Domain/"]
COPY ["src/Acme.StudentOnBoardingAbp.Domain.Shared/Acme.StudentOnBoardingAbp.Domain.Shared.csproj", "src/Acme.StudentOnBoardingAbp.Domain.Shared/"]
COPY ["src/Acme.StudentOnBoardingAbp.Application.Contracts/Acme.StudentOnBoardingAbp.Application.Contracts.csproj", "src/Acme.StudentOnBoardingAbp.Application.Contracts/"]
COPY ["src/Acme.StudentOnBoardingAbp.HttpApi/Acme.StudentOnBoardingAbp.HttpApi.csproj", "src/Acme.StudentOnBoardingAbp.HttpApi/"]
COPY ["src/Acme.StudentOnBoardingAbp.EntityFrameworkCore/Acme.StudentOnBoardingAbp.EntityFrameworkCore.csproj", "src/Acme.StudentOnBoardingAbp.EntityFrameworkCore/"]
RUN dotnet restore "src/Acme.StudentOnBoardingAbp.Web/Acme.StudentOnBoardingAbp.Web.csproj"
COPY . .
WORKDIR "/src/src/Acme.StudentOnBoardingAbp.Web"
RUN dotnet build "Acme.StudentOnBoardingAbp.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Acme.StudentOnBoardingAbp.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Acme.StudentOnBoardingAbp.Web.dll"]