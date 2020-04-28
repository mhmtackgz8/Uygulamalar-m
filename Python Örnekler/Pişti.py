import random
Kartlar=["Karo:As","Karo:2","Karo:3","Karo:4","Karo:5","Karo:6","Karo:7","Karo:8","Karo:9","Karo:10","Karo:BACAK",
"Karo:KIZ","Karo:PAPAZ","Kupa:As","Kupa:2","Kupa:3","Kupa:4","Kupa:5","Kupa:6","Kupa:7","Kupa:8","Kupa:9","Kupa:10","Kupa:BACAK",
"Kupa:KIZ","Kupa:PAPAZ","Maça:As","Maça:2","Maça:3","Maça","Maça:5","Maça:6","Maça:7","Maça:8","Maça:9","Maça:10","Maça:BACAK",
"Maço:KIZ","Maço:PAPAZ","Sinek:As","Sinek:2","Sinek:3","Sinek:4","Sinek:5","Sinek:6","Sinek:7","Sinek:8","Sinek:9","Sinek:10","Sinek:BACAK",
"Sinek:KIZ","Sinek:PAPAZ"]




class KartlarıKarıştır:
    def __init__(self): 
      random.shuffle(Kartlar)
      print("Kartlar Karıştırıldı")


class kartlarıdağıt:
    def __init__(self):

        print(random.choice(Kartlar))
        print(random.choice(Kartlar))
        print(random.choice(Kartlar))
        print(random.choice(Kartlar))

class Oyuncu1:
    def __init__(self,isim):
       
        self.isim=isim
        self.kartsayisi = 4
        print(isim+" " "adlı  Oyuncunun Kartları:")
        self.eldekikartlar = [kartlarıdağıt()]
        
       
Oyuncu1("MEHMET")
class Oyuncu2:
    def __init__(self,isim):
      
        self.isim=isim
        self.kartsayisi = 4
        print(isim+" " " adlı oyuncunun kartları:")
        self.eldekikartlar = [kartlarıdağıt()]
        self.Kartlar=Kartlar

Oyuncu2("MURAT")


class yerdekikağıtlar:
     def __init__(self):
        print("Yere Gelen Kartlar")
        print(random.choice(Kartlar))
        print(random.choice(Kartlar))
        print(random.choice(Kartlar))
        print(random.choice(Kartlar))
yerdekikağıtlar()

