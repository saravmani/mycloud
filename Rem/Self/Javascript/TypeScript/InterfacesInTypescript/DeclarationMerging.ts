interface Alligator {
  eyes: number;
  nose: number;
}

interface Alligator {
  tail: number;
}

// contains properties from both Alligator interfaces
const gator: Alligator = {
    eyes: 2,
    nose: 1,
    tail: 1
};
/*
When two or more declarations are declared with the same name, TypeScript merges them into one.
this is called "Declaration Merging"
*/
