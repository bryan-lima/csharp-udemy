import sqlite3

conn = sqlite3.connect("ex2.1_dogao.db")

cursor = conn.cursor()

cursor.execute("""
CREATE TABLE snacks (
        id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
        description TEXT NOT NULL,
        price REAL
);
""")

print("Table successfully created.")

conn.close()