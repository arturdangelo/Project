using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Controller.Interfaces
{
public interface IControle
	{
		/// <summary>
		/// Método responsável pela inserção da entidade no banco de dados.
		/// </summary>
		/// <param name="entidade">Entidade a ser inserida.</param>
		/// <returns>Entidade após ser inserida.</returns>
		Model.ClasseBase inserir(Model.ClasseBase entidade);

		/// <summary>
		/// Método responsável pela alteração da entidade no banco de dados.
		/// </summary>
		/// <param name="entidade">Entidade a ser alterada.</param>
		/// /// <returns>Entidade após ser alterada.</returns>
		void alterar(Model.ClasseBase entidade);

		/// <summary>
		/// Método responsável pela exclusão da entidade no banco de dados.
		/// </summary>
		/// <param name="entidade">Entidade a ser excluída.</param>        
		void excluir(Model.ClasseBase entidade);

		/// <summary>
		/// Método responsável por retornar a entidade por ID.
		/// </summary>
		/// <param name="id">id a ser pesquisado.</param>
		/// <returns>Entidade a ser retornada.</returns>
		Model.ClasseBase Retornar(string id);
	}
}
