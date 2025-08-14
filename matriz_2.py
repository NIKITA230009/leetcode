import sys
indeces = []
# считывание списка из входного потока
s = sys.stdin.readlines()
lst_in = [list(map(int, x.strip().split())) for x in s]
for row, value1 in enumerate(lst_in):
    for column, value2 in enumerate(lst_in[row]):
        if value2 == 1:
            indeces.append([row,column])
for i, [row, col] in enumerate(indeces):
    # Проверяем всех 8 соседей
    if [row-1, col-1] in indeces:  # верхний-левый
        print("НЕТ")
        break
    if [row-1, col] in indeces:    # верхний
        print("НЕТ")
        break
    if [row-1, col+1] in indeces:  # верхний-правый
        print("НЕТ")
        break
    if [row, col-1] in indeces:    # левый
        print("НЕТ")
        break
    if [row, col+1] in indeces:    # правый
        print("НЕТ")
        break
    if [row+1, col-1] in indeces:  # нижний-левый
        print("НЕТ")
        break
    if [row+1, col] in indeces:    # нижний
        print("НЕТ")
        break
    if [row+1, col+1] in indeces:  # нижний-правый
        print("НЕТ")
        break
else:
    print("ДА")