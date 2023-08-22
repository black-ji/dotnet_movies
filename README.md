# dotnet_movies
/n.Run this command to run the database server in your linux system(wsl in my case):sudo docker run -e "ACCEPT_EULA=Y" -e 'MSSQL_SA_PASSWORD=yourStrong(!)Password' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
/nTo determine the server wether it is localhost(if you are working in a linux system) or another ip run:ip addr show eth0 | grep -Po 'inet \K[\d.]+'
/nAdd this property : TrustServerCertificate=true; to the connectionstrings in appsettings.json and to the env in the DockerFile if you encounter any error with ssl. 
