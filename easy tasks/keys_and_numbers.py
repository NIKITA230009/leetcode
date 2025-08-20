lst_in = list(map(str, input().split()))
codes = [s[:2] for s in lst_in]
unique_codes = []
for code in codes:
    if code not in unique_codes:
        unique_codes.append(code)
codes = unique_codes
key = {k:[""] for k in codes}
for i in range(len(codes)):
    for index in range(len(lst_in)):
        if codes[i] in lst_in[index]:
            key[codes[i]].append(lst_in[index])
for k in key:
    if "" in key[k]:
        key[k].remove("")
print(*sorted(key.items()))

