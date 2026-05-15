// Мой код
let users = [];

function AddUser(firstname, lastname, age) {
  let user = {
    id: length(users) + 1,
    firstname: firstname,
    lastname: lastname,
    age: age,
  };
  users.push(user);
}

function UpdateUser(id, firstname = "", lastname = "", age = "") {}

function DeleteUser(id) {}

function Task4() {
  const input = document.querySelector("#task4 input");
  const output = document.querySelector("#task4 h3");

  output.innerText = "Ответ: " + sumOfDigits(input.valueAsNumber);
}

// Тесты
// console.log(sumOfDigits(123));
// console.log(sumOfDigits(8888));
// console.log(sumOfDigits(5670));
// console.log(sumOfDigits(4623));
