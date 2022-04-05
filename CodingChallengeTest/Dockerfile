#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.


FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["./CodingChallengeTest/CodingChallengeTest.csproj", "./CodingChallengeTest/"]
COPY ["./CodingChallenge/CodingChallenge.csproj", "./"]
RUN dotnet restore
COPY . .



FROM build AS testrunner
WORKDIR /src/CodingChallengeTest/
CMD ["dotnet", "test", "CodingChallengeTest.csproj"]