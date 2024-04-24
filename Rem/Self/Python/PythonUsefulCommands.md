

#### To Crete and activate  virtual environment
This will help us to install the package locally (like NPM )
```powershell
## To Create new virtual envrionment
py -m venv .venv

## And run below command
.venv/scripts/activate
```

If Virtual env not able to set in virtual code then set then run below command and try again
```powershell
Set-ExecutionPolicy RemoteSigned
```

#### PIP commands
```powershell
## Install packages
pip install <PackageName>

## to copy all the required package details (Like package.json in npm)
pip freeze > requirements.txt

## Install packages using requirements.txt file
pip install -r requirements.txt

```
