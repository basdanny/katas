/*
    get Largest Prime Factor
    https://www.slothparadise.com/largest-prime-factor/
*/
function largestPrimeFactor(a) {
    var b = 2;
    while (a > b) {
        if (a % b == 0) {
            a = a / b;
            b = 2;
        }
        else
            b += 1;
    }

    return b;
}

console.log("Largest Prime Factor: " + largestPrimeFactor(13195));


/*
    get all Primes of a given number
*/
function getPrimes(max) {
    var sieve = [], i, j, primes = [];
    for (i = 2; i <= max; ++i) {
        if (!sieve[i]) {
            // i has not been marked -- it is prime
            primes.push(i);
            for (j = i << 1; j <= max; j += i) {
                sieve[j] = true;
            }
        }
    }
    return primes;
}