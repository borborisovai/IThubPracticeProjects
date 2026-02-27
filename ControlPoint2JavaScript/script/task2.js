function generateSequence(start, end, step=1){
    let i = start;
    const result = [];
    for (; i < end; i += step) {
        result.push(i);   
    }
    return result
}

function Task2(){
  const inputs = document.querySelectorAll("#task2 input");
  const output = document.querySelector("#task2 h3");

  output.innerText = "Ответ: " + generateSequence(inputs[0].valueAsNumber, inputs[1].valueAsNumber, inputs[2].valueAsNumber);
}

// Тесты
// console.log(generateSequence(1, 10));
// console.log(generateSequence(5, 50, 5));
// console.log(generateSequence(0, 50, 2));
// console.log(generateSequence(70, 2));