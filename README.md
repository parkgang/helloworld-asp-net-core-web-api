# helloworld-asp-net-core-web-api

안녕! ASP.NET Core Web API

# Stack

1. vscode
1. .NET 5.0.301

# 프로젝트 생성

```shell
# 해당 디렉터리 내부에서 `-o` 를 안붙이고 생성하면 디렉터리 이름에 맞게 생성되어 c# 컨벤션을 맞추는 수고가 들어갑니다.
# 외부 디렉터리에서 파스칼 케이스로 프로젝트 생성 후 모든 파일을 해당 리포로 퍼오도록 합니다.
dotnet new webapi -o HelloWorldAspNetCoreWebApi
# https 인증서 신뢰
dotnet dev-certs https --trust
```
