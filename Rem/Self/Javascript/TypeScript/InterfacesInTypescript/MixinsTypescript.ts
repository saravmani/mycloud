best mixin tutorial. just less than 10 mins read time required
https://alligator.io/typescript/mixins/

export class Car {
  drive(name:string) {
    console.log(`This ${name} can drive very fast`);
  }
}

export class Lorry {
  carry(weight:number) {
    console.log(`This vehicle can carry ${weight} kg`);
  }
}

//export class Truck extends Car,Lorry {} // error: Classes can only extend a single class

export interface Truck extends Car, Lorry {}

applyMixins(Truck, [Car, Lorry]);

const truck = new Truck();
truck.drive("truck"); // This truck can drive very fast
truck.carry(10); // This vehicle can carry 10 kg


//blow function is utility function. have to copy this to code
function applyMixins(derivedCtor: any, baseCtors: any[]) {
  baseCtors.forEach(baseCtor => {
    Object.getOwnPropertyNames(baseCtor.prototype).forEach(name => {
      Object.defineProperty(derivedCtor.prototype, name, Object.getOwnPropertyDescriptor(baseCtor.prototype, name));
    });
  });
}
