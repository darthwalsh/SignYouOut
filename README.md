# SignYouOut

SignYouOut is a simple Windows web server that listens to POST requests and logs out the current user.

This is useful when you have two people using the same computer, and you want to sign them out automatically when you log in.

I orignally wanted to quser.exe to 

## Set up

```
dotnet publish -c Release
mkdir %PROGRAMDATA%\SignYouOut\
copy /Y bin\Release\netcoreapp2.1\publish\ %PROGRAMDATA%\SignYouOut\
```

On the other account, create a Scheduled Task:

- Triggered on account log on
- Run `dotnetw.exe` with args `C:\ProgramData\SignYouOut\SignYouOut.dll`

On your account, create a Scheduled Task:

- Triggered when your account logs in, or unlocks, or when your user connects to user session remotely
- Run `powershellw.exe` with args `-c "curl.exe http://localhost:13168 -X POST -d ''"`
 
Instead of using "Run whether user is logged on or not" to avoid creating a console app, you can use [Vittel/RunHiddenConsole](https://github.com/Vittel/RunHiddenConsole) to compile `dotnetw.exe` and `powershellw.exe`.
