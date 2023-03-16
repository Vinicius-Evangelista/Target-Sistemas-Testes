import json

daily_sells_path = open("./daily_sells.json")
daily_sells = json.load(daily_sells_path)

def print_month_report():
    print(f"""Best Day : {get_best_day()}
Worst Day : {get_worst_day()}
Month Media : {get_month_media()}
Days above month media : {get_days_above_month_media()} 
    """)

def get_best_day():
    best_day = daily_sells[0]

    for day in daily_sells:
        if day["valor"] > best_day["valor"]:
            best_day = day

    return best_day["dia"]

def get_worst_day():
    worst_day = daily_sells[0]

    for day in daily_sells:
        if day["valor"] < worst_day["valor"]:
            worst_day = day

    return worst_day["dia"]

def get_days_above_month_media():
    days_above_moth_media = []
    moth_media = get_month_media()

    for day in daily_sells:
        if day["valor"] > moth_media:
            days_above_moth_media.append(day)

    return days_above_moth_media
    

def get_month_media():
    sells_sum = 0

    for sells in daily_sells:
        sells_sum += sells["valor"]
    
    month_media = sells_sum/int(len(daily_sells))


    return month_media

def main():
    print_month_report()

if __name__ == '__main__':
    main()