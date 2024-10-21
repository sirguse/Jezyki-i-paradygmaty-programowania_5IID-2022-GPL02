from functools import reduce

def Funkcyjne(tasks):
    # Sortujemy zadania po czasie zakończenia
    sorted_tasks = sorted(tasks, key=lambda x: x[1])

    def select_non_conflicting(acc, task):
        last_end_time = acc[-1][1] if acc else 0
        if task[0] >= last_end_time:
            acc.append(task)
        return acc
    
    selected_tasks = reduce(select_non_conflicting, sorted_tasks, [])
    max_reward = sum(task[2] for task in selected_tasks)

    return max_reward, selected_tasks

tasks = [(1, 3, 50), (2, 5, 10), (4, 6, 70), (6, 7, 30), (5, 8, 30)]
reward, schedule = Funkcyjne(tasks)
print("Maksymalna nagroda:", reward)
print("Optymalny harmonogram:", schedule)
