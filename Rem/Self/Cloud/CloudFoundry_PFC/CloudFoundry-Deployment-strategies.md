
###### Rolling updates
  Simple CF push will make applicaiton down for some time till deployment completes.
  Rolling update  will do the deployment one instance by one instance. Atleast one instance will be in running state

###### Blue-Green Stragey (Safest. Blue to green stragegy)
  Deploy the new version in seperate instance with new route. And the we test the applicaiton with new URL.
  Then we can map the Original route to the new route. then delete the old applicaiton.
  It is like swapping algorithm




  ###### Revisions (i.e Deployment versions)
  We can relate Revisions to applicaiton versions. If we want to reverse back to old version
  of the deplyment we can use this revisions to rollback.
  A revision represents code and configuration used by an app at a specific time.
  This allows you to deploy a version of the app that you had running previously without needing to track that previous state yourself or have multiple apps running.
  > *Even if we update the environment variable this will create a new revision*
