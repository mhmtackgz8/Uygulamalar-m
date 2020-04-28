const a=new Object();
a.name="mehmet";
console.log(a);


function x(name,age){
    this.name=name;
    this.age=age;
    this.showInfos=function(){
        console.log("Bilgiler Görüntüleniyor");
    }
}
const ab= new x("mehmet",25);
console.log(ab);
console.log(ab.toString());