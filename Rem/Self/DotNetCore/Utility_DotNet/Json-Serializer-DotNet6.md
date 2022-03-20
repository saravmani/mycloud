
###### System.Text.JSON vs Newtonsoft.Json
System.Text.JSON - is native and comes with BCL. we no need install any package to use System.Text.JSON.
System.Text.JSON is provides many extenision methods to work with webapi and HttpClient
System.Text.JSON is provides better performance and functionalities when compare to Newtonsoft.Json.


> *We can configure custom policies in System.Text.JSON. (Ex: JsonNamingPolicy)*


###### Async Serialization in System.Text.JSON
``` csharp
var objFileStream = File.Create("text.json")
await JsonSerializer.SerializeAsync(objFileStream, object);

// JsonSerializer.Deserialize
```


###### Extension Methods from System.Text.JSON
* HttpClientJsonExtensions
* HttpContentJsonExtensions

###### HttpClient JSON Extension methods
HttpClientJsonExtensions provides extension methods to make http calls to web-API
  GetFromJsonAsync<ClassType>("URI") -- automatically Deserialize the response in to required format
  PostAsJsonAsync


#### Controlling serialization behaviour with propety attributes
``` csharp
public class Student
{
    [JsonPropertyName("StudentAge")]
    [JsonPropertyOrder(1)]
    public int age { get; set; }
    [JsonIgnore] // Ignores this property
    public int StudentId { get; set; }

}
```

###### JsonSerializerOptions class to configure Json Serializer
``` csharp
// Printing buitifully
JsonSerializerOptions objJsonSerializerOptions = new() { WriteIndented = true };
var str = JsonSerializer.Serialize(obj,objJsonSerializerOptions);
Console.WriteLine(str);// Prints the text beautifully

JsonSerializerOptions objJsonSerializerOptions = new() { JsonSerializerDefaults.Web};
// This handles web based scenarios.
// Ex. Camel Case, Property Name are Cas-INsensitive
JsonSerializerOptions objJsonSerializerOptions = new() {
  PropertyNameCaseInsensitive=true, // To make Case Insensitive
   WriteIndented = true, // Prints the text beautifully
   ReadCommentHandling = JsonCommentHandling.Skip, // Allows comments as part of json string
   ReferenceHandler = ReferenceHandler.Preserve,
   // To preserve circular references. If we not mention this it will throw error.
   // Note in ouput it will add refernece indicators with $ prefix
};


```


###### Custom converts
1. DateTime
2. To handle nullable values
3. TO handle enums
