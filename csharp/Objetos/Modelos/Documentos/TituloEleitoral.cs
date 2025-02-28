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
///     Título Eleitoral.
///     Criação : Vovolinux
///     Data    : 28/06/2020
///     Projeto : Objetos genéricos para C#.
/// </summary>

using System;
using Objetos.Modelos.Enderecos;
using static Objetos.Constantes.ConstantesGerais;

namespace Objetos.Modelos.Documentos
{
    public class TituloEleitoral
    {
        public bool IdentificacaoBiometricaTitulo { get; set; }
        public string NumeroInscricaoTitulo { get; set; }
        public int ZonaTitulo { get; set; }
        public int SecaoTitulo { get; set; }
        public Municipio MunicipioTitulo { get; set; }
        public UF UfTitulo { get; set; }
        public DateTime DataEmissaoTitulo { get; set; }

        public TituloEleitoral()
        {

        }

        public TituloEleitoral(
            bool identificacaoBiometricaTitulo,
            string numeroInscricaoTitulo,
            int zonaTitulo,
            int secaoTitulo,
            Municipio municipioTitulo,
            UF ufTitulo,
            DateTime dataEmissaoTitulo)
        {
            IdentificacaoBiometricaTitulo = identificacaoBiometricaTitulo;
            NumeroInscricaoTitulo = numeroInscricaoTitulo;
            ZonaTitulo = zonaTitulo;
            SecaoTitulo = secaoTitulo;
            MunicipioTitulo = municipioTitulo;
            UfTitulo = ufTitulo;
            DataEmissaoTitulo = dataEmissaoTitulo;
        }

        public override string ToString()
        {
            char sep = SeparadorSplit;
            return IdentificacaoBiometricaTitulo.ToString()
                 + sep + NumeroInscricaoTitulo
                 + sep + ZonaTitulo.ToString()
                 + sep + SecaoTitulo.ToString()
                 + sep + MunicipioTitulo.CodigoMunicipio
                 + sep + UfTitulo.IdUf
                 + sep + DataEmissaoTitulo.ToString();
        }
    }
}
