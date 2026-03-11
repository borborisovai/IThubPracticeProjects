function snakeMatrix(scale){
    var number = 1;
    var arr = new Array(scale); 
    for (let i = 0; i < scale; i++) {
        arr[i] = new Array(scale);
        for (let a = 0; a < scale; a++) {
            (i % 2) == 1 ? arr[i][scale - a - 1] = number : arr[i][a] = number;
            number++;
        }
    }
    return arr;
}

function Task3(){
  const input = document.querySelector("#task3 input");
  const result = snakeMatrix(input.valueAsNumber);

// Фигня для отображения таблички которуя скомуниздил со Stack Owerflow
    var table = document.createElement("table");
    for (var i of result){
        var row = table.insertRow();
        for (var a of i) 
        { 
            let cell = row.insertCell(); cell.innerHTML = a; 
        }
    }

    document.querySelector("#task3").removeChild(document.querySelector("#task3 table"));
    document.querySelector("#task3").appendChild(table);

}



