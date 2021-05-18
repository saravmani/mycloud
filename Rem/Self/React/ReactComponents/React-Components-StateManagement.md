#### React JS - Components - State Management
###### How to Manage State within React JS Component


###### Maintain Stat within component
useState() is a method provided by framework to maintain the state. *(It is called as HOOK)*.

This method returns 2 values
1. State Object (Simple Javascript base object)
2. Function (Used to update the state)

> Sample code to Demonstrate the State Management within component
```jsx
function TestComponent() {
  const [objState, functionToActOnObj] = useState(123);
  //we can pass default value to useState as a parameter
  //in above line we are assigning 123 to objState
  const handlerFunction = () => functionToActOnObj(objState+1);
	return (
    <button onClick={
       handlerFunction
      }>{objState}</button>
  );
}

ReactDOM.render(
  <TestComponent />,
  document.getElementById('mountNode'),
);
```

> Note: State of the component cannont be accessed outside of the component



[//]: # (Tags: State Management in React Components)
[//]: # (Type: ReactJS - Components)
[//]: # (Rating: 2)
[//]: # (Languages:jsx)
[//]: # (ReadyState:InProgress)
