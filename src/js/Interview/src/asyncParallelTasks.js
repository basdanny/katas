const axios = require('axios');
const { DynamicPool } = require('node-worker-threads-pool');

const lineReader = require("readline").createInterface({
  input: require("fs").createReadStream("./resources/tasks.txt"),
});

console.time("total_time");

const queue = require('fastq')(worker, 4);
const workersPool = new DynamicPool(4, { shareEnv: true });
let activeWorkersCounter = 0;

function worker(taskDef, callback) {
  activeWorkersCounter++;
  console.log(`activeWorkersCounter: ${activeWorkersCounter}`);
  workersPool
    .exec({
      task: () => {
        const { taskDef } = this.workerData;
        console.log(`executing: ${taskDef}`);

        (function () { //simulate compute intensive processing
          let result = 0;
          for (var i = Math.pow(9, 7); i >= 0; i--) {
            result += Math.atan(i) * Math.tan(i);
          };
        })();
      },
      workerData: { taskDef }
    })
    .then((result) => {
      console.log(`executed: ${taskDef}`);
      activeWorkersCounter--;
      console.log(`activeWorkersCounter: ${activeWorkersCounter}`);
      callback(null, null);
    });
}

//queue.pause(); //for debug only

lineReader.on("line", function (line) {
  console.log(`adding ${line}`);
  queue.push(line, function (err, result) {
    if (err) { throw err }
    //console.log('the result is', result)        
  })
});


// //for debug only
// setTimeout(() => {
//     queue.resume();
// }, 1000);


queue.empty = (() => {
  console.log(`The queue is empty`);
  exitIfFinished();
});

function exitIfFinished() {
  if (activeWorkersCounter <= 0) {
    workersPool.destroy();
  } else {
    setTimeout(() => {
      exitIfFinished();
    }, 100);
  }
}

process.on('exit', function () {
  console.timeEnd("total_time");
});

