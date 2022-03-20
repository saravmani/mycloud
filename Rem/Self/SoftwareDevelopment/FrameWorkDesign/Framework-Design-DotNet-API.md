

###### DB Framework with EntityFramewrok
  Auditable should be the base class for all Domain POCO classes


```csharp
public class Auditable
{
  public string CreatedBy { get; set; }
  public string ModifiedBy { get; set; }
  public DateTime? CreatedAt { get; set; }
  public DateTime? ModifiedAt { get; set; }
}
```
