# SvcEnum
Enumerate Windows Services.

## Compile
Use Visual Studio and add System.ServiceProcess as a reference or use [mcs](https://linux.die.net/man/1/mcs) via:
```bash
 mcs SvcEnum.cs -sdk:4.5 -r:System.ServiceProcess.dll -out:SvcEnum.exe
```

## Usage:
```
[+] SvcEnum: Enumerate Windows Services.
[>] LinkedIn: https://www.linkedin.com/in/andresdoreste/

Usage:

 Get all services: 'SvcEnum.exe all'
 Get Services with CanStop & CanShutdown set to true: 'SvcEnum.exe canstop'
```
