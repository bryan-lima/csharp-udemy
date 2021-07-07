print("-" * 50)
print(f"{'INTERVALO DE NÚMEROS':^50}")
print("-" * 50)

numberRange = range(10, 21)

while True:

    quantityOfNumbers = int(input("\nQuantos números deseja informar?: "))
    counter = 1
    listOfNumbers = []

    print()
    while(counter <= quantityOfNumbers):
        n = int(input(f"Informe o {counter}º número: "))
        listOfNumbers.append(n)
        counter += 1

    inInterval = 0
    outInterval = 0

    for number in listOfNumbers:
        if (number in numberRange):
            inInterval+= 1
        else:
            outInterval+= 1
    
    print("\nRESULTADO:")
    print(f"{inInterval} in")
    print(f"{outInterval} out")
    print("-" * 50, end="\n\n")

    proceed = " "
    while(proceed not in "SN"):
        proceed = str(input("Deseja informar novos números? [S]im/[N]ão: ")).strip().upper()[0]
    if(proceed == "N"):
        break
    print("\n >>> NOVOS NÚMEROS:")