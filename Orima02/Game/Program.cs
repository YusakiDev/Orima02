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
            Item doubleDamage =
                new DoubleDamage(ItemName.DoubleDamage, $"Double your atk to {player.Atk*2}");
            Item fullMp =
                new FullMp(ItemName.FullMp, $"Instantly regenerate your mp to {player.MaxMp}");
            Item stunBomb =
                new StunBomb(ItemName.StunBomb, "Stun your enemy for 1 turn");
            Item poisonBomb =
                new PoisonBomb(ItemName.PoisonBomb, "poisoned your enemy");
            Item damageBomb =
                new DamageBomb(ItemName.DamageBomb, $"deals {player.Atk/2} damage at the enemy");
            Item trapDeflect =
                new TrapDeflect(ItemName.TrapDeflect, "Reverse all damage to the enemy (this item will be active on the enemy turn");
            Item trapUltimate =
                new TrapUltimate(ItemName.TrapUltimate, "Steal enemy's Ultimate (this item will be active on the enemy turn)");
            Item abilityTheWorld =
                new AbilityTheWorld(ItemName.AbilityTheWorld, "Stunt enemy for 1-3 turn");
            Item abilityOra =
                new AbilityOra(ItemName.AbilityOra, "multiply player attack by 4");
            Item abilityUseLeg =
                new AbilityUseLeg(ItemName.AbilityUseLeg, "50/50 chance to skip the current stage");
            
            
            
            

            //Inventory Declaration
            Inventory inventory = new Inventory(new [] {fullRegen,doubleDamage,fullMp,stunBomb,poisonBomb,damageBomb
                ,trapDeflect,trapUltimate,abilityTheWorld,abilityOra,abilityUseLeg});

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
                "(Player) : Salute Princess of the Kingdom of \n",
                "(Player) : Sorry to spoil your manners with the princess.\n",
                "Irene : There is no need to pay great respects.\n",
                "Irene : Keep your head up\n",
                "(Player) : Princess, why are you here?\n",
                "Irene : I don't like the atmosphere in the palace. So I went out for a walk.\n",
                "Irene : Accidentally wandered into the forest So I had to stop walking Otherwise I would have been lost in the deep forest.\n",
                "(Player) : Princess, you shouldn't be here.\n",
                "(Player) : This forest was inhabited by goblins. They are also very dangerous.\n",
                "(Player) : You should hurry out of here.\n",
                "(Player) : Let me protect you until you return to the palace?\n",
                "Irene : It's okay, I can remember the way back.\n",
                "Irene : Have a safe journey. (Player)\n"
            });
            Scene scene1_3 = new Scene(1.3, 10, new[]
                {
                    "Narrator : Princess Irene said goodbye to you and returned to the way she came.\n",
                    "??? : Ahhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh. Help me!!\n",
                    "Narrator : Someone is crying for help. Will you help me?\n" 
                    
                });
            Scene scene1_3C1 = new Scene(1.3, 10, new[]
            {
                "\n",
                //skip to scene2
            });
            Scene scene1_3C2 = new Scene(1.3, 10, new[]
            {
                "Ending1 - Developer Frame\n",
                "Narrator : You walked backwards from the cry for help. After that\n",
                "Narrator : a loud scream rang out in the forest following behind him.\n",
                "Narrator :  and the cry for help was silenced.\n"
            });
            Scene scene2_1 = new Scene(2.1, 10, new[]
            {
                "Narrator The goblins are besieging the princess.\n",
                 "[Dialogue]\n",
                 "Irene : Help me!!\n",
                 "(Player) : There are too many of them. If I break in without a weapon, I'm sure I will lose.\n",
                 "(Player) : (Equitable Item Set) must be prepared first.\n"
            });
            Scene scene2_c1 = new Scene(2.1, 10, new[]
            {
                "+1 HpPotion \n"
            });
            Scene scene1_3C2 = new Scene(1.2, 10, new[]
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
            // scene1 choice2
            // scene2.DisplayScene();
            // scene2
            // if (gameController.ChoiceSelector(scene2.SceneIndex) == 3)
            // {
            //     scene2c3.DisplayScene();
            // }
            // else if(gameController.ChoiceSelector(scene2.SceneIndex) == 4)
            // {
            //     scene2c4.DisplayScene();
            // }
            //
            // scene3.DisplayScene();







            gameController.SelectSet(player, atkset, mpset, hpset, balanceset);
            
            inventory.OpenInventory();
            
            
            
            
            
        }
    }
}