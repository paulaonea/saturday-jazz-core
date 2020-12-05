FROM mcr.microsoft.com/dotnet/runtime:5.0

COPY src/SaturdayJazz.Host/bin/Debug/netcoreapp5.0 /app

CMD [ "dotnet", "/app/SaturdayJazz.Host.dll" ]
