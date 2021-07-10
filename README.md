# helloworld-asp-net-core-web-api

> 안녕! ASP.NET Core Web API

1. [해당 문서](https://docs.microsoft.com/ko-kr/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio)를 통한 탬플릿 입니다.
1. Web Server 실행 후 아래의 기능을 사용해 볼 수 있습니다.
   1. `restful-api.http` 혹은 `https://localhost:5001/swagger/index.html` 으로 API를 테스트 해볼 수 있습니다.
      1. in-memory database 이므로 앱이 시작될 때마다 초기화 됩니다.
   1. `https://localhost:5001` 으로 GUI 형태의 앱을 사용할 수 있습니다.

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

# 디버깅

vscode에서 하단에 알림으로 디버깅 파일이 없음으로 만들어준다는 알림이 있어 `Yes` 를 통해 자동으로 생성되었습니다.
