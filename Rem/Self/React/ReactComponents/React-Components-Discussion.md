#### React JS - Components
###### Discussion on React JS component or Class component. Most prefered is Class components

1. Components are resuable. Basically those are functions
2. One component can contain other components
3. Components can manage private state


React Js as name suggests it is reactive. Based on input changes it modfy the output (i.e In our case output is UI).
Mostly react will not directly work with DOM. It uses mostly Virtual dom for comparison

In React JS we will not write direct HTML. We write in JSX  syntax and it looks like HTML. At compile time JSX syntax will get converted into JS reperesentation.

> Babel is a JSX compiler
> https://babeljs.io/ Check babel palyground to unerstand how JSX code compiled into JS code
> we can write react js without JSX. But we have to write more javascript code for that

###### Example how JSX get converted into JS reperesentation at compile time
```jsx
<span>Some Text</span>
// While compile time this get converted into JS reperesentation as below
React.CreateElement("span",null,"Some Text");
```

> Note : React component name should start with uppercase. If we use small case then react will think it is a HTML element

> Sample React Component
```jsx
function TestComponent() {
  const [objState, functionToActOnObj] = useState(1);
  const handlerFunction = () => functionToActOnObj(objState+1);
	return (
    <button onClick={
       handlerFunction
      }>{objState}</button>
  );
}

ReactDOM.render(
  <>
    <TestComponent />
    <div>test div</div>
  </>,
  document.getElementById('mountNode'),
);

/*
Note Empty tags <> in render method's param.This is called React.Fragment
We can't place multiple components at root level.The root component always should be one.
But within root component we can have multiple child components.
So we can use any parent component such div , span etc., But to avoid creating unwanted dom element  react is providing React.Fragment.
This will not create dom element but just a wrapper
*/
```


> We can write inline arrow functions in click event
```js
function TestComponent() {
	return <button onClick={ ()=>{console.log('haha')}  }>Test</button>;
}
```


[//]: # (Tags: React Components)
[//]: # (Type: ReactJS - Components)
[//]: # (Rating: 2)
[//]: # (Languages:jsx)
[//]: # (ReadyState:InProgress)
