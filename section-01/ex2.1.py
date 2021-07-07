import sqlite3

print(f"\n{'>>>>> DOGÃO DO RATÃO <<<<<':^50}")

print()
print("-" * 50)
print(f"{'TABELA DE PREÇOS':^50}")
print("-" * 50)
print(f"{'CÓDIGO':<13}{'ESPECIFICAÇÃO':<25}{'PREÇO':<12}")

conn = sqlite3.connect("ex2.1_dogao.db")
cursor = conn.cursor()
cursor.execute("""
SELECT * FROM snacks;
""")

listSnack = cursor.fetchall()

for item in listSnack:
    print(f"{item[0]:<13}{item[1]:<25}R$ {item[2]:<12.2f}")

conn.close()

print("-" * 50)
print(f"{'<<< Faça seu pedido! >>>':^50}\n")

while True:
    snackCode = int(input("Cód. do lanche: ")) - 1
    if snackCode <= 0 or snackCode >= len(listSnack):
        print("Código de lanche inválido! Tente novamente.")
    else:
        break

snackQuantity = int(input("Quantos lanches chefia?: "))
print("-" * 50)

total = listSnack[snackCode][2] * snackQuantity

print(f"Valor total: R$ {total:.2f}")