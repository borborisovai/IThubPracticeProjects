const synonyms = {
    "красивый": ["прекрасный", "очаровательный"],
    "быстрый": ["скорый", "стремительный"],
    "умный": ["сообразительный", "интеллектуальный"]
}


synonyms['ffufuy'] = {}


for (let i = 0; i < Object.keys(synonyms).length; i++) {
    let word = Object.keys(synonyms)[i];
    console.log(`Синонимы для слова "${word}"`);
    for (let j = 0; j < synonyms[word].length; j++) {
        let synonym = synonyms[word][j];
        console.log(` - ${synonym}`);
    }
}