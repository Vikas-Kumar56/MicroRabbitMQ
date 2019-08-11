FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY Microservices/MicroRabbitMQ.Transfer.API/MicroRabbitMQ.Transfer.API.csproj Microservices/MicroRabbitMQ.Transfer.API/
COPY MicroRabbitMQ.Infrastucture.Ioc/MicroRabbitMQ.Infrastucture.Ioc.csproj MicroRabbitMQ.Infrastucture.Ioc/
COPY MicroRabbitMQ.Domain.Core/MicroRabbitMQ.Domain.Core.csproj MicroRabbitMQ.Domain.Core/
COPY MicroRabbitMQ.Infrastructure.Bus/MicroRabbitMQ.Infrastructure.Bus.csproj MicroRabbitMQ.Infrastructure.Bus/
COPY Microservices/MicroRabbitMQ.Tranfer.Application/MicroRabbitMQ.Transfer.Application.csproj Microservices/MicroRabbitMQ.Tranfer.Application/
COPY Microservices/MicroRabbitMQ.Transfer.Domain/MicroRabbitMQ.Transfer.Domain.csproj Microservices/MicroRabbitMQ.Transfer.Domain/
COPY Microservices/MicroRabbitMQ.Transfer.Data/MicroRabbitMQ.Transfer.Data.csproj Microservices/MicroRabbitMQ.Transfer.Data/
RUN dotnet restore "Microservices/MicroRabbitMQ.Transfer.API/MicroRabbitMQ.Transfer.API.csproj"
COPY . .
WORKDIR "/src/Microservices/MicroRabbitMQ.Transfer.API"
RUN dotnet build "MicroRabbitMQ.Transfer.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroRabbitMQ.Transfer.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroRabbitMQ.Transfer.API.dll"]
