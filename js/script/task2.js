const inputStyles = {
    backgroundColor: "red",
    fontSize: 16,
    borderRadius: "4px",
    margin: 10
};

// Собственно код
function objectToCssString(styleObj){
    console.log(styleObj);
}

// Модуль отображения
function Task2(){
  // const input = document.querySelector("#task1 input");
  const output = document.querySelector("#task2 h3");

  output.innerText = "Ответ: " + objectToCssString(inputStyles);
}

// Tests


