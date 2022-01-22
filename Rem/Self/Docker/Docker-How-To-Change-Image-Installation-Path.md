# How to change default Docker image installation path / Direcotory on Windows 10
###### Steps to change default image download path


1.  Stop Docker from your machine
2.  Open *daemon.json* file from the below mentioned path

```csharp
    %programdata%\docker\config
```
3. Find the josn key *data-root* and update the value with the path . If the key not exsits then add the key

```js
Example
      {
          "registry-mirrors": [],
          "insecure-registries": [],
          "debug": false,
          "experimental": false,
          "data-root": "D:\\DockerImages\\",
      }
```

4. Start the docker. From now the images will get installed into new path




[//]: # (Tags: How to change default image download path on Windows 10, Steps to change default image download path, Docker configuration)
[//]: # (Type: Docker - configuration)
[//]: # (Rating: 2)
[//]: # (Languages:json,powershell)
[//]: # (ReadyState:Publish)
