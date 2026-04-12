// Мой код
function checkObj(object) {
  // YOUR [[OBJECT]] IS NOT [Heart shaped]! GET [[$3.99]] AWAY FROM [My beauty]!
  return typeof object.particle != "undefined";
}

// Отображение на странице

function Task3() {
  const input = JSON.parse(document.querySelector("#task3 input").value);
  const output = document.querySelector("#task3 h3");
  const result = checkObj(input);

  console.log(result);
  output.innerText = "Ответ: " + JSON.stringify(result);
}

// Тесты
// console.log(checkObj({ id: 1, particle: 10 })); // true
// console.log(checkObj({ id: 2, name: "tag" })); // false
