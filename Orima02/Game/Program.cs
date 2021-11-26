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
            UseableItem fullRegen =
                new UseableItem(ItemName.FullRegen, $"Instantly regenerate your hp to {player.MaxHp}");
            UseableItem doubleDamage =
                new UseableItem(ItemName.DoubleDamage, $"Double your atk to {player.Atk*2}");
            UseableItem fullMp =
                new UseableItem(ItemName.FullMp, $"Instantly regenerate your mp to {player.MaxMp}");
            UseableItem stunBomb =
                new UseableItem(ItemName.StunBomb, "Stun your enemy for 1 turn");
            UseableItem poisonBomb =
                new UseableItem(ItemName.PoisonBomb, "poisoned your enemy");
            UseableItem damageBomb =
                new UseableItem(ItemName.DamageBomb, $"deals {player.Atk/2} damage at the enemy");
            UseableItem trapDeflect =
                new UseableItem(ItemName.TrapDeflect, "Reverse all damage to the enemy (this item will be active on the enemy turn");
            UseableItem trapUltimate =
                new UseableItem(ItemName.TrapUltimate, "Steal enemy's Ultimate (this item will be active on the enemy turn)");
            UseableItem abilityTheWorld =
                new UseableItem(ItemName.AbilityTheWorld, "Stunt enemy for 1-3 turn");
            UseableItem abilityOra =
                new UseableItem(ItemName.AbilityOra, "multiply player attack by 4");
            UseableItem abilityUseLeg =
                new UseableItem(ItemName.AbilityUseLeg, "50/50 chance to skip the current stage");
            
            
            
            

            //Inventory Declaration
            Inventory inventory = new Inventory(new [] {fullRegen,doubleDamage});

            Inventory fullinventory = new Inventory(new [] {fullRegen,doubleDamage,fullMp,stunBomb,poisonBomb,damageBomb,trapDeflect,trapUltimate,abilityTheWorld,abilityOra,abilityUseLeg});


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
            Scene scene2_2 = new Scene(2.2, 10, new[]
            {
                "(Player) : Oh hey! Where has the princess gone?\n",
                "(Player) : Where has the princess gone? I haven't shown off my coolness yet.\n",
                "(Player) : If I had to guess, they would have taken the princess to the Goblin Castle. in order to bring the princess to their king\n",
                "(Player) : Wait, which way is Goblin Castle?\n",
                "(Player) : Ah crap. After getting cool, I don't know the way anymore. If someone can guide me that would be great.\n"
            });
            Scene scene3_1 = new Scene(3.1, 10, new[]
            {
                "{on the way}\n",
                "??? : Hey! \n",
                "(Player) : What!\n",
                "??? : I'm here walk carefully.\n",
                "(Player) : Are you a Fairy?\n",
                "Fairy : How do you see it otherwise?\n",
                "(Player) : Does the fairy live here? Everywhere I looked, I saw only goblins.\n",
                "Fairy : Don't you think there are other living beings in the forest!\n",
                "Fairy : And my name is not Fairy, Anemone is my name. Or you can call it Annie.\n",
                "(Player) : Alright Annie, I'm leaving.\n",
                "Fairy (Annie) : Wait!!\n",
                "Fairy (Annie) : You haven't introduced yourself yet. Just had to talk a few sentences, where are you going to hurry?\n",
                "(Player) : I am (Player) is a (อาชีพ) Just passing through an event that must be involved in the inevitable.\n",
                "Narrator  You have told Annie about the previous incident.\n",
                "Annie : ok i get it.\n",
                "Annie : Goblin again? Do they think they own the forest?\n",
                "Annie : It's not just humans that are hurt by them. The goblins also attacked my friends. Everyone panicked and ran away.\n",
                "Annie : So now I have to be alone. And I don't even know where the other fairies are.\n",
                "(Player) : If so, would you like to go with me?\n",
                "Annie : Why should I go with you!\n",
                "(Player) : I don't know. Maybe during the journey to save the princess. I might even meet another fairy.\n",
                "(Player) : But as you wish, I'll leaving now\n",
                "Annie : Wait! I'll go with you.\n",
                "Annie : Where do you want to go? I'm an expert in this forest. Wherever it is, I know it all!\n",
                "(Player) : Okay, so where's the Goblin Castle?\n",
                "Annie : Just go left! Or on the right! Maybe.... I don't know, who wants to go for a walk around the Goblin Castle!\n",
                "(Player) : Be quiet! Behind you have a goblin.\n",
                "Annie : Come on!! Who's afraid?!!\n",
                "Goblin : Hokpip!?\n",
                "(Player) : Wait! The fighter is me!\n",
            });
            Scene scene4_1 = new Scene(4.1, 10, new[]
            {
                "(Player) : You are the one who challenged them. But why do I have to fight instead!\n",
                "Annie : I don't know, I'm probably too cute.\n",
                "(Player) : Then I'd better take her as a hostage instead of the princess. Hmm..interesting.\n",
                "Annie : Sorry!! I won't be loud anymore.\n",
                "Annie : Let's go find the Goblin Castle!\n",
                "{see grandma and grandpa}\n",
                "[Dialogue]\n",
                "Annie : There are people over there.\n",
                "(Player) : Grandfather and grandmother? Are there human beings here?\n",
                "Annie : Don't forget that this forest It's not just the goblins. Those two might be some creatures living in this forest.\n",
                "Annie : We'd better go in and ask for directions.\n",
                "{Go and talk to Grandpa and Grandma.}\n",
                "[Dialogue]\n",
                "Annie : Hello, we are looking for the Goblin Castle. Do you guys know where it is?\n",
                "คุณยาย : We know, it's deep in the woods. You guys have to go left and walk a little deeper into the forest.\n",
                "คุณตา : Don't listen to old grandma. That's not the way to Goblin Castle. It's the way to the Tiger Cave.\n",
                "คุณตา : The correct way to the Goblin Castle is On the right?\n",
                "คุณยาย : Don't be foolish Forgetful and still want to come and tell you the way again. The castle must go to the left separately.\n",
                "(Player) : Who can I believe?\n",
                "Annie : Excuse me. So, where exactly do we have to go?\n",
                "คุณยาย : On the left\n",
                "คุณตา : On the right\n",
            });
            Scene scene4_1C1 = new Scene(4.1, 10, new[]
            {
                "\n"
                //go to scene 5
            });
            Scene scene4_1C2 = new Scene(4.1, 10, new[]
            {
                "Annie : I think the way is weird. Can we really trust Grandpa?\n",
                "(Player): What cave is that?\n",
                "???: Rrrrrr.\n",
                "(Player): Goblin Castle?. This is clearly a tiger's cave.\n",
                "Annie : Runnnn!!\n",
                "{Come out and talk to Grandma again}\n",
                "Grandfather : How is the Goblin Castle?\n",
                "(Player) : Yeah i Found a big goblin ==.\n",
                "Annie : I think I only see tigers.\n",
                "(Player) : Shhhh Annie\n",
                "Grandma : You see, old man? Forgetful and still want to tell others the way\n",
                "{Go back to choose a new way} \n"
            });
            Scene scene5_1 = new Scene(5.1, 10, new[]
            {
                "Annie : That's the goblin castle.\n",
                "(Player) : Be careful, it's full of goblins outside.\n",
                "(Player) : Let's go in!\n",
                "Goblin1 : I smell a strange smell.\n",
                "Goblin2 : I don't fart, idiot.\n",
                "Goblin1 : No, I mean I smell human.\n",
                "Goblin2 : Just had a human coming in.\n",
                "Goblin1 : Not that princess I smelled a new, unfamiliar scent.\n",
                "Goblin2 : Are you crazy?\n",
                "Goblin1 : I'm not crazy I really smell it\n",
                "Annie : They look like they can smell you.\n",
                "(Player) : We will not be careless.\n",
                "Irene : Help me!!!\n",
                "(Player) : Princess voice! she is here\n",
                "Annie : It seems that there are many floors here. And there are still a lot of rooms.\n",
                "Annie : How do we know where she is?\n",
                "(Player) : I guess the princess must be in the Goblin King's room.\n",
                "Annie : And where is it?\n",
                "(Player) : I came in with you How could I know!\n",
                "Annie : That's right, let's go find the princess. Perhaps she was at the top of the castle.\n",
            });
            Scene scene6_1 = new Scene(6.1, 10, new[]
            {
                "Annie : Finally got to the 2nd floor\n",
                "(Player) : The goblins were not weak at all.\n",
                "Irene : Don't touch me!!\n",
                "(Player) : A loud noise came from upstairs.\n",
                "(Player) : We have to hurry\n",
                "[Last Floor : King's Room]\n",
                "[Dialogue]\n",
                "Irene : Let me out now!!\n",
                "(Player) : Princess!!\n",
                "Irene : (Player) with a fairy?\n",
                "(Player) : We have come to save the princess.\n",

                //fight


                "Irene : Thank you very much I don't know who the other fairy is.\n",
                "(Player) : This is Anemone, or you can call it Annie for short.\n",
                "(Player) : We met on our way out to find the princess.\n",
                "Irene : during the capture As if I could see that other fairies were trapped. If I'm not mistaken, it's probably on the second floor.\n",
                "Annie : Really! They must be my friends. Let's go help them. (Player)\n",
                "{Help the other fairies come out}\n",
                "[Dialogue]\n",
                "Lily : Look at that, Annie, we're here!!\n",
                "Daisy : She came with two humans too.\n",
                "Peony : It seems like the other person is the princess of the Feri City Kingdom.\n",
                "Daisy : Do you know her? Peony\n",
                "Peony : This kingdom is not far from our forest. There must be only you who do not know each other.\n",
                "Lily : I could see that the goblins took her to the top floor here.\n",
                "Peony : Maybe another human can help.\n",
                "Annie : Hey!! Lily Daisy Peony, I'm here to help.\n",
                "(Player) : Three more fairies?\n",
                "Irene : It's the name of every flower.\n",
                "Annie : Lliy Daisy Peony  This person is a (Player) is a (อาชีพ) who has come across an incident that must be involved inevitably.\n",
                "Irene : What does inevitable involvement mean?\n",
                "(Player) : Forget it...\n",
                "Annie : This person is Princess Irene de Fericity\n",
                "Annie : This (Player) Irene, these three are my friends. They are name...\n",
                "(Player) : We've all heard her call. nice to meet you.\n",
                "Irene : Nice to meet you\n",
                "Peony : H.. Hello, Princess\n",
                "Lily : Peony really likes princesses. She always secretly flew out to the palace gardens.\n",
                "Daisy : Yes\n",
                "Irene : You can come and live in the gardens of the palace.\n",
                "Peony : Really?!!\n",
                "Annie : Let's talk about that later. Let's hurry out of here.\n",
                "{leave the castle}\n",
            });
            Scene scene7_1 = new Scene(7.1, 10, new[]
            {
                "{back in the forest}\n",
                "(Player) : Be careful There were still some goblins outside.\n",
                "Irene : I remember that on the way out of the forest to the palace, there were Goblin Warriors.\n",
                "Irene : Be careful everyone\n",
                "[Dialogue]\n",
                "Lily : they are there\n",
                "Daisy : I don't want to be taken back there again.\n",
                "Peony : Be careful princess\n",
                "Annie : Princess, please step back.\n",
                "(Player) : Hey! I'm a fighter Aren't you worried about me?\n",


                //fight

                "Irene : “The fighting skills are excellent. This must be notified to Father to consider.(thinking in her mind)\n",
                "Annie : Wow! Finally got out of the forest\n",
                "Peony : Princess, be careful to stumble across the grass!!\n",
                "Daisy : It's like this outside of the forest!!\n",
                "Lily : There are lots of flowers there!!\n",
                "(Player) : Nobody really cares about me! 😢\n",
                "{go to the palace}\n",
                "[Dialogue]\n",
                "Irene : Father!\n",
                "King Valdus : Where have you been, daughter? Everyone in the palace was chaotic looking for you.\n",
                "Irene : I thought I would never come back to see you again.\n",
                "(Player) : Do I have to pay respects?  (Think in his mind)\n",
                "King Valdus : What happened to you?\n",
                "Narrato You have told the king all the story.\n",
                "King Valdus : Hmm...do you have any hesitation in helping her?\n",
                "(Player) : No, I didn't hesitate one bit.\n",
                "(Player) : ดีที่ช่วยเจ้าหญิงไว้ได้ ถ้าช่วยไม่ได้ละก็แค่คิดก็เสียวสันหลังแล้วล่ะ (คิดในใจ)\n",
                " Annie : hey what are you Your face doesn't look good at all?\n",
                "King Valdus : I am deeply grateful to you.\n",
                "King Valdus : If I had to lose her I will surely die.\n",
                "Irene : Father (Player) has excellent fighting skills.\n",
                "King Valdus : Hmm, I can feel that this person is truly extraordinary.\n",
                "King Valdus : He was just a (professional) passerby, but was able to fight adept at fighting strong and ferocious goblins.\n",
                "King Valdus :  And survived and rescued others back.\n",
                "King Valdus : Such a person that can't be seen in general.\n",
                "King Valdus : Well, since you have created goodness I have to pay back\n",
                "King Valdus : I appoint you as a passing knight, the highest rank above all soldiers.\n",
                "(Player) : What kind of knight is that?!\n",
                "Irene : It's such a beautiful name, Father.\n",
                "Annie : Wow!! The highest rank too (Player)!!\n",
                "Peony : The princess is beautiful, too.\n",
                "Daisy : I want to fly outside now.\n",
                "Lily : So can we stay here, princess?\n",
                "(Player) : Hey! Wait, why is it? What about the passing knight?\n",
                "(Player) : I just killed 10 goblins.\n",
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
            
            
            
            gameController.CombatPhase(player, goblinGuard, inventory.Items, fullinventory.Items, combat);
            
            
            //Debug
            player.Stats();
            //Scene1
            scene1_1.DisplayScene();
            //Scene1 Choice1
            if (gameController.ChoiceSelector(scene1_1.SceneIndex) == 1)
            {
                scene1_1C1.DisplayScene();
            }
            else if (gameController.ChoiceSelector(scene1_1.SceneIndex) == 2)
            {
                scene1_1C2.DisplayScene();
            }

            if (gameController.ChoiceSelector(scene1_2.SceneIndex) == 1)
            {
                scene1_2C1.DisplayScene();
            }
            else if (gameController.ChoiceSelector(scene1_2.SceneIndex) == 2)
            {
                scene1_2C2.DisplayScene();
            }

            if (gameController.ChoiceSelector(scene1_3.SceneIndex) == 1)
            {
                scene1_3C1.DisplayScene();
            }
            else if (gameController.ChoiceSelector(scene1_3.SceneIndex) == 2)
            {
                scene1_3C2.DisplayScene();
            }
            
            



            gameController.SelectSet(player, atkset, mpset, hpset, balanceset);
            
            inventory.OpenInventory();
            
            
            
            
            
        }
    }
}