# Task 4: Web Scraper
# Scrape book names, ratings and prices from books.toscrape.com (Travel category)
# Store data in a csv file and display it at the end

import csv
import requests
from bs4 import BeautifulSoup

url = "https://books.toscrape.com/catalogue/category/books/travel_2/index.html"

rating_words = {
    "One"   : 1,
    "Two"   : 2,
    "Three" : 3,
    "Four"  : 4,
    "Five"  : 5
}

response = requests.get(url)
soup = BeautifulSoup(response.content, 'html.parser')

articles = soup.find_all('article', class_='product_pod')

fname = "books.csv"
heading = ["Title", "Rating", "Price"]
rows = []

for article in articles:
    title = article.h3.a['title']
    rating_class = article.p['class'][1]
    rating = rating_words.get(rating_class, 0)
    price = article.find('p', class_='price_color').text.strip()
    rows.append((title, rating, price))

try:
    with open(fname, "w+", newline='', encoding='utf-8') as fhand:
        csv_writer = csv.writer(fhand)
        csv_writer.writerow(heading)
        csv_writer.writerows(rows)

        print("\nData scraped successfully.")
        print("CSV file is ready: ", fname)
        print("\nTotal books found: ", len(rows))

        fhand.seek(0)

        print("\nReading data from csv file:")
        print("-" * 50)
        reader = csv.reader(fhand, delimiter=",")
        for row in reader:
            print(row)

except Exception as e:
    print("Error: ", e)
