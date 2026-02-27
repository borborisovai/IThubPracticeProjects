// Код взятый из интернета https://stackoverflow.com/questions/13955738/javascript-get-the-second-digit-from-a-number
function getDigit(number, n) {
  return Math.floor((number / Math.pow(10, n - 1)) % 10);
}

function getDigitCount(number) {
  return Math.max(Math.floor(Math.log10(Math.abs(number))), 0) + 1;
}

// Мой код
function sumOfDigits(digits){
    let result = 0;
    console.log(digits);
    for (let i = 0; i < getDigitCount(digits)+1; i++) {
        digit = getDigit(digits, i)
        result += digit;
    }
    return result;
}

function Task1(){
  const input = document.querySelector("#task1 input");
  const output = document.querySelector("#task1 h3");

  output.innerText = "Ответ: " + sumOfDigits(input.valueAsNumber);
}

// Тесты
// console.log(sumOfDigits(123));
// console.log(sumOfDigits(8888));
// console.log(sumOfDigits(5670));
// console.log(sumOfDigits(4623));