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
///     Persistencia em arquivo para PessoaFisica.
///     Criação : Vovolinux
///     Data    : 29/06/2020
///     Projeto : Objetos genéricos para C#.
/// </summary>

using System;
using System.Collections.Generic;
using Interfaces;
using Pessoas;
using Arquivos;
using Constantes;

namespace PersistenciaArquivo
{
    public class PPessoaFisica : ICRUD<PessoaFisica>
    {
        #region ATRIBUTOS

        private NomesDiretorios diretorios = null;
        private NomesArquivos arquivos = null;
        private Arquivo controleArquivo = null;

        private PessoaFisica pessoa = null;
        private List<PessoaFisica> pessoas = null;

        #endregion ATRIBUTOS

        #region CONSTRUTORES
        public PPessoaFisica()
        {
            diretorios = new NomesDiretorios();
            diretorios.DirRoot = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            diretorios.DirHome = "\\Objetos\\";
            diretorios.DirDados = diretorios.DirFull + "Dados\\";
            diretorios.DirRelatorios = diretorios.DirFull + "Relatorios\\";

            arquivos = new NomesArquivos();
            arquivos.ArquivoDeDados = "PessoaFisica.bd";

            controleArquivo = new Arquivo(diretorios.DirDados, arquivos.ArquivoDeDados);
        }
        #endregion CONSTRUTORES

        #region CREATE

        public void Incluir(PessoaFisica objeto)
        {
            throw new System.NotImplementedException();
        }

       
        #endregion CREATE

        #region READ

        public PessoaFisica Buscar(int id)
        {
            throw new System.NotImplementedException();
        }

        public PessoaFisica Buscar(object objeto)
        {
            throw new System.NotImplementedException();
        }

        public PessoaFisica Consultar()
        {
            string[] linhas = controleArquivo.LerLinhas();
            pessoas = new List<PessoaFisica>();

            foreach (string linha in linhas)
            {


            }
            return null;
        }

        public List<PessoaFisica> Consultar(PessoaFisica objeto)
        {
            throw new System.NotImplementedException();
        }

        public PessoaFisica ToObject(string texto)
        {
            string[] partes = texto.Split(ConstantesGerais.SeparadorSplit);
            pessoa = new PessoaFisica();
            pessoa.idPessoa = long.Parse(partes[0]);
            pessoa.NomePessoa = partes[1];
            pessoa.DataNascimento = DateTime.Parse(partes[2]);
            pessoa.Sexo = (EnumSexo.Sexo) int.Parse(partes[2]);
            //pessoa.Pai = ToObject
            return pessoa;
        }

        #endregion READ

        #region UPDATE

        public void Atualizar(PessoaFisica objeto)
        {
            throw new System.NotImplementedException();
        }

        #endregion UPDATE

        #region DELETE

        public void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public string ToString(PessoaFisica objeto)
        {
            throw new NotImplementedException();
        }

        #endregion DELETE
    }
}
