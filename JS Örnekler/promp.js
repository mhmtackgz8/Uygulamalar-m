let secenek =(prompt("Dikgörtgenin Alanı İçin:1  Dikgörtgenin Çevresi için:2"));
secenek=Number(secenek);
let sayi1,sayi2,sonuc;

switch(secenek){
    case 1:
       let  Alan=()=>{
            sayi1=prompt(("Uzun Kenarı Giriniz"));
            sayi1=Number(sayi1);
            sayi2=prompt(("Kısa Kenarı Giriniz"));
            sayi2=Number(sayi2);
            sonuc=-sayi1*sayi2;
        }
          Alan();
          document.write(("Dikgörtgenin Çevresi"+":",sonuc));
    if
    (sayi1==" " && sayi2==" ");
    {
    alert("Lütfen Sayı Giriniz")
    }
    if(sayi1<=0 && sayi2<=0){
        alert("eksi değerde kenar uzunluğu ya da alan olamaz yeniden giriş yapınız")
        }
     break 
    case 2:
        
   let  cevre=()=>{

    sayi1=prompt(("Kenar Giriniz"));
    sayi1=Number(sayi1);
    sayi2=prompt("2.Kenar Giriniz");
    sayi2=Number(sayi2);
    sonuc=2*(sayi1+sayi2);
}
    
    cevre();
    document.write("Dikgörtgenin Çevresi"+":",sonuc);
    if
    (sayi1==" " && sayi2==" ")
    {
        alert("Lütfen Sayı Giriniz") 
    }
    if(sayi1<=0 && sayi2<=0){
        alert("eksi değerde kenar uzunluğu ya da alan olamaz yeniden giriş yapınız")
        }
    break
    default:
        alert("Sadece 1 veya 2 girebilirsiniz");
}

