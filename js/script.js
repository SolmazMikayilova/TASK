//task1
/*let n=2442;
let a=(n-(n%1000))/1000;//2
let b=((n%1000)-(n%100))/100;//4
let c=((n%100)-(n%10))/10;//4
let d=n%10;//2
let result=a+(b*10)+(c*100)+(d*1000)
if(result==n && n>0){
    console.log("YES");
}else{
    console.log("NO");
}*/


//task2
/*let a=-2100;
let b=a/1000;
if((b>=1 && b<10) || (b>-10 && b<=-1)){
    if(((a%3==0 && a%7==0)) || (a<0)){
        console.log(false);//3ə və 7-yə bölünəndirsə
    } else{
        console.log(true);
    }
}else{
    console.log(false);//4 reqemli deyilse
}*/


//task3
/*let n=1789;
if(n>0){
    console.log(n%10);
}else{
    console.log("is not natural number");
}*/




//task4
/*let num=-4582;
let a=(num-(num%1000))/1000;//4
let b=((num%1000)-(num%100))/100;//5
let c=((num%100)-(num%10))/10;//8
let d=num%10;//2
let result=(d*1000)+(c*100)+(b*10)+a;
if(num>0){
console.log(result);
}else{
    console.log("is not natural number");
} */




//task6 3reqemli=>true
/*let a=195;
let b=a/100;
if((b>=1 && b<10) || (b>-10 && b<=-1)){
    console.log(true);
}else{
    console.log(false);
}
*/


//task7
/*let num1 = 100;
let num2 = 20;
var opr;
switch (opr) {
    case "addition":
        console.log(num1+num2);
        break;
    case "subtraction":
        console.log(num1 - num2);
        break;
    case "multiplication":
        console.log(num1 * num2);
        break;
    case "division":
        console.log(num1 / num2);
        break;
    default:
        console.log("invalid input");
        break;
}
*/

