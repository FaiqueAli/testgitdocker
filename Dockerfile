FROM mcr.microsoft.com/dotnet/aspnet:3.1-focal AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:3.1-focal AS build
WORKDIR /src
COPY ["testgitdocker.csproj", "./"]
RUN dotnet restore "testgitdocker.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "testgitdocker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "testgitdocker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "testgitdocker.dll"]
