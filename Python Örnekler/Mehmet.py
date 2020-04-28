import random
class pistibasla:
    def __init__(self,oyuncular):
        self.o1=oyuncular[0]
        print("1. oyuncu:",self.o1)
        self.o2=oyuncular[1]
        print("2. oyuncu:",self.o2)
        self.o1elinde=[]
        self.o2elinde=[]
        self.yerde=[]
        self.Kartlar=["Karo:1","Karo:2","Karo:3","Karo:4","Karo:5","Karo:6","Karo:7","Karo:8","Karo:9","Karo:10","Karo:11","Karo:12","Karo:13",
                 "Kupa:1","Kupa:2","Kupa:3","Kupa:4","Kupa:5","Kupa:6","Kupa:7","Kupa:8","Kupa:9","Kupa:10","Kupa:11","Kupa:12","Kupa:13",
                 "Maça:1","Maça:2","Maça:3","Maça","Maça:5","Maça:6","Maça:7","Maça:8","Maça:9","Maça:10","Maça:11","Maça:12","Maça:13",
                 "Sinek:1","Sinek:2","Sinek:3","Sinek:4","Sinek:5","Sinek:6","Sinek:7","Sinek:8","Sinek:9","Sinek:10","Sinek:11","Sinek:12","Sinek:13"]
        print("Kartlarım:",self.Kartlar)
        print("Şu an",len(self.Kartlar),"adet kart var\n")
        self.karthazirla()
        
    def karthazirla(self):
      random.shuffle(self.Kartlar)
      print("Kartlar karıştırıldı:",self.Kartlar)
      print("Şu an",len(self.Kartlar),"adet kart var\n")

      self.yerde+=random.sample(self.Kartlar,4)
      for i in self.yerde:
          self.Kartlar.pop(self.Kartlar.index(i))
      print ("Yerdeki kartlar:",self.yerde)
      print("Kartlardan yerin kartları çıkarıldı:",self.Kartlar)
      print("Şu an",len(self.Kartlar),"adet kart var\n")
      
      self.o1elinde+=random.sample(self.Kartlar,4)
      for i in self.o1elinde:
          self.Kartlar.pop(self.Kartlar.index(i))
      print (self.o1,"in elindeki kartlar:",self.o1elinde)
      print("Kartlardan",self.o1,"in kartları çıkarıldı:",self.Kartlar)
      print("Şu an",len(self.Kartlar),"adet kart var\n")

      self.o2elinde+=random.sample(self.Kartlar,4)
      for i in self.o2elinde:
          self.Kartlar.pop(self.Kartlar.index(i))
      print (self.o2,"in elindeki kartlar:",self.o2elinde)
      print("Kartlardan",self.o2,"in kartları çıkarıldı:",self.Kartlar)
      print("Şu an",len(self.Kartlar),"adet kart var\n")
      
oyuncular=["Mehmet","Adem"]
basla=pistibasla(oyuncular)

    









