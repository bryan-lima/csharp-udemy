print("-" * 50)
print(f"{'CALCULAR ÁREA DE UM CÍRCULO':^50}")
print("-" * 50)

while True:
    circleRadius = float(input("\nInforme o valor do raio: "))
    PI = 3.14159
    area = PI * (circleRadius * circleRadius)
    print(f"\nO valor da área deste círculo é {area:.4f}")
    print("-" * 50)
    proceed = " "
    while(proceed not in "SN"):
        proceed = str(input("Deseja calcular a área de outro círculo? [S/N]: ")).strip().upper()[0]
    if (proceed == "N"):
        break

print()
print("-" * 50)
print(f"{'FIM DO PROGRAMA':^50}")