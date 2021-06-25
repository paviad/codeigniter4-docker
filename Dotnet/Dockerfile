FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet publish LiranApp -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet
WORKDIR /app
COPY --from=build /publish .

CMD [ "dotnet", "LiranApp.dll" ]
