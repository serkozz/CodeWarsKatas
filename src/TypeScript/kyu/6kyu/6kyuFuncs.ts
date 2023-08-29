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

/// *** NAME: Stop gninnipS My sdroW!
/// ***
/// *** DESCRIPTION:
/// *** Write a function that takes in a string of one or more words,
/// *** and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata).
/// *** Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.
/// *** 
/// *** spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw"
/// *** spinWords( "This is a test") => returns "This is a test"
/// *** spinWords( "This is another test" )=> returns "This is rehtona test"
/// *** 
/// *** CATEGORY:
/// ***     STRINGS ALGORITHMS 
/// *** 
/// *** Link:
/// ***     https://www.codewars.com/kata/5264d2b162488dc400000001

 
export function spinWords(words: string): string {
    let resultString: string = '';
    let splitted: string[] = words.split(' ');
    splitted.forEach(word => {
        if (word.length < 5)
        {
            resultString += word + ' '
            return
        }
        let reversedWord: string = ''
        for (let i = word.length - 1; i >= 0; i--) {
            reversedWord += word[i]
        }
        resultString += reversedWord + ' ';
    })
    return resultString.trimEnd();
}