let isLogged = true;
let hasPermission = false;
let isAdmin = true;
let age = 25;
let hasDiscount = true;
let itemCount = 3;

// Пример 1
console.log(isLogged && hasPermission);                     // 1
console.log(isLogged || hasPermission);                     // 2
console.log(!isLogged);                                     // 3
console.log(!!"isLogged");                                    // 4

// Пример 2
console.log(isLogged && hasPermission || isAdmin);          // 5
console.log(isLogged && (hasPermission || isAdmin));        // 6
console.log(!isLogged || !hasPermission);                   // 7
console.log(!(isLogged || hasPermission));                  // 8

// Пример 3: 
let result1 = isAdmin && console.log("Админ вошел!");
let result2 = hasPermission || console.log("Нет прав!");

// Пример 4:
console.log(age >= 18 && isLogged);                         // 9
console.log(age > 18 && age < 65);                          // 10
console.log(itemCount > 0 && itemCount <= 10);              // 11

// Пример 5:
let accessLevel = age >= 18 ? "Взрослый" : "Ребенок";
console.log(accessLevel);                                   // 12

let price = 100;
let finalPrice = hasDiscount ? price * 0.9 : price;
console.log(finalPrice);                                    // 13

// Пример 6:
let username = null;
let defaultName = "Гость";
let displayName = username ?? defaultName;
console.log(displayName);                                   // 14

// Пример 7:
let complex1 = true || false && false;
let complex2 = (true || false) && false;
let complex3 = !true && false || true;
console.log(complex1, complex2, complex3);                  // 15