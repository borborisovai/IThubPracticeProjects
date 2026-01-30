let temp = 25
let weather = "clear"

let activity 
if (weather == "clear" && temp >= 25){
    activity = "golf"
}
else if (weather == "cloudy" && temp >= 10 && temp <= 24){
    activity = "bowling"
}
else {
    activity = "hiking"
}