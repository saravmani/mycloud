
##### Data Frame
It is Pandas data structure
two dimensional


##### Ways to read and  files
```python
df = pd.read_excel("filename.xlsx","shee1")
df = pd.read_csv("filename.csv",header=0)
# also we can read from Tuples, List of Dictionary,

df.to_csv("filename.csv",index=false)
df.to_csv("filename.csv",columns=["column1","column2"])
df.to_excel("filename.xlsx","shee1")

# To write 2 data framew into different sheets
with pd.ExcelWriter("xlfilname.xlsx") as writer
  df1.to_excel(writer,"shee1")
  df2.to_excel(writer,"shee2")
```

##### Data cleansing
```python
df = pd.read_csv("filename.csv",na_values = ["Not Mapped","NA"])
# This will replace - Not Mapped, NA  - to NAN in ALL the columns

df = pd.read_csv("filename.csv",na_values = {
'column1': ["Not Mapped","NA"],
'column2': ["Other Value1"]
})
# above code will replace NAN on specific columns with mapped values
```

##### Index with Pandas
To Se the index column (i.e by default data framew  will contain its own index)
```python
df.set_index('column1',inplace=true)
# inplace=true will update the index in df object. other wise it will not update the original copy
```

```python
# To Get the values by index column
df.loc['ColName1']
```
