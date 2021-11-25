using System;
using System.ComponentModel;

namespace Orima02
{
    internal class Program
    {
        public static void Main(string[] args)
        {




            //Enemy Declaration
            Enemy goblinGuard = new GoblinGuard("Goblin Guard", 1, 1, 1, 1, 1, true, false, true);
            Enemy goblinWarrior = new GoblinWarrior("Goblin Warrior", 1, 1, 1, 1, 1, true, true, true);

            
            //Combat Class Declaration
            Combat combat = new Combat();


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

            Inventory fullinventory = new Inventory(new[] {fullRegen});


             //Scene Declaration
            Scene scene1_1 = new Scene(1.1, 10, new[]
            {
                "While you are traveling had passed through the forest in the same area as the Feri City Kingdom.\n", 
                " which is a forest inhabited by goblins Or almost called their forest. =====While walking, you meet a young woman.\n",
                "(Player) : Is that a woman? \n",
                "(Player) : A woman in a forest with herds of goblins?\n",
                "(Player) : Let's enter to greet her.\n"
            });

            Scene scene1_1C1 = new Scene(1.1, 10, new[]
            {
                /////////
                "(Player) : Hey that woman over there.\n",
                "??? : Who are you?\n",
                "(Player) : My name is (Player)\n",
                "(Player) : I'm just a (player class) passing this way.\n",
                "(Player) : And you?\n",
                "Irene : My name is Irene the Felicity, I'm the princess of the Felicity Kingdom.\n"
            });

            Scene scene1_1C2 = new Scene(1.1, 10, new[]
            {
                "(Player) : I'm arrogant, better not go in\n",
                "Dev : You can't be that arrogant. If so, how will the game continue?\n",
                "Dev : Go in and say hi to that woman now.\n"
            });
            Scene scene1_2 = new Scene(1.2, 10, new[]
            {
                "Narrator : You met the princess of the Feri City Kingdom……but in the forest?\n",
            });
            Scene scene1_2C1 = new Scene(1.2, 10, new[]
            {
               "(Player) : Princess, why are you here?\n",
               "Irene : I don't like the atmosphere in the palace. So I went out for a walk.\n",
               " Irene : Accidentally wandered into the forest So I had to stop walking Otherwise I would have been lost in the deep forest.\n",
                "(Player) : Princess, you shouldn't be here.\n",
               "(Player) : This forest was inhabited by goblins. They are also very dangerous.\n",
               "(Player) : You should hurry out of here.\n",
               "(Player) : Let me protect you until you return to the palace?\n",
               "Irene : It's okay, I can remember the way back.\n",
               "Irene : Have a safe journey. (Player)\n"
            });
            Scene scene1_2C2 = new Scene(1.2, 10, new[]
            {
                "Narrator : You met the princess of the Feri City Kingdom……but in the forest?\n",
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
                    player = new Magician(gameController.GetName(), 12, 12, 0, 12, 3, true, true, true);
                    break;
                }
                case 2:
                {
                    player = new Swordsman(gameController.GetName(), 12, 15, 0, 9, 4, true, true, true);
                    break;
                }
                case 3:
                {
                
                    player = new Volunteer(gameController.GetName(), 15, 12, 9, 9, 3, true, true, true);
                    break;
                }
            }
            //Debug
            player.Stats();
            
            gameController.CombatPhase(player, goblinGuard, inventory.Items,fullinventory.Items, combat);
            
            //Scene1
            scene1_1.DisplayScene();
            //Scene1 Choice1
            if (gameController.ChoiceSelector(scene1_1.SceneIndex) == 1)
            {
                scene1_1C1.DisplayScene();
            }
            else if(gameController.ChoiceSelector(scene1_1.SceneIndex) == 2)
            {
                scene1_1C2.DisplayScene();
            }
            







            gameController.SelectSet(player, atkset, mpset, hpset, balanceset);
            //more dialogue
            
            
            
            
            //combat
            //gameController.CombatPhase(player, goblinGuard, new Combat());
            
            inventory.OpenInventory();
            
            
            
            
            
        }
    }
}