print("-" * 50)
print(f"{'AUTENTICAÇÃO':^50}")
print("-" * 50)

PASSWORD = 2002

while True:
    passwd = int(input("\nInforme a senha: "))
    if(passwd != PASSWORD):
        print("Senha inválida.")
    else:
        print("Acesso permitido.")
        break
