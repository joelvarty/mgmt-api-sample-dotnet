## Testing out the Agility Management SDK for dotnet

Steps to create the project:
```
dotnet new console

dotnet add package Agility.Management.SDK --prerelease
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.Json

```

## Authenticating
- go to `https://mgmt.aglty.io/oauth/authorize` to authenticate
	- updated method for this coming soon...
- copy your auth token from the JSON response

## Code
Check the Program.cs file for the example code


