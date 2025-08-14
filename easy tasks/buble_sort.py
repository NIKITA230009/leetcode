numbers = list(map(int, input().split()))
numbers_sort = []
for i, d in enumerate(numbers):
    for index in range(0, len(numbers)-1):
        if numbers[index+1] < numbers[index]:
            temp2=numbers[index]
            numbers[index]=numbers[index+1]
            numbers[index+1]=temp2
        else:continue
print(numbers)