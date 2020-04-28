// const merhaba=firstname=>document.write("Merhaba"+" "+firstname);


// merhaba("Ayşe");

// const dikgörtgenincevresi=(uzunkenar,kısakenar)=>{
//     document.write(2*(uzunkenar+kısakenar));
// }
// dikgörtgenincevresi(6,8);


const durum=(vize,final,a)=>{
    a=vize*0.2+final*0.8;
    if (a=>50) {
    document.write("Geçtiniz ortalamanız:"+" "+a);
        
    }
    else{
        document.write("Kaldınız Ortalamanız:"+" "+a);
    }


    durum();


}