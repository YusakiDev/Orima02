using System;
using System.ComponentModel;

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
            EquipableItem atkset = new EquipableItem(ItemName.AtkSet, 3, 1, 1, "Equip Atk Set");
            EquipableItem mpset = new EquipableItem(ItemName.MpSet, 1, 3, 1, "Equip MP Set");
            EquipableItem hpset = new EquipableItem(ItemName.HpSet, 1, 3, 1, "Equip HP Set");
            EquipableItem balanceset = new EquipableItem(ItemName.BalanceSet, 2, 2, 2, "Equip Balance Set");
            Item fullRegen =
                new FullRegen(ItemName.FullRegen, $"Instantly regenerate your hp to {player.MaxHp}");

            //Inventory Declaration
            Inventory inventory = new Inventory(new [] {fullRegen});


            //Scene Declaration
            Scene scene1 = new Scene(1.1, 10, new[]
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

            Scene scene1C1 = new Scene(1.2, 10, new[]
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

            Scene scene1C2 = new Scene(1.3, 10, new[]
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
            //Debug
            player.Stats();
            //Scene1
            scene1.DisplayScene();
            //Scene1 Choice1
            if (gameController.ChoiceSelector(scene1.SceneIndex) == 1)
            {
                scene1C1.DisplayScene();
            }
            else if(gameController.ChoiceSelector(scene1.SceneIndex) == 2)
            {
                scene1C2.DisplayScene();
            }







            // gameController.SelectSet(player, atkset, mpset, hpset, balanceset);
            
            inventory.OpenInventory();
            
            
            
            
            
        }
    }
}