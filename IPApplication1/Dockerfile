FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["IPApplication1/IPApplication1.csproj", "IPApplication1/"]
RUN dotnet restore "IPApplication1/IPApplication1.csproj"
COPY . .
WORKDIR "/src/IPApplication1"
RUN dotnet build "IPApplication1.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "IPApplication1.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "IPApplication1.dll"]