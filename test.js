
console.log("hello");

var x = 1000;

function double (something) {
  return something *2;
}

 var car = {
  make: "toyota",
  model: "sedan",
  mpg: 32,
  highwayMpg: 40,
  color: "red"
};

var x = car;

console.log(x.make);
console.log(x.model);
console.log(double(x.mpg));
