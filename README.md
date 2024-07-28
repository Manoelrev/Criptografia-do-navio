
# Criptografia-do-navio
Desafio do navio pela Intelitrader

 
Desafio proprosto pela Empreasa Intelitrader onde o desafio é conseguir descriptografar especifico;

Foram utilizadas 2 regras Basicas para a resolução do projeto

### A cada 8 bits, os dois últimos estão invertidos

```csharp
    bits[6] = (bits[6] == '1') ? '0' : '1';
    bits[7] = (bits[7] == '1') ? '0' : '1';
```

### A cada 4 bits, os 4 bits foram trocados com os próximos 4.

```csharp
    
	bits[0] = bitsTemporarios[4];
	bits[1] = bitsTemporarios[5];
	bits[2] = bitsTemporarios[6];
	bits[3] = bitsTemporarios[7];

	bits[4] = bitsTemporarios[0];
	bits[5] = bitsTemporarios[1];
	bits[6] = bitsTemporarios[2];
	bits[7] = bitsTemporarios[3];
```

### Codigo para conversão de ASCII para texto

```csharp
    byte[] numerosBinarios = new byte[TextoConvertido.Length / 8];

	for (int i = 0; i < numerosBinarios.Length; i++)
	{
	numerosBinarios[i] = Convert.ToByte(TextoConvertido.Substring(8 * i, 8), 2;
    }

    return System.Text.Encoding.ASCII.GetString(numerosBinarios);

```

Esse codigo foi feito de Maneira a facilitar o entendimento e compreensão do codigo e pode ser baixado ou testado atraves do site:

[Link para o programa](https://dotnetfiddle.net/M02dYU)

