phrase = input()
res = ""
for i, d in enumerate(phrase):
        index = str(phrase.find("ра",i,))
        if index not in res:
            res += " "+ str(index)
if len(res)>3:
    res = res.rstrip("-1")
else: res = "-1"
res = res.lstrip(" ")
print(res)