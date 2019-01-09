/*
 *A data structure that serves as a model for a single employee record.
 *
 * */

interface Serializable<T> {
  deserialize(input: Object): T;
}

export class EmployeeModel {
  employeeId: string;
  controlId: string;
  SSN: string;
  firstName: string;
  lastName: string;
  DOB: string;
  gender: string;
  
   constructor(values: Object = {}) {
    Object.assign(this, values);
  }
  
}
