def str_min(str1, str2):

    if str1 < str2:
        res_str1 = str1
    else: res_str1 = str2
    return res_str1

def str_min3(str1, str2, str3):

    res_str1 = str_min(str1,str2)
    res_str2 = str3 if str3<res_str1 else res_str1
    return res_str2


def str_min4(str1, str2, str3, str4):

    res_str1 = str_min(str1,str2)
    res_str2 = str_min(str3, str4)
    res_str3 = res_str1 if res_str1<res_str2 else res_str2
    return res_str3

# print(str_min(*input().split()))
# print(str_min3(*input().split()))
# print(str_min4(*input().split()))