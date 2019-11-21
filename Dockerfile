FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["quotable.api/quotable.api.csproj", "quotable.api/"]
RUN dotnet restore "quotable.api/quotable.api.csproj"
COPY . .
WORKDIR "/src/quotable.api"
RUN dotnet build "quotable.api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "quotable.api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "quotable.api.dll"]
