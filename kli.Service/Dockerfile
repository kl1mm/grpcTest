FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 3333

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["kli.Service/kli.CalculatorService.csproj", "kli.Service/"]
RUN dotnet restore "kli.Service/kli.CalculatorService.csproj"
COPY . .
WORKDIR "/src/kli.Service"
RUN dotnet build "kli.CalculatorService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "kli.CalculatorService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "kli.CalculatorService.dll"]