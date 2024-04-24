#### Azure CLi COmmand

>Refer
https://learn.microsoft.com/en-us/azure/virtual-machines/windows/quick-create-cli#code-try-1

##### Tips
1. we can enter \ in mid of lengthy command and continue in next line
2. How to get required fileds only in the query output ? See below
```powershell
    az vm list --query '[].{name:name,tags:tags}'
```

```powershell
    az Group list # list of resource groups
    az vm list # list of VMs
```

###### To Update Tags to resource group
```powershell
    az group update -n "395-853d3c3e-add-remove-and-update-tags-for-resou" \
    > --tags "Env=Prod" "Dept=IT"
```
