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
///     Setor de uma empresa.
///     Criação : Vovolinux
///     Data    : 29/06/2020
///     Projeto : Objetos genéricos para C#.
/// </summary>

using System.Collections.Generic;
using Objetos.Modelos.Folha;
using static Objetos.Constantes.ConstantesGerais;

namespace Objetos.Modelos.Empresas
{
    public class Setor
    {
        public long IdSetor { get; set; }
        public long IdEmpresa { get; set; }
        public string NomeSetor { get; set; }
        public Colaborador ResponsavelSetor { get; set; }
        public List<Colaborador> Colaboradores { get; set; }

        public Setor()
        {

        }

        public Setor(long idSetor, long idEmpresa, string nomeSetor, Colaborador responsavelSetor, List<Colaborador> colaboradores)
        {
            IdSetor = idSetor;
            IdEmpresa = idEmpresa;
            NomeSetor = nomeSetor;
            ResponsavelSetor = responsavelSetor;
            Colaboradores = colaboradores;
        }

        public override string ToString()
        {
            char sep = SeparadorSplit;
            return IdEmpresa.ToString()
                + sep + IdSetor.ToString()
                + sep + NomeSetor
                + sep + ResponsavelSetor.IdPessoa;
        }
    }
}
