FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Mac.CloudBurst.ProductionCode/Mac.CloudBurst.ProductionCode.csproj", "Mac.CloudBurst.ProductionCode/"]
RUN dotnet restore "Mac.CloudBurst.ProductionCode/Mac.CloudBurst.ProductionCode.csproj"
COPY . .
WORKDIR "/src/Mac.CloudBurst.ProductionCode"
RUN dotnet build "Mac.CloudBurst.ProductionCode.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mac.CloudBurst.ProductionCode.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mac.CloudBurst.ProductionCode.dll"]
