lst = list(map(str, input().split()))
subname = lst[2]
patronym = lst[1]
patronym = list(patronym)
patronym = patronym[0]+"."
name = lst[0]
name = list(name)
name = name[0]+"."
FIO = subname+" "+name+patronym
print(FIO)