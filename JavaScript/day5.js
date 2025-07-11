// 5. capitalize(uppercase first letter of each word) strings using built in function

const sentence = "hello world"
const words = sentence.split(" ")
console.log(words)
const capitalizedWords = words.map( word => {
    if (word.length === 0) {
        return "";
    }
    return word.charAt(0).toUpperCase() + word.slice(1)
})

const title = capitalizedWords.join(" ")
console.log(title)