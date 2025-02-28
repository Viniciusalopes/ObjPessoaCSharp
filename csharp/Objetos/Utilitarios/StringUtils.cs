﻿/// <licenca>
///     Licença MIT
///     Copyright(c) 2020 Viniciusalopes Tecnologia
///     
///     A permissão é concedida, gratuitamente, a qualquer pessoa que obtenha uma cópia deste software e dos 
///     arquivos de documentação associados (o "Software"), para negociar no Software sem restrições, 
///     incluindo, sem limitação, os direitos de uso, cópia, modificação, fusão, publicar, distribuir, 
///     sublicenciar e/ou vender cópias do Software e permitir que as pessoas a quem o Software é fornecido 
///     o façam, sob as seguintes condições:
///     
///     O aviso de direitos autorais acima e este aviso de permissão devem ser incluídos em todas as cópias 
///     ou partes substanciais do Software.
///     
///     O SOFTWARE É FORNECIDO "TAL COMO ESTÁ", SEM GARANTIA DE QUALQUER TIPO, EXPRESSA OU IMPLÍCITA, 
///     INCLUINDO MAS NÃO SE LIMITANDO A GARANTIAS DE COMERCIALIZAÇÃO, ADEQUAÇÃO A UMA FINALIDADE ESPECÍFICA 
///     E NÃO INFRAÇÃO. EM NENHUM CASO OS AUTORES OU TITULARES DE DIREITOS AUTORAIS SERÃO RESPONSÁVEIS POR 
///     QUALQUER REIVINDICAÇÃO, DANOS OU OUTRA RESPONSABILIDADE, SEJA EM AÇÃO DE CONTRATO, TORT OU OUTRA 
///     FORMA, PROVENIENTE, FORA OU EM CONEXÃO COM O SOFTWARE OU O USO, OU OUTROS ACORDOS NOS PROGRAMAS.
/// </licenca>
/// <summary>
///     Utilitários para manipulação de strings.
///     Criação : Vovolinux
///     Data    : 28/06/2020
///     Projeto : Objetos genéricos para C#.
/// </summary>

using System;

namespace Objetos.Utilitarios
{
    public static class StringUtils
    {
        /// <summary>
        ///     Retornar somente os números de uma string.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>
        ///     Somente números 0123456789.
        /// </returns>
        /// <remarks>
        ///     FONTE: https://pt.stackoverflow.com/questions/25469/como-extrair-somente-n%C3%BAmeros-de-uma-string
        ///     ^ dentro de um conjunto([]) significa negação.
        ///     \d atalho para 0 - 9, ou seja, números;
        ///     Em poucas palavras a regex significa tudo que não é número;
        /// </remarks>
        public static string somenteNumeros(string texto)
        {
            return String.Join("", System.Text.RegularExpressions.Regex.Split(texto, @"[^\d]"));
        }

        public static string repetir(string texto, int vezes)
        {
            string retorno = "";
            for (int i = 0; i < vezes; i++)
                retorno += texto;
            
            return retorno;
        }

        public static string indentacao(string linha, int tamanho, bool avancar)
        {
            string retorno = (avancar) ? repetir(" ", tamanho) : "";

            foreach (char c in linha)
            {
                if (!c.Equals(' '))
                    break;

                retorno += ' ';
            }

            return retorno;
        }

        #region CRIPTOGRAFIA

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        #endregion CRIPTOGRAFIA
    }
}
