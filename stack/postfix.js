/**
 * @param {string[]} tokens
 * @return {number}
 */
var evalRPN = function(tokens) {
    let str =[]
    for(token of tokens){
        if(!isNaN(token)){
            str.push(parseInt(token));
            console.log(str);
        }
        else{
            let val1  = str.pop();
            let val2 = str.pop();
            if(token== '+') str.push(val2+val1);
           else  if(token == '*') str.push(val2*val1);
            else if(token == '/') str.push(Math.trunc(val2/val1));
           else  if(token == '-') str.push(val2-val1);
           console.log(str);
        }
    }
    console.log(str);
    return parseInt(str.pop());
    // ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
};
