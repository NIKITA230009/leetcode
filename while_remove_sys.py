import sys
# считывание списка из входного потока
lst_in = list(map(str.strip, sys.stdin.readlines()))
# здесь продолжайте программу (используйте список lst_in)
counter = len(lst_in)-1
while counter >= 0:
    if " " in lst_in[counter]:
        lst_in.remove(lst_in[counter])
        counter-=1
    else:
        counter-=1
        continue
print(*lst_in)