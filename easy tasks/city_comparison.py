cities = list(map(str, input().split()))
res=True
equal_cities = [city.lower() for city in cities]
for i in range(len(cities)-1):
    city_check1 = equal_cities[i]
    city_check2 = equal_cities[i+1]
    if city_check1[len(city_check1)-1] in ['ь','ъ','ы']:
        if city_check1[len(city_check1)-2] != city_check2[0]:
            res = False
            break
    elif city_check1[len(city_check1)-1] != city_check2[0]:
        res=False
        break
print("ДА" if res==True else "НЕТ")
