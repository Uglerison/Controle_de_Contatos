using Contatos.Controllers;
using Contatos.Data;
using Contatos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

namespace Contatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext) {
            _bancoContext = bancoContext;
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.TblContatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;           
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);

            if (contatoDB == null) throw new System.Exception("Não foi possível deletar o contato");

            _bancoContext.TblContatos.Remove(contatoDB);
            _bancoContext.SaveChanges();
            return true;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);

            if (contatoDB == null) throw new System.Exception("Não foi possível alterar o contato"); 

            contatoDB.Name = contato.Name;
            contatoDB.Email = contato.Email;
            contatoDB.Phone = contato.Phone;

            _bancoContext.TblContatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.TblContatos.ToList();
        }

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.TblContatos.FirstOrDefault(x => x.Id == id);
        }     
    }
}

