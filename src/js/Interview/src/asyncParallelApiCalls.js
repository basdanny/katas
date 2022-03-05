const axios = require('axios');

const lineReader = require("readline").createInterface({
    input: require("fs").createReadStream("./resources/queries.txt"),
});

//simple
// lineReader.on("line", function (line) {
//     getData(line);
// });

//with parallelism
const queue = require('fastq')(worker, 2);

function worker(apiUrl, callback) {
    getData(apiUrl);
    callback(null, null);
}

queue.pause(); //for debug only

lineReader.on("line", function (line) {
    console.log(`adding ${line}`);
    queue.push(line, function (err, result) {
        if (err) { throw err }
        //console.log('the result is', result)        
    })
});

//for debug only
setTimeout(() => {
    queue.resume();
}, 2000);


function getData(apiUrl) {
    axios.get(apiUrl)
        .then(({ data }) => {

            console.log("Results for:", apiUrl);

            console.log(`Total result: ${data?.total_count}`);
            console.log(`Presented results: ${data?.items?.length}`);

            //console.log(data);
        })
        .catch((error) => {
            console.log(`Error occured ${error}`)
        });
}
