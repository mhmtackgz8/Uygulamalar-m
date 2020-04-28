const a={
    number1:10,
    number2:20
};

const b={
    number1:30,
    number2:40
};
function sayiekle(number3,number4){
    console.log(this.number1+this.number2+number3+number4);

}

sayiekle.call(a,100,200);