using OlallaJessicaExamenP2.Interfaces;
using OlallaJessicaExamenP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlallaJessicaExamenP2.Repositories
{
    /*public class RecargaRepository : IRecargaRepository
    {
        private string _fileName = Path.Combine(FileSystem.AppDataDirectory, "JessicaOlalla.txt");
    }

    public bool ActualizarRecarga(Recarga recarga)
    {
        throw new NotImplementedException();
    }

    public bool CrearRecarga(Recarga recarga)
    {
        try
        {
            string json_data = JsonConvert.SerializeObject(recarga);
            File.WriteAllText(_fileName, "json_data");
            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public IEnumerable<Recarga> DevuelveRecarga()
    {
        throw new NotImplementedException();
    }

    public Recarga DevuelveRecarga()
    {
        Recarga estudiante = new Recarga();
        if (File.Exists(_fileName))
        {
            string json_data = File.ReadAllText(_fileName);
            recarga = JsonConvert.DeserializeObject<Recarga>(json_data);
        }
        return estudiante;
    }

    public bool EliminarRecarga(int id)
    {
        throw new NotImplementedException();
    }
    */
}
