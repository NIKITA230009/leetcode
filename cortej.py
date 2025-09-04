t = ((1, 0, 0, 0, 0),
     (0, 1, 0, 0, 0),
     (0, 0, 1, 0, 0),
     (0, 0, 0, 1, 0),
     (0, 0, 0, 0, 1))
t1 = ()
temp = ()
N = int(input())
for i, row in enumerate(t):
    if i == N:
        break
    for j, value in enumerate(row):
        if j == N:
            break
        temp = temp + (value,)
        if len(temp) == N:
            t1 = t1 + (temp,)
            temp = ()
for line, v in enumerate(t1):
    print(*t1[line])
