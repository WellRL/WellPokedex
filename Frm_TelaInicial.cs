using WellPokedex.Modelos;
using WellPokedex.Service;
using System.Collections.Generic;
using System.Globalization;
using System.Diagnostics;

namespace WellPokedex
{
    public partial class Frm_TelaInicial : Form
    {
        private List<InfoPokemon> PokemonAdotados { get; set; }

        InfoPokemon pokemon = new();


        public Frm_TelaInicial()
        {
            InitializeComponent();
        }

        public void Btn_PesquisaOk_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
                string especie = txtDigitar.Text;
                
                
                    pokemon = PesquisaPokemon.BuscaPorEspecie(especie);
                if (pokemon != null)
                {
                    int altura = pokemon.height;
                    int peso = pokemon.weight;
                    int contador = pokemon.abilities.Count;
                    int i = 0;
                    string alturaAlterada = altura.ToString(@"0\,#", CultureInfo.InvariantCulture);
                    string pesoAlterado = peso.ToString(@"0\,#", CultureInfo.InvariantCulture);

                    if (i < contador)
                    {
                        Abilities habilidade = pokemon.abilities[i];
                        lblHabilidade1.Text = $"Habilidade: {habilidade.ability.name.ToUpper()}";
                        i++;
                    }
                    if (i < contador)
                    {
                        Abilities habilidade = pokemon.abilities[i];
                        lblHabilidade2.Text = $"Habilidade: {habilidade.ability.name.ToUpper()}";
                        i++;
                    }
                    else
                    {
                        lblHabilidade2.Text = "";
                        lblHabilidade3.Text = "";
                    }

                    if (i < contador)
                    {
                        Abilities habilidade = pokemon.abilities[i];
                        lblHabilidade3.Text = $"Habilidade: {habilidade.ability.name.ToUpper()}";
                        i++;
                    }
                    else
                    {
                        lblHabilidade3.Text = "";
                    }

                    lblNome.Text = $"Nome: {pokemon.name.ToUpper()} \nAltura: {alturaAlterada}m \nPeso: {pesoAlterado}kg ";

                    picImagem.ImageLocation = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/home/{pokemon.id}.png";
                    btnForma.Enabled = true;
                    btnForma.Text = "Original";

                }
                else
                {
                
                }
            
           
        }
            
        

        private void picImagem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnForma_Click(object sender, EventArgs e)
        {
            btnForma.Text = "Shiny";
            picImagem.ImageLocation = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/home/shiny/{pokemon.id}.png";

            

        }
    }
}