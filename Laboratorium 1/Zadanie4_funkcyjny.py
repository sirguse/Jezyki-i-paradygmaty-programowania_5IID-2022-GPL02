def plackowy_funkcyjny(items, capacity):
    # Rekurencyjna funkcja rozwiązująca problem plecakowy
    def funcyjny_rec(i, w):
        if i == 0 or w == 0:
            return 0, []
        weight, value = items[i - 1]
        if weight > w:
            return funcyjny_rec(i - 1, w)
        else:
            without_item, without_items = funcyjny_rec(i - 1, w)
            with_item, with_items = funcyjny_rec(i - 1, w - weight)
            with_item += value
            if with_item > without_item:
                return with_item, with_items + [items[i - 1]]
            else:
                return without_item, without_items

    return funcyjny_rec(len(items), capacity)

# Przykład użycia
items = [(2, 3), (3, 4), (4, 5), (5, 6)]
capacity = 8
max_value, selected_items = plackowy_funkcyjny(items, capacity)
print(f'Maksymalna wartość: {max_value}, Wybrane przedmioty: {selected_items}')
