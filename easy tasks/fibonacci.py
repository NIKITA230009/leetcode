user = int(input())
fibonacci = [1,1]
counter = 3
current = 0
while counter<=user:
    fibonacci.append(fibonacci[current]+fibonacci[current+1])
    counter+=1
    current+=1
print(*fibonacci)