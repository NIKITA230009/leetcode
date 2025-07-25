string = input()
string = list(string)
string.remove("+")
string.remove("7")
string.insert(0, "8")
string.remove("-")
string.remove("-")
lst = string
print("".join(lst))
