

ODATA - Microsoft developed it in 2007, which allows the creating and querying of interoperable Restful APIs in a simple way.

GraphQL is a query language for APIs used for fulfilling the queries with the existing data. Facebook developed it in 2015 before public release in 2015.
GraphQL supports joins, relations

OData is RESTFul, which means that it uses the REST pattern like POST, PUT, GET, DELETE to perform the desired operations, whereas GraphQL is not RESTful, which uses the Http with the POST request only in which the query is passed as body content.

OData uses the URL to build the query, which sometimes hampers the size of the request, whereas, in the case of GraphQL, the query has its own definition as it is passed in the body is no issue regarding its size.

>Refer- [OData Vs GraphQL](https://www.educba.com/odata-vs-graphql)







#### OData

##### Nuget Packages
Aspnetcore.odata

services.AddControllers().AddOData(
    options=>options
              .Select()
              .Filter()
              .OrderBy()
);


[EnableQuery]
public Iqueriable<Student> GetStudents()
{

}

Selects only col1, col2 in output
?$select=col1,ok


col1= 'student Name'
?$filter=col1 eq 'student Name'
?$filter=startsWith(col1,'student')
?$filter=colName in ('val1','val2')
?$orderby=colName
?$orderby=colName desc

col1>224
?$filter=col1 gt 224
