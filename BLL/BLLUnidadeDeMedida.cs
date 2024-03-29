﻿using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUnidadeDeMedida
    {
        private DALConexao conexao;

        public BLLUnidadeDeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório!"); 
            }
            modelo.UmedNome = modelo.UmedNome.ToLower();

            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório!");
            }

            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório!");
            }

            modelo.UmedNome = modelo.UmedNome.ToLower();

            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificarUnidadeDeMedida(string valor)
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            return DALobj.VerificarUnidadeDeMedida(valor);
        }

        public ModeloUnidadeDeMedida CarregaModeloUnidadeMedida(int codigo)
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            return DALobj.CarregaModeloUnidadeMedida(codigo);
        }
    }
}
