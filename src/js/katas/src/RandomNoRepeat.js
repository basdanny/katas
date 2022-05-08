/* 
    Given a list of 100 songs on your cell phone, find a way for each user to hear the songs without repeating songs
*/

let songs = [
    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'
];




let songsLength = songs.length;
let usedCount = 0;

for (let i = 0; i < songsLength; i++) {
    let songIndex = Math.floor((Math.random() * (songsLength - usedCount))); //random between 0 and last index of NON played songs
    console.log(songIndex+"\t Playing: " + songs[songIndex]); //playing a song
    songs[songIndex] = songs[songsLength - 1 - usedCount]; //putting in an index of the played song a song from the end of the array
    usedCount++;
}
