﻿using System;
using System.IO; //utilizado para manipulação de arquivos

namespace Ex_Gravar_Arquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter("c:\\5by5\\Test.txt"); //Instancia um objeto
                //sw.WriteLine("Treinamento de C#"); //Escreve uma linha no arquivo
                //sw.WriteLine("Escrita de Arquivos com StreamWriter");
                sw.WriteLine("maria;araraquara;190;contato;");
                sw.WriteLine("fabio;araraquara;911;recado;");
                sw.Close(); //Comando para fechar o arquivo
            }catch (Exception e)
            {
                Console.WriteLine("Exception: "+e.Message);
            }
            finally
            {
                Console.WriteLine("Executando o Bloco de Comandos.");
            }
        }
    }
}
