
const fetch = require('node-fetch');

let urls = [
  'https://api.github.com/users/a',
  'https://api.github.com/users/b',
  'https://api.github.com/users/c'
];

// map every url to the promise fetch(github url)
let requests = urls.map(url => fetch(url));

// Promise.all waits until all jobs are resolved
Promise.all(requests)
  .then(responses => responses.forEach(
    response => console.log((`${response.url}: ${response.status}`))
  ));

console.log('the END');
