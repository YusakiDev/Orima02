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
            FullRegen fullRegen =
                new FullRegen(ItemName.FullRegen, 1, $"Instantly regenerate your hp to {Entity.MaxHp}");

            //Inventory Declaration
            Inventory inventory = new Inventory(new Item[] {fullRegen});


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

            Scene scene1C1 = new Scene(1, 10, new[]
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

            Scene scene1C2 = new Scene(1, 10, new[]
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

            //Select Class
            switch (gameController.SelectClass())
            {
                case 1:
                {
                    player = new Magician(gameController.GetName(), 2, 2, 2, 2, 2, true, true, true);
                    break;
                }
                case 2:
                {
                    player = new Swordsman(gameController.GetName(), 2, 2, 2, 2, 2, true, true, true);
                    break;
                }
                case 3:
                {
                
                    player = new Volunteer(gameController.GetName(), 2, 2, 2, 2, 2, true, true, true);
                    break;
                }
            }


            player.Stats();
            
            

            scene1.DisplayScene();
            if (gameController.ChoiceSelector(scene1.SceneIndex) == 1)
            {
                scene1C1.DisplayScene();
            }
            else if(gameController.ChoiceSelector(scene1.SceneIndex) == 2)
            {
                scene1C2.DisplayScene();
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