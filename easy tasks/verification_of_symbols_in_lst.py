lst = list(map(int, input().split()))
checking = lst[0]>lst[len(lst)-1]
lst.append(checking)
print(*lst)