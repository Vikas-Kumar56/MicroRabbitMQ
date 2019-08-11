FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY Microservices/Banking/MicroRabbitMQ.Banking.API/MicroRabbitMQ.Banking.API.csproj Microservices/Banking/MicroRabbitMQ.Banking.API/
COPY MicroRabbitMQ.Infrastucture.Ioc/MicroRabbitMQ.Infrastucture.Ioc.csproj MicroRabbitMQ.Infrastucture.Ioc/
COPY MicroRabbitMQ.Domain.Core/MicroRabbitMQ.Domain.Core.csproj MicroRabbitMQ.Domain.Core/
COPY MicroRabbitMQ.Infrastructure.Bus/MicroRabbitMQ.Infrastructure.Bus.csproj MicroRabbitMQ.Infrastructure.Bus/
COPY Microservices/Banking/MicroRabbitMQ.Banking.Application/MicroRabbitMQ.Banking.Application.csproj Microservices/Banking/MicroRabbitMQ.Banking.Application/
COPY Microservices/Banking/MicroRabbitMQ.Banking.Domain/MicroRabbitMQ.Banking.Domain.csproj Microservices/Banking/MicroRabbitMQ.Banking.Domain/
COPY Microservices/Banking/MicroRabbitMQ.Banking.Data/MicroRabbitMQ.Banking.Data.csproj Microservices/Banking/MicroRabbitMQ.Banking.Data/
RUN dotnet restore "Microservices/Banking/MicroRabbitMQ.Banking.API/MicroRabbitMQ.Banking.API.csproj"
COPY . .
WORKDIR "/src/Microservices/Banking/MicroRabbitMQ.Banking.API"
RUN dotnet build "MicroRabbitMQ.Banking.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroRabbitMQ.Banking.API.csproj" -c Release -o /app
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroRabbitMQ.Banking.API.dll"]
