﻿using ApiProdutos.Infra.Data.Contexts;
using ApiProdutos.Infra.Data.Entities;
using ApiProdutos.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProdutos.Infra.Data.Repositories
{
    /// <summary>
    /// Classe de repositório para Produto
    /// </summary>
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        //atributo
        private readonly SqlServerContext _sqlServerContext;

        //construtor para inicializar o atributo
        public ProdutoRepository(SqlServerContext sqlServerContext)
            : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }
    }
}
