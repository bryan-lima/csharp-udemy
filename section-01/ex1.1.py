print("-" * 40)
print(f"{'LOJA':^40}")
print("-" * 40)

products = []
counter = 1

while True:
    print("\n" + f"{str(counter) + 'º PRODUTO':^40}")
    print("-" * 40)
    produtCode = int(input("Cód. da peça: "))
    productQuantity = int(input("Quantidade: "))
    produtcUnitValue = float(input("Valor unitário: R$ "))
    products.append([produtCode, productQuantity, produtcUnitValue])
    proceed = ' '
    print()
    while proceed not in "SN":
        proceed = str(input("Há mais produto? [S/N]: ")).strip().upper()[0]
    if proceed == "N":
        break
    counter += 1

amount = 0

for product in products:
    calculate = product[1] * product[2]
    amount += calculate

print("-"* 40)
print(f"Valor a pagar: R$ {amount:.2f}")