# Run with dapr
```
dapr run --app-id hello-world --app-port 5000 --dapr-http-port 5010 dotnet run
```

# Interact with service
With cUrl:
```
curl http://localhost:5010/v1.0/invoke/hello-world/method/hello
```

With Powershell:
```
Invoke-RestMethod -Uri 'http://localhost:5010/v1.0/invoke/hello-world/method/hello'
```