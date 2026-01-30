const catalog = {
    items: [
        { name: "Ноутбук", price: 50000, category: "Электроника", quanity: 5 },
        { name: "JavaScript для начинающих", price: 1500, category: "Книги", quanity: 10 },
        { name: "Электрочайник", price: 3000, category: "Бытовая техника", quanity: 3 },
    ]
}

// Самый дорогой товар и его цену
let mostExpencive
for (let i = 0; i < catalog.items.length; i++) {
    if (i == 0) {
        mostExpencive = catalog.items[i]
    }

    let item = catalog.items[i]
    mostExpencive = item.price > mostExpencive.price ? item : mostExpencive
}
console.log(`Самый дорогой товар: "${mostExpencive.name}". Цена: ${mostExpencive.price}`)

console.log("-----")

// Общую стоимость всех товаров на складе (цена × количество)
let TotalPrice = 0
let TotalAmount = 0
for (let i = 0; i < catalog.items.length; i++) {
    let item = catalog.items[i]
    TotalPrice += item.price * item.quanity
    TotalAmount += item.quanity
}
console.log(`Всего товаров: ${TotalAmount}. Общая цена: ${TotalPrice} `)

console.log("-----")

// Все товары из категории "электроника"
console.log(`Список товаров в категории "Электроника"`)
for (let i = 0; i < catalog.items.length; i++) {
    let item = catalog.items[i]
    if (item.category == "Электроника"){
        console.log(`- "${item.name}": ${item.price}$`)
    }
}



