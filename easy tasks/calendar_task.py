m,d  = map(int, input().split())

# Количество дней в каждом месяце (не високосный год)
days_in_month = {
    1: 31, 2: 28, 3: 31, 4: 30, 5: 31, 6: 30,
    7: 31, 8: 31, 9: 30, 10: 31, 11: 30, 12: 31
}
prev_month = m - 1 if m > 1 else 12
next_month = m + 1 if m < 12 else 1
prev_day = d -1 if d > 1 else days_in_month[m-1]
m2 = m
if d == 1:
    m = prev_month
elif d in {28,30,31}:
    m2 = next_month
else:
    pass

if d < days_in_month[m]:
    next_day = d + 1
else:
    next_day = 1

print(f"{m:02}.{prev_day:02} {m2:02}.{next_day:02}")




