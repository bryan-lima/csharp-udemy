import sqlite3

conn = sqlite3.connect("ex2.1_dogao.db")

cursor = conn.cursor()

# cursor.execute("""
# INSERT INTO snacks (description, price)
# VALUES ('Cachorro quente', 4)
# """)

# cursor.execute("""
# INSERT INTO snacks (description, price)
# VALUES ('X-Salada', 4.50)
# """)


# cursor.execute("""
# INSERT INTO snacks (description, price)
# VALUES ('X-Bacon', 5)
# """)

# cursor.execute("""
# INSERT INTO snacks (description, price)

# VALUES ('Torrada simples', 2)
# """)

# cursor.execute("""
# INSERT INTO snacks (description, price)
# VALUES ('Refrigerante', 1.50)
# """)


snackList = [
    ('Cachorro quente', 4),
    ('X-Salada', 4.50),
    ('X-Bacon', 5),
    ('Torrada simples', 2),
    ('Refrigerante', 1.50)
]

cursor.executemany("""
INSERT INTO snacks (description, price)
VALUES (?,?)
""", snackList)


conn.commit()

print("Data entered successfully.")

conn.close()