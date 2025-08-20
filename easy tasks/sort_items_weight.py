things = {'карандаш': 20, 'зеркальце': 100, 'зонт': 500, 'рубашка': 300,
          'брюки': 1000, 'бумага': 200, 'молоток': 600, 'пила': 400, 'удочка': 1200,
          'расческа': 40, 'котелок': 820, 'палатка': 5240, 'брезент': 2130, 'спички': 10}
items_w = sorted(things.values(), reverse=1)
things = {v:k for k, v in things.items()}
N = int(input())
res1 = 0
result_things = []
for i in range(len(items_w)):
    if res1 <= N*1000 and res1+items_w[i] <= N*1000:
        res1+=items_w[i]
        result_things.append(things[items_w[i]])
print(*result_things)







