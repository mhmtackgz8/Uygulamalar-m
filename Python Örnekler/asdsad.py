import random
list=[0,1,2,3,4,5,6,7,8,9,0]
yenilist=[]
b=random.choice(list)
c=random.choice(list)
d=random.choice(list)
e=random.choice(list)
list.pop(b)
list.pop(c)
list.pop(d)
list.pop(e)
yenilist.append(list)
print(yenilist)

