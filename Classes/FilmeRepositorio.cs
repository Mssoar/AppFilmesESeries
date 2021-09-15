using System;
using System.Collections.Generic;
using FilmesESeries;
using FilmesESeries.Interfaces;

namespace FilmesESeries.Classes {
    class FilmeRepositorio 
    {
		private List<Filme> listaFilmes = new List<Filme>();
		public void Atualiza(int id, Filme objeto)
		{
			listaFilmes[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaFilmes[id].Excluir();
		}

		public void Inserir(Filme objeto)
		{
			listaFilmes.Add(objeto);
		}

		public List<Filme> Lista()
		{
			return listaFilmes;
		}

		public int ProximoId()
		{
			return listaFilmes.Count;
		}

		public Filme RetornaPorId(int id)
		{
			return listaFilmes[id];
		}

	}
}
