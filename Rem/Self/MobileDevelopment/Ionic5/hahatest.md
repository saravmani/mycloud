#### trtretre
###### wwwwwwwwwwwww

```
Note: Like Angular, Ionic will not destroy the pages (will not call ngOnDestroy).
      It will cache the pages and store it in stack.
      when user navigates, the previous page will move back to stack
      and next page will get visible
```

Between ngOnInit and ngOnDestroy we are having multiple Ionic view events

+ ngOnInit *(angular event)*
  + ionViewWillEnter  -- called when page start get visible (i.e begins transition)
  + ionViewDidEnter   -- called when page visible completed
  + ionViewWillLeave  -- called when page start leaving (i.e begins transition)
  + ionViewDidLeave   -- called when page completely invisible and other page came to visibe
+ ngOnDestroy *(angular event)*


---

###### Sample Code

```javascript
ionViewWillEnter() {
   this.apiService.FetchData().subscribe(a => {
     this.listOfItems = a;
   },error=>{
     console.log(error);
   });
 }
```


[//]: # (Tags: Ionic , Angular, Page Life Cycle, Page Caching, ionViewWillEnter, ionViewDidEnter, ionViewWillLeave, ionViewDidLeave)
[//]: # (Type: Ionic - Things to know)
[//]: # (Rating: 2)
[//]: # (ReadyState:Publish)