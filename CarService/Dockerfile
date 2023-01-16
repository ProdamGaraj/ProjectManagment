#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.


FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build 
WORKDIR /app 
EXPOSE 80 
COPY *.csproj ./ 
RUN dotnet restore "CarService.csproj" 
COPY . ./ 
RUN dotnet publish CarService.csproj -c Release -o out 
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime 
WORKDIR /app 
COPY --from=build /app/out . 
ENTRYPOINT ["dotnet", "CarService.dll"] 

 