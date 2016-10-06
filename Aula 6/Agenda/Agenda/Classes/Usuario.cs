﻿using Agenda.Classes.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Utilitarios.Retorno;
using Utilitarios.Validacao;

namespace Agenda.Classes
{
    public class Usuario
    {
        private DataBase db;

        #region Metodos

        public Usuario()
        {
            this.db = new DataBase(true);
        }

        public Usuario(DataBase db)
        {
            this.db = db;
        }
        
        public bool ValidarLoginSenha(string login, string senha)
        {
            var query = new StringBuilder();
            query.Append("SELECT 1 FROM Usuario WHERE Login = @Login AND Senha = @Senha");
            
            var listaParam = new List<SqlParameter>();

            var paramLogin = new SqlParameter(
                "@Login",
                login
            );
            listaParam.Add(paramLogin);

            var paramSenha = new SqlParameter(
                "@Senha",
                senha
            );
            listaParam.Add(paramSenha);

            var existe = db.ExecutarAcao(
                query.ToString(),
                listaParam.ToArray()
            );

            return (existe != 0);            
        }

        public void Salvar(UsuarioDTO usuarioDTO)
        {
            var query = new StringBuilder();
            query.Append("INSERT INTO Usuario (Login, Nome, Senha, Email) VALUES (@Login, @Nome, @Senha, @Email)");

            var listaParam = new List<SqlParameter>();

            var paramLogin = new SqlParameter(
                "@Login",
                usuarioDTO.Login
            );
            listaParam.Add(paramLogin);

            var paramNome = new SqlParameter(
                "@Nome",
                usuarioDTO.Nome
            );
            listaParam.Add(paramNome);

            var paramSenha = new SqlParameter(
                "@Senha",
                usuarioDTO.Senha
            );
            listaParam.Add(paramSenha);

            var paramEmail = new SqlParameter(
                "@Email",
                usuarioDTO.Email
            );
            listaParam.Add(paramEmail);

            db.ExecutarAcao(
                query.ToString(),
                listaParam.ToArray()
            );
            
        }

        public void Atualizar(UsuarioDTO usuarioDTO)
        {
            var query = new StringBuilder();
            query.Append("UPDATE Usuario SET Login = @Login, Nome = @Nome, Senha = @Senha, Email = @Email WHERE Id = @Id");

            var listaParam = new List<SqlParameter>();

            var paramId = new SqlParameter(
                "@Id",
                usuarioDTO.Id
            );
            listaParam.Add(paramId);

            var paramLogin = new SqlParameter(
                "@Login",
                usuarioDTO.Login
            );
            listaParam.Add(paramLogin);

            var paramNome = new SqlParameter(
                "@Nome",
                usuarioDTO.Nome
            );
            listaParam.Add(paramNome);

            var paramSenha = new SqlParameter(
                "@Senha",
                usuarioDTO.Senha
            );
            listaParam.Add(paramSenha);

            var paramEmail = new SqlParameter(
                "@Email",
                usuarioDTO.Email
            );
            listaParam.Add(paramEmail);

            db.ExecutarAcao(
                query.ToString(),
                listaParam.ToArray()
            );            
        }

        public void Excluir(int usuarioId)
        {
            var query = new StringBuilder();
            query.Append("DELETE FROM Usuario WHERE Id = @UsuarioId");

            var listaParam = new List<SqlParameter>();

            var paramUsuario = new SqlParameter(
                "@UsuarioId",
                usuarioId
            );
            listaParam.Add(paramUsuario);

            db.ExecutarAcao(
                query.ToString(),
                listaParam.ToArray()
            );
        }

        public UsuarioDTO Selecionar(int usuarioId)
        {
            UsuarioDTO retorno = null;

            var query = new StringBuilder();
            query.Append("SELECT Id, Login, Senha, Nome, Email FROM Usuario WHERE Id = @UsuarioId");

            var listaParam = new List<SqlParameter>();

            var paramUsuario = new SqlParameter(
                "@UsuarioId",
                usuarioId
            );
            listaParam.Add(paramUsuario);

            var reader = db.ExecutarDataReader(
                query.ToString(),
                listaParam.ToArray()
            );



            if (reader.HasRows)
            {
                reader.Read();

                retorno = new UsuarioDTO
                {
                    Id = reader.GetInt32(0),
                    Login = reader.GetString(1),
                    Senha = reader.GetString(2),
                    Nome = reader.GetString(3),
                    Email = reader.GetString(4)
                };
            }
            
            reader.Close();



            return retorno;
        }

        public RetornoMensagens ValidarEntidade(UsuarioDTO usuarioDTO)
        {
            var retorno = new RetornoMensagens();

            if (!ValidarAlphaNumerico.TemConteudo(usuarioDTO.Nome))
            {
                retorno.AddMensagem(new RetornoMensagem(TipoMensagem.Erro, "Preencha o nome"));
            }

            if (!ValidarAlphaNumerico.TemConteudo(usuarioDTO.Login))
            {
                retorno.AddMensagem(new RetornoMensagem(TipoMensagem.Erro, "Preencha o login"));
            }

            if (!ValidarAlphaNumerico.TemConteudo(usuarioDTO.Senha))
            {
                retorno.AddMensagem(new RetornoMensagem(TipoMensagem.Erro, "Preencha a senha"));
            }

            if (!ValidarAlphaNumerico.TemConteudo(usuarioDTO.Email))
            {
                retorno.AddMensagem(new RetornoMensagem(TipoMensagem.Erro, "Preencha o email"));
            }

            if (!ValidarAlphaNumerico.EmailValido(usuarioDTO.Email))
            {
                retorno.AddMensagem(new RetornoMensagem(TipoMensagem.Erro, "Email inválido"));
            }

            return retorno;
        }

        #endregion
    }
}
