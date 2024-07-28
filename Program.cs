using System;
					
public class Program
{	
	static string CriptografiaDeNavios(string codigo)
	{
	  // Declarações iniciais

	  var listaBlocosBinarios = codigo.Split(" ");
	  var TextoConvertido = "";

	  foreach (var blocos in listaBlocosBinarios)
	  {
		var bits = blocos.ToCharArray();

		// Inverte os dois últimos bytes

		bits[6] = (bits[6] == '1') ? '0' : '1';
		bits[7] = (bits[7] == '1') ? '0' : '1';

		// Faz a declaração da variavel necessaria para a proxima etapa

		var bitsTemporarios = (char[])bits.Clone();

		// troca os bytes com os próximos 4

		bits[0] = bitsTemporarios[4];
		bits[1] = bitsTemporarios[5];
		bits[2] = bitsTemporarios[6];
		bits[3] = bitsTemporarios[7];

		bits[4] = bitsTemporarios[0];
		bits[5] = bitsTemporarios[1];
		bits[6] = bitsTemporarios[2];
		bits[7] = bitsTemporarios[3];

		// Adiciona o bloco a variavel

		foreach (var bit in bits)
		{
		  TextoConvertido += bit;
		}
	  }

	  // Transforma o resultado encontrado em bytes para o programa poder tranformar em texto novamente

	  byte[] numerosBinarios = new byte[TextoConvertido.Length / 8];

	  for (int i = 0; i < numerosBinarios.Length; i++)
	  {
		numerosBinarios[i] = Convert.ToByte(TextoConvertido.Substring(8 * i, 8), 2);
	  }

	  return System.Text.Encoding.ASCII.GetString(numerosBinarios);
	}

	
	public static void Main()
	{
		var resultado = CriptografiaDeNavios("10010110 11110111 01010110 00000001 00010111 00100110 01010111 00000001 00010111 01110110 01010111 00110110 11110111 11010111 01010111 00000011");
		Console.WriteLine(resultado);
	}
}