

```powershell
> db # show current working db
> show dbs #list of available dbs
> use db_name # Switch to the database.

```
>Note: While we run **use db_name** If db doesn't exist then it will switch the context and when we create the first document, actual db will get created

###### To Insert Data
```js
db.createCollection('Students') // New collection
show collections //To display the list of collections
db.Students.insertMany({[
  {
    "StudentName": "Some Name1"
  },
  {
    "StudentName": "Some Name2"
  }
]})

db.Students.find({}).pretty()
// To display the data from document
db.Students.remove({})
// To delete all the documents from the collection
```


###### To Display Data
```js
db.Students.find({}).pretty()
// To display the data from document
db.Students.remove({})
// To delete all the documents from the collection
```
