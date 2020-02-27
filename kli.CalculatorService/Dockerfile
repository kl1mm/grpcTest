FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["kli.CalculatorService/kli.CalculatorService.csproj", "kli.CalculatorService/"]
RUN dotnet restore "kli.CalculatorService/kli.CalculatorService.csproj"
COPY . .
WORKDIR "/src/kli.CalculatorService"
RUN dotnet build "kli.CalculatorService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "kli.CalculatorService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "kli.CalculatorService.dll"]