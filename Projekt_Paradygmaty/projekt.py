import requests # Wykonywanie zapytań HTTP
import tkinter as tk
from tkinter import messagebox



def get_weather(city,api): #Tworzę funkcję w której użyje wcześniej dodanego api oraz nazwy miasta
    base_url = "http://api.openweathermap.org/data/2.5/weather"

    query_parametrs = {
        "q": city, #Nazwa miasta
        "appid": api, # Api
        "units": "metric",  # Metryka, czyli celsjusz
    }
    try:
        response = requests.get(base_url, params=query_parametrs) #requests.get przyjmuje parę parametrów, w tym parms, pozwala przekazać dane w formie query string, które zostaną dołączone do base_url
        response.raise_for_status() #Sprawdza status odpowiedzi http. Jeżeli zwróci error, metoda ta zgłosi wyjątek HTTPError
        return response.json() # Zwraca dict z wynikiem

    except requests.exceptions.RequestException as e:
        messagebox.showerror("Error", f"Failed to fetch weather data: {e}")
        return None
    

def display_weather(data): # Wyświetla dane, które zostały wzięte funkcją get_weather
    if not data: # Jeżeli nie otrzymałem informacji z get_weather
        result_label.config(text="No data available.") # Wysyłam label, czyli napis w tkinterze "No data available"
        return
    # Pobieram dane, które następnie dopasowywuje do zmiennej, domyślnie ustawiam "N/A oraz inne" w celu gdyby nie było informacji, to żebym coś zwrócił
    city = data.get("name", "Unknown location")
    weather = data.get("weather", [{}])[0].get("description", "No description")
    temperature = data.get("main", {}).get("temp", "N/A")
    humidity = data.get("main", {}).get("humidity", "N/A")
    pressure = data.get("main", {}).get("pressure", "N/A")
  
    result = (
        f"Pogoda w: {city}\n"
        f"Opis: {weather} \n"
        f"Temperatura: {temperature}°C \n"
        f"Wilgotność: {humidity}% \n"
        f"Ciśnienie: {pressure} \n"
    )
    result_label.config(text=result)


def fetch_weather(): # Podobnie jak get_weather pobiera, lecz w tym przypadku jest pobierana i wykorzystana w gui
    city = city_entry.get().strip() # Pole w którym .get zwraca tekst wprowadzony przez użytkownika w polu tekstowym ENTRY
    if not city:
        messagebox.showwarning("Warning", "Please enter a city name.") # tworze prosty messagebox, który wyskakuje w momencie gdy użytkownik nic nie wpisze, a będzie chciał szukać.
        return
    
    weather_data = get_weather(city, api) # Łączę funkcje
    display_weather(weather_data)

api = "7292999b147206239926a1c9c519398b"


root = tk.Tk()
root.title("Aplikacja pogodowa")

city_label = tk.Label(root, text="Enter city name:")
city_label.pack(pady=5)

city_entry = tk.Entry(root, width=30)
city_entry.pack(pady=5)

fetch_button = tk.Button(root, text="Get Weather", command=fetch_weather)
fetch_button.pack(pady=10)

result_label = tk.Label(root, text="", justify="left", anchor="w")
result_label.pack(pady=10, padx=10)


root.mainloop()



