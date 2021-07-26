
###### Rolling updates
  Simple CF push will make applicaiton down for some time till deployment completes.
  Rolling update  will do the deployment one instance by one instance. Atleast one instance will be in running state

######Blue-Green Stragey (Safest. Blue to green stragegy)
  Deploy the new version in seperate instance with new route. And the we test the applicaiton with new URL.
  Then we can map the Original route to the new route. then delete the old applicaiton.
  It is like swapping algorithm 
