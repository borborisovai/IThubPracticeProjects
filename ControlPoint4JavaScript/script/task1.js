// Мой код
function cleanDatabase(db) {
  let cleanDB = [];
  for (var i = 0; db.length > i; i++) {
    try {
      let email = db[i]["email"];
      const input = document.createElement("input");
      input.type = "email";
      input.value = email;
      if (input.checkValidity()) {
        cleanDB.push(db[i]);
      }
    } catch (e) {
      console.log("somethink slomalos', skiping...");
    }
  }
  return cleanDB;
}

// Отображение на странице
function Task1() {
  const input = JSON.parse(document.querySelector("#task1 input").value);
  const output = document.querySelector("#task1 h3");
  const result = cleanDatabase(input);

  console.log(result);
  output.innerText = "Ответ: " + JSON.stringify(result);
}

// Тесты
// console.log(
//   cleanDatabase([
//     { name: "Alice", email: "alice@mail.com" },
//     { name: "Bob", email: "bobmail.com" },
//     null,
//     { name: "Charlie", email: "charlie@mail.com" },
//   ]),
// );
