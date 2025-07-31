k = int(input())
days_of_the_week = {1:"понедельник", 2:"вторник", 3:"среда", 4:"четверг", 5:"пятница", 6:"суббота", 7:"воскресенье"}

if k%7==1:
    print(days_of_the_week[1])
elif k%7==2:
    print(days_of_the_week[2])
elif k%7==3:
    print(days_of_the_week[3])
elif k%7==4:
    print(days_of_the_week[4])
elif k%7==5:
    print(days_of_the_week[5])
elif k%7==6:
    print(days_of_the_week[6])
else:
    print(days_of_the_week[7])