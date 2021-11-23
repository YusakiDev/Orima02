using System;

namespace Orima02
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            
            
            
            //Enemy Declaration
            GoblinGuard goblinGuard = new GoblinGuard("Goblin Guard", 1, 1, 1, 1, 1, true, false, true);
            GoblinWarrior goblinWarrior = new GoblinWarrior("Goblin Warrior", 1, 1, 1, 1, 1, true, true, true);
            
            
            
            //Character Declaration
            Magician magician = new Magician("Magician", 1, 1, 1, 1, 1, true, true, true);
            
            //Item Declaration
            FullRegen fullRegen = new FullRegen(ItemName.FullRegen, 1, $"Instantly regenerate your hp to {Entity.MaxHp}");
            
            //Inventory Declaration
            Inventory inventory = new Inventory(new Item[]{fullRegen});

            
            //Scene Declaration
            Scene scene1 = new Scene(1, 10, new[]
            {
                "Narrator: During a long journey \n",
                "asaaaaaaaaaaaaaaaaaaaaaaaaa \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n"
            });
            
            Scene scene2 = new Scene(2, 10, new[]
            {
                "Narrator: During a long journey \n",
                "asaaaaaaaaaaaaaaaaaaaaaaaaa \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n"
            });


            //game controller Declaration
            GameController gameController = new GameController();
            
            
            //Method
            scene1.DisplayScene();
            gameController.ChoiceSelector(scene1.SceneIndex);
            scene2.DisplayScene();
            gameController.ChoiceSelector(scene2.SceneIndex);
            inventory.OpenInventory();
            
            
        }
    }
}