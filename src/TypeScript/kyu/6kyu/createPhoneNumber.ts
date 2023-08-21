
console.log(createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]))

export function createPhoneNumber(digits: number[]): string {
    let number: string = ""
    digits.forEach((el, id) => {
        if (id === 0)
            number += "("
        number += el.toString() 
        if (id === 2)
            number += ") "
        if (id === 5)
            number += "-"
    });
    return number;
}