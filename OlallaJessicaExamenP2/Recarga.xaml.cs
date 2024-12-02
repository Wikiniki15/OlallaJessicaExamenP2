using Microsoft.Maui.Controls;
using OlallaJessicaExamenP2.Interfaces;
using System.Reflection;

namespace OlallaJessicaExamenP2;

public partial class Recarga : ContentPage
{
    IRecargaRepository _recargaRepository;
    Recarga recarga = new Recarga();
    public Recarga()
	{
        _recargaRepository = new RecargaRepository();
        InitializeComponent();

        recarga = _recargaRepository.DevuelveEstudianteUDLA();
        BindingContext = recarga;
    }

    private async void RecargaClicked(object sender, EventArgs e)
    {
        Recarga estudiante = new Recarga
        {
            Nombre = editor_nombre.Text,
            Numero = editor_numero.Text,
        };
        bool guardar_recarga = _recargaRepository.CrearRecarga(recarga);

        if (guardar_recarga)
        {
            await DisplayAlert("Alert", "Todo posi", "OK");
            Navigation.PushAsync(new Recarga());
        }
        else
        {
            await DisplayAlert("Alert", "Negado mi pana", "OK");
        }
    }
    
}