FROM microsoft/dotnet:1-sdk-msbuild
COPY ./src/kot/ /app
WORKDIR /app
 
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
RUN ["dotnet", "ef", "database", "update"]
 
EXPOSE 5000/tcp
#ENV ASPNETCORE_URLS http://*:5000
 
ENTRYPOINT ["dotnet", "run"]