// function constructor demo
function Employee(empid, empname, empdob) {
	this.empid = empid;
	this.empname = empname;
	this.empdob = empdob;
}

function AirthOperation(a, b) {
	this.a = a;
	this.b = b;
}

// prototype constructor

AirthOperation.prototype.addition = function () {
	console.log("addition of the numbers are : " + (this.a + this.b));
};
console.log(AirthOperation.prototype);

AirthOperation.prototype.subtraction = function () {
	console.log("subtraction of the numbers are : " + (this.a - this.b));
};
console.log(AirthOperation.prototype);

AirthOperation.prototype.multiplication = function () {
	console.log("multiplication of the numbers are : " + this.a * this.b);
};
console.log(AirthOperation.prototype);

Employee.prototype.calage = function () {
	console.log("age of the employee is: " + (2023 - this.empdob));
};
console.log(Employee.prototype);

// let - it use to create a variable
// const - it use to create a constant

let emp1 = new Employee(1, "shriram", 1950);
console.log(emp1);
emp1.calage();
let emp2 = new Employee(2, "Shri", 1991);
console.log(emp2);
emp2.calage();
let emp3 = new Employee(3, "Ram", 2000);
console.log(emp3);
emp3.calage();

const ar = new AirthOperation(10, 2);
console.log(ar);
ar.addition();
ar.subtraction();
ar.multiplication();
