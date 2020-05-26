let sayHiMixin = {
   sayHi() {
      console.log(`Hello ${this.name}`);
   },
   sayBye() {
      console.log(`Bye ${this.name}`);
   }
};
class Person {
   constructor(name) {
      this.name = name;
   }
}
// copy the methods
Object.assign(Person.prototype, sayHiMixin);
new Person("John").sayHi();

// note here we are not using inheritance .. it is just copying method
