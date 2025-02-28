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
///     Classificação Nacional de Atividades Econômicas – CNAE.
///     Criação : Vovolinux
///     Data    : 28/06/2020
///     Projeto : Objetos genéricos para C#.
/// </summary>

using static Objetos.Constantes.ConstantesGerais;
using static Objetos.Constantes.EnumTipoCnae;

namespace Objetos.Modelos.Documentos
{
    public class Cnae
    {
        public long IdCnae { get; set; }
        public long IdPessoa { get; set; }
        public TipoCnae TipoCnae { get; set; }
        public string CodigoCnae { get; set; }
        public string DescricaoCnae { get; set; }

        public Cnae()
        {

        }

        public Cnae(long idCnae, long idPessoaJuridica, TipoCnae tipoCnae, string codigoCnae, string descricaoCnae)
        {
            IdCnae = idCnae;
            IdPessoa = idPessoaJuridica;
            TipoCnae = tipoCnae;
            CodigoCnae = codigoCnae;
            DescricaoCnae = descricaoCnae;
        }

        public override string ToString()
        {
            char sep = SeparadorSplit;
            return IdCnae.ToString()
                + sep + IdPessoa.ToString()
                + sep + (int)TipoCnae
                + sep + CodigoCnae
                + sep + DescricaoCnae;
        }
    }
}
