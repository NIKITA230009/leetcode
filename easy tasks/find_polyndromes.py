word = input()
word = word.upper()
end_of_word = len(word)
word2 = word[end_of_word::-1]
if word == word2:
    print("ДА")
else:
    print("НЕТ")