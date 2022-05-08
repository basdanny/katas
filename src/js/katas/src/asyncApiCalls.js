const axios = require('axios');

const lineReader = require("readline").createInterface({
    input: require("fs").createReadStream("./resources/queries.txt"),
});


lineReader.on("line", function (line) {
    getData(line);
});


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
