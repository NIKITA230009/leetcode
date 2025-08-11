names = input().split()
names = list(names)
checking = str(names[0])
checking = checking.lower()
counter = 1
checking = str(names[counter])
checking = checking.lower()
while True:
    word_length = len(checking)-1
    counter+=1
    if checking[0]==checking[word_length]:
        print("ДА")
        break
    elif counter == len(names):
        print("НЕТ")
        break
    else:
        checking = str(names[counter])
        checking = checking.lower()
        continue
