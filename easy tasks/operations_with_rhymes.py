t = [["Скажи-ка", "дядя", "ведь", "не", "даром"],
     ["Я", "Python", "выучил", "с", "каналом"],
     ["Балакирев", "что", "раздавал?"]]
t = sum(t, [])
word = input()
a = ""
a = a.join(t)
test = a.find(word)
final_test = test>=0
print(final_test)

