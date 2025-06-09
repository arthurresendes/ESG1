using System.Diagnostics;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Projeto_Take.Models;

namespace Projeto_Take.Models
{

    public class RepositorioForms
    {
        private static List<CadastroCrud> _formularios = [];

        public static IEnumerable<CadastroCrud> Formularios => _formularios;

        public static bool AddFormulario(CadastroCrud formulario)
        {
            _formularios.Add(formulario);
            return true;
        }

        public static bool RemoveFormulario(int Id)
        {
            if (Id < 0 || Id >= _formularios.Count)
                return false;
            _formularios.RemoveAt(Id);
            return true;
        }
    }
}
