/// *** NAME: Human Readable Time
/// ***
/// *** DESCRIPTION:
/// *** Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
/// ***
/// *** HH = hours, padded to 2 digits, range: 00 - 99
/// *** MM = minutes, padded to 2 digits, range: 00 - 59
/// *** SS = seconds, padded to 2 digits, range: 00 - 59
/// *** The maximum time never exceeds 359999 (99:59:59)
/// ***
/// *** You can find some examples in the test fixtures.
/// *** 
/// *** CATEGORY:
/// ***     DATETIME MATHEMATICS ALGORITHMS 
/// *** 
/// *** Link:
/// ***     https://www.codewars.com/kata/52685f7382004e774f0001f7
export function humanReadable(seconds: number): string {
    let minutes = Math.floor(seconds / 60);
    seconds = seconds % 60;
    let hours = Math.floor(minutes / 60)
    minutes = minutes % 60
    return (hours < 10 ? '0' + hours.toString() : hours.toString()) + ':'
        + (minutes < 10 ? '0' + minutes.toString() : minutes.toString()) + ":"
        + (seconds < 10 ? '0' + seconds.toString() : seconds.toString())
}