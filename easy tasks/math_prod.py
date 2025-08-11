import math
number = int(input())
digits = []
while number%10 != 0:
    digits.append(number%10)
    number = number//10
digits.reverse()
result = math.prod(digits)
print(result)

