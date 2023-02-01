using RestSharp;
using System.Text.Json;


namespace WellPokedex.Service
{
    public static class PesquisaPokemon
    {
       
        public static InfoPokemon BuscaPorEspecie(string especie)
        {
            try
            {
                var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{especie.ToLower()}");
                var request = new RestRequest("", Method.GET);

                var response = client.Execute(request);
                if (response != null)
                {
                    return JsonSerializer.Deserialize<InfoPokemon>(response.Content);
                }
                else
                {
                    MessageBox.Show("Pokémon não encontrado! Tente digitar novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
               
            }
            catch(Exception excecao)
            {
                MessageBox.Show("Pokémon não encontrado! Tente digitar novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            }
        }

    }

