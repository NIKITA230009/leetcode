import sys

# Читаем строки
lst_in = [line.strip().split(":", 1) for line in sys.stdin if line.strip()]

# Создаем словарь с именами писателей как ключами и списками произведений как значениями
books_dict = {}

for name, book in lst_in:
    name = name.strip()
    book = book.strip()
    if name in books_dict:
        books_dict[name].add(book)
    else:
        books_dict[name] = {book}

# Теперь у вас есть словарь с именами и списками произведений
d = books_dict