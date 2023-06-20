##### To get data from web url
Invoke-WebRequest -Uri "https://someurl.com/file.json" -OutFile ~/ouput_file.json


##### To format the output
Get-AzResource | Format-Table
