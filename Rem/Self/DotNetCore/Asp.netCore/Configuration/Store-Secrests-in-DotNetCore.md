


Never store passwords or other sensitive data in source code. Production secrets shouldn't be used for development or test. Secrets shouldn't be deployed with the app. Instead, production secrets should be accessed through a controlled means like environment variables or Azure Key Vault.


In production we can use environment variables to set the secrets (ex: db password, api key etc.,)
In development environment we can use secret manager. It is safer


###### Environment variable approch for prod
Environment variables are used to avoid storage of app secrets in code or in local configuration files. Environment variables override configuration values for all previously specified configuration sources.
A default database connection string is included in the project's appsettings.json file with the key DefaultConnection. The default connection string is for LocalDB, which runs in user mode and doesn't require a password. During app deployment, the DefaultConnection key value can be overridden with an environment variable's value. The environment variable may store the complete connection string with sensitive credentials.


###### Secret Manager for development environment
The Secret Manager tool stores sensitive data during the development of an ASP.NET Core project. In this context, a piece of sensitive data is an app secret. App secrets are stored in a separate location from the project tree. The app secrets are associated with a specific project or shared across several projects. The app secrets aren't checked into source control.
But secret manager can be used only for development purpose, this should not be considered as trusted one
