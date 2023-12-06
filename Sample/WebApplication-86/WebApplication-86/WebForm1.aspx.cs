using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_86
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label8.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;
            Label12.Visible = false;
            Label13.Visible = false;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            double weight = Convert.ToDouble(TextBox1.Text);
            double height = Convert.ToDouble(TextBox2.Text) / 100;

   
            double bmi = weight / (height * height);

           
            TextBox3.Text = bmi.ToString("0.00");

            TextBox4.Text = GetHealthRisk(bmi);

        }

        private string GetHealthRisk(double bmi)
        {
            if (bmi < 18.5)
            {
                Label8.Visible = true;
                Image1.ImageUrl = @"https://i.pinimg.com/originals/95/3f/6e/953f6e72014ac744e54815991075b5e3.png";
                Image1.Visible = true;
                return "Underweight";
                
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Label9.Visible = true;
                Image1.ImageUrl = @"https://assets.pokemon.com/assets/cms2/img/pokedex/full/282.png";
                Image1.Visible = true;
                return "Normal weight";
                
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Label10.Visible = true;
                Image1.ImageUrl = @"https://archives.bulbagarden.net/media/upload/thumb/e/ea/0296Makuhita.png/375px-0296Makuhita.png";
                Image1.Visible = true;
                return "Overweight";
                
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Label11.Visible = true;
                Image1.ImageUrl = @"https://assets.pokemon.com/assets/cms2/img/pokedex/full/443.png";
                Image1.Visible = true;
                return "Obesity (Class 1)";
                
            }
            else if (bmi >= 35 && bmi < 40)
            {
                Label12.Visible = true;
                Image1.ImageUrl = @"https://archives.bulbagarden.net/media/upload/thumb/0/08/0297Hariyama.png/250px-0297Hariyama.png";
                Image1.Visible = true;
                return "Obesity (Class 2) ";
                
            }
            else if (bmi >= 40)
            {
                Label13.Visible = true;
                Image1.ImageUrl = @"https://upload.wikimedia.org/wikipedia/en/3/3f/Pok%C3%A9mon_Snorlax_art.png";
                Image1.Visible = true;
                return "Obesity (Class 3) ";

            }
            else
            {
                Label13.Visible = true;
                Image1.ImageUrl = @"https://static.pokemonpets.com/images/monsters-images-800-800/94-Gengar.webp";
                Image1.Visible = true;
                return "Ghost ";
                
            }
        }

    }
}