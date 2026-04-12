// Мой код
function logString(...strings) {
  let result = "";
  for (let i = 0; strings.length > i; i++) {
    result = result + strings[i];
    if (
      !strings[i].endsWith(" ") &&
      strings.length != i + 1 &&
      !strings[i + 1].startsWith(" ")
    ) {
      result = result + " ";
    }
  }
  return result;
}

// Отображение на странице
var Task2variables = [];

document.addEventListener("DOMContentLoaded", async () => {
  Task2AddInput();
});

function Task2AddInput(str) {
  const input = document.querySelector("#task2inputs");
  const newInput = document.createElement("input");
  input.appendChild(newInput);
  Task2variables.push(newInput);
  newInput.value = str == undefined ? "" : str;
}

function Task2() {
  // const input = document.querySelector("#task2 input");
  const output = document.querySelector("#task2 h3");

  output.innerText =
    "Ответ: " + logString(...Task2variables.map((e) => e.value));
}

// Тесты
// console.log(logString("Hello", "my", "world!"));
// console.log(logString("Goodbie ", "cruel", " world! "));
