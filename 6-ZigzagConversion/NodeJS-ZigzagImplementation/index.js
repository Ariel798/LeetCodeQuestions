let s = 'DUNCANMCARDLE';
let numOfRows = 4;
console.log(zigzagString(s,numOfRows));
// function zigzagString(inputString, targetRows) {
//     if (targetRows == 1) {
//         return inputString;
//     }

//     // Start the process on row 1, heading down
//     let currentRow = 1;
//     let headingDown = true;

//     // Initialise an array to store the zigzag data
//     let zigZagArray = [];

//     // Loop through the requested number of rows
//     for (let i = 0; i < targetRows; i++) {
//         // Initialise each zigzag row as an empty array
//         zigZagArray[i] = [];
//     }

//     // Loop through the string
//     for (let i = 0; i < inputString.length; i++) {
//         // Add the current letter to the current row
//         zigZagArray[currentRow - 1].push(inputString[i]);

//         if (headingDown) {
//             currentRow++;

//             // Check if we've exceeded the maximum number of rows
//             if (currentRow > targetRows) {
//                 // Start heading back up again
//                 currentRow = targetRows - 1;
//                 headingDown = false;
//             }
//         } else {
//             currentRow--;

//             // Check if we've exceeded the top row
//             if (currentRow < 1) {
//                 // Start heading down again
//                 currentRow = 2;
//                 headingDown = true;
//             }
//         }
//     }

//     // Initialise a return string
//     let totalString = '';

//     // Loop through the constructed rows
//     for (let i = 0; i < targetRows; i++) {
//         // Append the row's characters joined together
//         totalString += zigZagArray[i].join('');
//     }

//     return totalString;
// };
 function zigzagString(inputString, targetRows) {
     let arrOfRows =[];
     let countRows = 1;
     for(let i =0; i< targetRows; i++){
         arrOfRows[i] = [];
     }
     let goingDown = true;
  
     for(let counter = 0; counter < inputString.length; counter++){
         arrOfRows[countRows - 1].push(inputString[counter]);
         if(goingDown){
             countRows++;
             if(countRows>targetRows){
                 goingDown = false;
                 countRows = targetRows-1;
             }
         }else{
             countRows--;
             if(countRows<1){
                 countRows = 2;
                 goingDown = true;
             }
         }
     }
     let string = ''; 
     for(let indx = 0; indx < arrOfRows.length; indx++){
         string += arrOfRows[indx].join('');
     }
     return string;
 }