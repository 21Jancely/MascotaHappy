using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioHistoria
        {
        IEnumerable<Historia> GetAllHistoria();
        Historia AddHistoria(Historia historia);
        Historia UpdateHistoria(Historia historia);
        void DeleteHistoria(int IdHistoria);
        Veterinario GetVeterinario(int idVeterinario);
        IEnumerable<Veterinario> GetVeterinarioPorFiltro(string filtro);
    }
}