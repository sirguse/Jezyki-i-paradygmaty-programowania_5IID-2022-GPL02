def Proceduralny(tasks):
    #Sortujemy zadania po czasie zakończenia
    tasks.sort(key=lambda x: x[1])
    
    #Wybieramy pierwsze zadanie
    selected_tasks = [tasks[0]]
    last_end_time = tasks[0][1]
    max_reward = tasks[0][2]  
    
   
    for i in range(1, len(tasks)):
        start_time, end_time, reward = tasks[i]
        if start_time >= last_end_time:  
            selected_tasks.append(tasks[i])
            last_end_time = end_time
            max_reward += reward
    
    return max_reward, selected_tasks


tasks = [(1, 3, 50), (2, 5, 10), (4, 6, 70), (6, 7, 30), (5, 8, 30)]
reward, schedule = Proceduralny(tasks)
print("Maksymalna nagroda:", reward)
print("Optymalny harmonogram:", schedule)
