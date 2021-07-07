from math import sqrt

print("-" * 50)
print(f"{'CÁLCULO DE EQUAÇÃO DO SEGUNDO GRAU':^50}")
print("-" * 50)

while True:
    coefficientA = float(input("Coeficiente A: "))
    coefficientB = float(input("Coeficiente B: "))
    coefficientC = float(input("Coeficiente C: "))

    if(coefficientA == 0):
        print("\nImpossível calcular!\nCoeficiente A não pode ser 0 (zero).\nTente novamente.")
    else:
        delta = coefficientB * coefficientB - 4 * coefficientA * coefficientC
        if (delta < 0):
            print("\nImpossível calcular!\nValor de delta deu negativo.\nTente novamente.")
            break
        else:
            x1 = (-coefficientB + sqrt(delta)) / (2 * coefficientA)
            x2 = (-coefficientB - sqrt(delta)) / (2 * coefficientA)
            print("\nRESULTADOS:")
            print(f"X1 = {x1:.5f}")
            print(f"X2 = {x2:.5f}")
    print("-" * 50, end="\n\n")
    proceed = " "
    while(proceed.upper() not in "SN"):
        proceed = str(input("Deseja efetuar novo cálculo? [S]im/[N]ão: ")).strip().upper()[0]
    if(proceed == "N"):
        break
    print("\n >>> NOVO CÁLCULO:\n")