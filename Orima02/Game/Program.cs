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
            Character player = new EmptyCharacter();
            
            
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
            
            Scene scene1c1 = new Scene(1, 10, new[]
            {
                "Scene1c1 \n",
                "asaaaaaaaaaaaaaaaaaaaaaaaaa \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n",
                "Narrator: During a long journey \n"
            });
            
            Scene scene1c2 = new Scene(1, 10, new[]
            {
                "Scene1c2 \n",
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
            
            gameController.Menu();
            gameController.SelectClass();
            
            player = new Magician(gameController.PreGame(), 2, 2, 2, 2, 2, true, true, true);
            player.Attack();
            
            

            scene1.DisplayScene();
            if (gameController.ChoiceSelector(scene1.SceneIndex) == 1)
            {
                scene1c1.DisplayScene();
            }
            else if(gameController.ChoiceSelector(scene1.SceneIndex) == 2)
            {
                scene1c2.DisplayScene();
            }
            
            // scene2.DisplayScene();
            //
            // if (gameController.ChoiceSelector(scene2.SceneIndex) == 1)
            // {
            //     scene2c1.DisplayScene();
            // }
            // else if(gameController.ChoiceSelector(scene2.SceneIndex) == 2)
            // {
            //     scene2c2.DisplayScene();
            // }
            //
            // scene3.DisplayScene();
            
            
            
            
            
            
            inventory.OpenInventory();
            
            
        }
    }
}