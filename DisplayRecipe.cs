using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _324_phase_3
{
    public partial class DisplayRecipe : Form
    {
        private string GetIngredients(string recipe)
        {
            switch (recipe)
            {
                case "Thai Green Curry":
                    return "2 (8 ounce) cans bamboo shoots, drained and thinly sliced\n" +
                        "3 tablespoons corn oil\n" +
                        "3 tablespoons green curry paste, or more to taste\n" +
                        "1 pound lean boneless pork, cut into 1 / 2 - inch cubes\n" +
                        "2(14 ounce) cans coconut milk\n" +
                        "1 small red bell pepper, thinly sliced\n" +
                        "1 tablespoon white sugar\n" +
                        "½ teaspoon salt\n" +
                        "8 kaffir lime leaves, thinly sliced\n" +
                        "2 teaspoons fish sauce, or more to taste\n" +
                        "½ cup Thai basil\n";
                case "Crazy Tacos":
                    return "1 pound lean(at least 80 %) ground beef\n" +
                        "1 cup Old El Paso™ Thick 'n Chunky salsa\n" +
                        "10 Old El Paso™ taco shells\n" +
                        "1 / 2 head lettuce, shredded\n" +
                        "1 medium tomato, chopped (3 / 4 cup)\n" +
                        "1 cup shredded Cheddar cheese(4 ounces)\n";
                case "Stuffed Sausages":
                    return "6 sausage thick\n" +
                        "2 potato chopped\n" +
                        "6 bacon rashers\n" +
                        "1 / 4 cup cheese grated";
                default:
                    return null;
            }
        }

        private string GetMethod(string recipe)
        {
            switch (recipe)
            {
                case "Thai Green Curry":
                    return "Step 1 Bring a large pot of water to a boil and cook bamboo shoots for 5 minutes.Drain.\n" +
                        "Step 2 Heat oil in a large pot over medium heat and cook curry paste until fragrant, about 2 minutes." +
                        "Add pork, increase heat and cook until starting to brown, 3 to 5 minutes.Add bamboo shoots, coconut milk, " +
                        "and red bell pepper.Reduce heat and bring to a simmer.Season with sugar and salt; simmer for 10 minutes." +
                        "Stir in kaffir lime leaves.Cook for 1 more minute.Season with fish sauce.Stir in Thai basil and serve.";
                case "Crazy Tacos":
                    return "1 Cook beef in 10 - inch skillet over medium heat 8 to 10 minutes, stirring occasionally, until brown; drain.\n" +
                        "2 Stir salsa into beef. Heat to boiling, stirring constantly; reduce heat to medium-low.Cook 5 minutes, stirring occasionally. Pour beef mixture into large serving bowl.\n" +
                        "3 Heat taco shells as directed on package. Serve taco shells with beef mixture, lettuce, tomato and cheese.";
                case "Stuffed Sausages":
                    return "1 Place sausages in saucepan and boil until cooked.\n" +
                        "2 Boil potatoes until soft.\n" +
                        "3  Mash potatoes, adding some grated cheese.\n" +
                        "4 Cut 2 slits in each sausage widthways towards the end, and then one down the centre.\n" +
                        "5 Push centre slit open with fingers and fill with mash potato.\n" +
                        "6 Wrap a bacon rasher around each sausage and secure the ends with a toothpick.\n7" +
                        "7 Place sausages onto a baking tray and sprinkle with grated cheese.\n" +
                        "8 Bake at 180C for approximately 20 minutes or until bacon crisps and cheese browns.";
                default:
                    return null;
            }
        }

        public DisplayRecipe(string recipe)
        {
            InitializeComponent();
            textBoxIngredients.Text = GetIngredients(recipe);
            textBoxMethod.Text = GetMethod(recipe);
        }
    }
}
