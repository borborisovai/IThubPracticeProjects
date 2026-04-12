// Собственно код
function SpyXfamily(){
  const spyData = {
    name: "Джеймс",
    mission: "Взлом",
    codes: ["кот", "404", "мост"],
    contacts: {
        primary: "Лис",
        backup: ["Ёж", "Барсук"]
    },
    secret_notes: "Передать"
  };
  console.log(spyData);

  var result = new Array();

  result = DataHarvest(result, spyData);

  console.log(result);
}

function DataHarvest(variable, dataNode){
  Object.keys(dataNode).forEach(key => {
    console.log(key, dataNode[key], typeof(dataNode[key]));
    if (typeof(dataNode[key]) == 'object'){
      DataHarvest(variable, dataNode[key]);
    }
    else{
      variable.push(dataNode[key]);
    }
    return variable;
  });
}

// Модуль отображения
function Task1(){
  // const input = document.querySelector("#task1 input");
  const output = document.querySelector("#task1 h3");

  output.innerText = "Ответ: " + SpyXfamily();
}

// Тесты
