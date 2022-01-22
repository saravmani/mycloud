
Top to Bottom. Bottom is taking highest priority. in below example Comman line arugments will override others

1.appsettings.json (store the configurations which are NOT env specific)
2.appsettings<env>.json (as per 12 factor principle we should not use this)
3.app secrets (used in development enviroments)
4. Environment Variables
5. Command-line arguments


launchsettings.json is for local development env configuraiton. It will not contain applicaiton or env specific configuration.
It is a launch settings when we hit F5 from visual studio
