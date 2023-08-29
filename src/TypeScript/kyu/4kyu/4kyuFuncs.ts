/// *** NAME: Next bigger number with the same digits
/// ***
/// *** DESCRIPTION:
/// *** Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits. For example:
/// ***
/// ***  12 ==> 21
/// *** 513 ==> 531
/// *** 2017 ==> 2071
/// *** If the digits can't be rearranged to form a bigger number, return -1 (or nil in Swift, None in Rust):
/// ***
/// ***  9 ==> -1
/// *** 111 ==> -1
/// *** 531 ==> -1
/// *** 
/// *** CATEGORY:
/// ***     STRINGS REFACTORING
/// *** 
/// *** Link:
/// ***     https://www.codewars.com/kata/55983863da40caa2c900004e
export function nextBigger(n: number): number {
    const combine = (arr: number[], k: number, withRepetition = false): number[][] => {
        const combinations: any[] = []
        const combination = Array(k)
        const internalCombine = (start: number, depth: number): void => {
            if (depth === k) {
                combinations.push([...combination])
                return
            }
            for (let index = start; index < arr.length; index++) {
                combination[depth] = arr[index]
                internalCombine(index + (withRepetition ? 0 : 1), depth + 1)
            }
        }
        internalCombine(0, 0)
        return combinations
    }

    function min(arr: number[], predicate: (num: number) => boolean): number {
        let min: number = 0
        arr.forEach((val, ind) => {
            if (!predicate(val))
                return
            min = min <= val ? min : val
        })
        return min
    }

    const digits: string[] = [...n.toString()];
    const numbers: number[] = []
    const combinations = combine(digits, digits.length, false)
    return 0
}