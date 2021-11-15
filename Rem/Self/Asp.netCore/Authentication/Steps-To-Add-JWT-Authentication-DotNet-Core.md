#### Steps to add JWT Bearer Authentication in Asp.net 5 and Asp.net Core
###### Simple Steps to add JWT Bearer Authentication in .Net
>

```powershell
PM> Microsoft.AspNetCore.Authentication.JwtBearer
PM> System.IdentityModel.Tokens.Jwt
```

```csharp
//Startup.cs
public void ConfigureServices(IServiceCollection services)
{
      var symKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("KEY_ENCRYPT")); // Note: Can be taken from configuration
      services.AddAuthentication(options =>
      {
          options.DefaultAuthenticateScheme = "JwtBearer";
          options.DefaultChallengeScheme = "JwtBearer";
      })
      .AddJwtBearer("JwtBearer", jwtBearerOptions =>
      {
        // Configure Token Validation Parameters
          jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
          {
            IssuerSigningKey = symKey,
            ClockSkew = TimeSpan.FromMinutes(20), // Note: Can be taken from configuration
            ValidIssuer = settings.Issuer,
            ValidAudiences = new List<string> // Multiple Audiance can be added
                  {
                      "https://audience1.com",
                      ".."
                  },
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidateIssuer = true,
         };
      });
}
```

```csharp
//AuthentProviderController.cs
[HttpPost("AuthenticateUser")]
 public IActionResult AuthenticateUser([FromBody] UserCredentials objUserCredentials)
 {
    // Validate the user name and passwrod with your Authentication logic (Ex: AD, DB etc.,)

      var symKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("KEY_ENCRYPT")); // Note: Can be taken from configuration
      // Create claims object
      var _objClaimList = new List<Claim>
      {
          new Claim(JwtRegisteredClaimNames.Sub, userName),
          new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
          new Claim("CUSTOM_TYPE_NAME1","CUSTOM_VALUE1"),
          new Claim("CUSTOM_TYPE_NAME2","CUSTOM_VALUE2") // More Number of claims can be added
      };

      // Create the JwtSecurityToken object
      var _objJwtToken = new JwtSecurityToken(
          issuer: "YOUR_DOMAIN_NAME", // Note: Can be taken from configuration
          audience: "CLIENT_APP_NAME",  // Note: Can be taken from configuration
          claims: _objClaimList,
          notBefore: DateTime.Now,
          expires: DateTime.Now.AddMinutes(20),  // Note: Can be taken from configuration
          signingCredentials: new SigningCredentials(symKey,SecurityAlgorithms.HmacSha256)
      );
      string jwtToken =  new JwtSecurityTokenHandler().WriteToken(_objJwtToken);

      // JWT Token has generated and we can return this with action result
      //.....
      //.....

```


[//]: # (Tags: Asp.net 5, .Net Core, JWT Bearer, Authentication, Autherisation, Token based Authentication)
[//]: # (Type: Asp.net Core - Authentication)
[//]: # (Rating: 2)
[//]: # (Languages:powershell,powershell,ini)
[//]: # (ReadyState:Inprogress)
