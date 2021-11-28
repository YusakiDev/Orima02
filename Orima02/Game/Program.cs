using System;
using System.Collections;
using System.Collections.Generic;

namespace Orima02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Combat Class Declaration
            Combat combat = new Combat();
            
            //Enemy Declaration
            GoblinGuard goblinGuard = new GoblinGuard("Goblin Guard", 20, 20, 2, 0, 3, true, false, false,2,0,0,new List<int>(){}, new List<int>());
            GoblinWarrior goblinWarrior = new GoblinWarrior("Goblin Warrior", 40, 40, 3, 0, 3, true, false, false,3,0,0,new List<int>(){}, new List<int>());
            PoisonGoblin poisonGoblin = new PoisonGoblin("Poison Goblin", 60, 60, 4, 0, 3, true, false, false,4,0,0,new List<int>(){}, new List<int>());
            MuscularGoblin muscularGoblin = new MuscularGoblin("Muscular Goblin", 80, 80, 5, 0, 3, true, false, false,5,0,0,new List<int>(){}, new List<int>());
            KingGoblin kingGoblin= new KingGoblin("King Goblin", 100, 100, 6, 0, 3, true, false, false,6,0,0,new List<int>(){}, new List<int>());


            //Character Declaration
            Character player = new Character();


            //Skill Declaration
            Skill cheat = new Skill(SkillName.Cheat,SkillType.Passive,"double your atk", 0);
            Skill cheatChance = new Skill(SkillName.CheatChance,SkillType.Active, "50/50 to double your atk or get punish", 3);
            Skill itemCheat = new Skill(SkillName.ItemCheat,SkillType.Active, "have another the item phase", 3);
            Skill regeneration = new Skill(SkillName.Regeneration,SkillType.Passive, " regenerate hp", 0);
            Skill heavyAttack = new Skill(SkillName.HeavyAttack,SkillType.Active, $"deal {player.Atk + 2} damage to enemy", 3);
            Skill fear = new Skill(SkillName.Fear,SkillType.Active, "enemy atk decrease to 0 ", 3);
            Skill mpRegen = new Skill(SkillName.MpRegen,SkillType.Passive, "regenerate mp", 0);
            Skill poisonAttack = new Skill(SkillName.PoisonAttack,SkillType.Active, "deals 2 damage to enemy and poisoned it", 3);
            Skill heal = new Skill(SkillName.Heal,SkillType.Active, "+4 hp to player", 3);
            
            //Skill Inventory Declaration
            var allSkill = new ArrayList 
                {cheat, cheatChance, itemCheat, regeneration, heavyAttack, fear, mpRegen, poisonAttack, heal};


            



            //game controller Declaration
            GameController gameController = new GameController();


            //Method
            gameController.Menu();
            //Select Class
            switch (gameController.SelectClass())
            {
                case 1:
                {
                    player = new Character(gameController.GetName(),CharClass.Magician, 12, 12, 12, 12, 3, true, false, false, 3,0,0 ,new ArrayList(){mpRegen,poisonAttack,heal});
                    break;
                }
                case 2:
                {   
                    player = new Character(gameController.GetName(),CharClass.Swordsman, 12, 12, 9, 9, 5, true, false, false,5,0,0,new ArrayList(){regeneration,heavyAttack,fear});
                    break;
                }
                case 3:
                {
                    player = new Character(gameController.GetName(),CharClass.Volunteer, 16, 16, 9, 9, 1, true, false, false,1,0,0,new ArrayList(){cheat,cheatChance,itemCheat});
                    break;
                }
                
            }
            
            
            
            
            
            
            //Item Declaration
            EquipAbleItem atkSet = new EquipAbleItem(ItemName.AtkSet, 3, 1, 1, "Equip Atk Set");
            EquipAbleItem mpSet = new EquipAbleItem(ItemName.MpSet, 1, 3, 1, "Equip MP Set");
            EquipAbleItem hpSet = new EquipAbleItem(ItemName.HpSet, 1, 3, 1, "Equip HP Set");
            EquipAbleItem balanceSet = new EquipAbleItem(ItemName.BalanceSet, 2, 2, 2, "Equip Balance Set");
            UseAbleItem fullRegen =
                new UseAbleItem(ItemName.FullRegen, "Instantly regenerate to full Hp");
            UseAbleItem doubleDamage =
                new UseAbleItem(ItemName.DoubleDamage, "Double your Atk");
            UseAbleItem fullMp =
                new UseAbleItem(ItemName.FullMp, "Instantly regenerate to full Mp");
            UseAbleItem stunBomb =
                new UseAbleItem(ItemName.StunBomb, "Stun your enemy for 1 turn");
            UseAbleItem poisonBomb =
                new UseAbleItem(ItemName.PoisonBomb, "poisoned your enemy");
            UseAbleItem damageBomb =
                new UseAbleItem(ItemName.DamageBomb, "deals 5 damage at the enemy");
            UseAbleItem trapDeflect =
                new UseAbleItem(ItemName.TrapDeflect, "Reverse all damage to the enemy (this item will be active on the enemy auto attack turn)");
            UseAbleItem trapUltimate =
                new UseAbleItem(ItemName.TrapUltimate, "Steal enemy's Ultimate (this item will be active on the enemy ultimate turn)");
            UseAbleItem trapWeakness = 
                new UseAbleItem(ItemName.TrapWeakness, "Set enemy damage to half");
            UseAbleItem abilityTheWorld =
                new UseAbleItem(ItemName.AbilityTheWorld, "Stunt enemy for 1-3 turn");
            UseAbleItem abilityOra =
                new UseAbleItem(ItemName.AbilityOra, "multiply player attack by 4");
            UseAbleItem abilityUseLeg =
                new UseAbleItem(ItemName.AbilityUseLeg, "50/50 chance to skip the current stage");
            
            
            
            

            //Inventory Declaration
            Inventory inventory = new Inventory(new ArrayList() {trapDeflect, trapUltimate,trapWeakness});
            Inventory stage1 = new Inventory(new ArrayList() {fullRegen, doubleDamage, fullMp});
            Inventory stage2 = new Inventory(new ArrayList() {stunBomb, poisonBomb, damageBomb});
            Inventory stage3 = new Inventory(new ArrayList() {trapDeflect, trapUltimate, trapWeakness});
            Inventory stage4 = new Inventory(new ArrayList() {abilityTheWorld, abilityOra, abilityUseLeg});
            Inventory fullInventory = new Inventory(new ArrayList()
            {fullRegen, doubleDamage, fullMp, stunBomb,
                poisonBomb,
                damageBomb,
                trapDeflect,
                trapUltimate,
                trapWeakness,
                abilityTheWorld,
                abilityOra,
                abilityUseLeg
            });
            
            
            
            
            
            
             //Scene Declaration
             Scene scene1_1 = new Scene(1.1, 10, new[]
            {
                "[1/5] While you are traveling had passed through the forest in the same area as the Feri City Kingdom.\n",
                "[2/5] which is a forest inhabited by goblins Or almost called their forest. While walking, you meet a young woman.\n",
                $"[3/5] {player.Name} : Is that a woman? \n",
                $"[4/5] {player.Name} : A woman in a forest with herds of goblins?\n",
                $"[5/5] {player.Name} : Let's enter to greet her.\n"
            });

            Scene scene1_1C1 = new Scene(1.1, 10, new[]
            {
                $"[1/6] {player.Name} : Hey that woman over there.\n",
                "[2/6] ??? : Who are you?\n",
                $"[3/6] {player.Name} : My name is {player.Name}\n",
                $"[4/6] {player.Name} : I'm just a man passing this way.\n",
                $"[5/6] {player.Name} : And you?\n",
                "[6/6] Irene : My name is Irene the Felicity, I'm the princess of the Felicity Kingdom.\n"
            });

            Scene scene1_1C2 = new Scene(1.1, 10, new[]
            {
                $"[1/3] {player.Name} : I'm arrogant, better not go in\n",
                "[2/3] Dev : You can't be that arrogant. If so, how will the game continue?\n",
                "[3/3] Dev : Go in and say hi to that woman now.\n"
            });
            Scene scene1_2 = new Scene(1.2, 10, new[]
            {
                "[1/1]Narrator : You met the princess of the Feri City Kingdom……but in the forest?\n",
            });
            Scene scene1_2C1 = new Scene(1.2, 10, new[]
            {
                $"[1/9] {player.Name} : Princess, why are you here?\n",
                "[2/9] Irene : I don't like the atmosphere in the palace. So I went out for a walk.\n",
                "[3/9] Irene : Accidentally wandered into the forest So I had to stop walking Otherwise I would have been lost in the deep forest.\n",
                $"[4/9] {player.Name} : Princess, you shouldn't be here.\n",
                $"[5/9] {player.Name} : This forest was inhabited by goblins. They are also very dangerous.\n",
                $"[6/9] {player.Name} : You should hurry out of here.\n",
                $"[7/9] {player.Name} : Let me protect you until you return to the palace?\n",
                "[8/9] Irene : It's okay, I can remember the way back.\n",
                $"[9/9] Irene : Have a safe journey. {player.Name}\n"
            });
            Scene scene1_2C2 = new Scene(1.2, 10, new[]
            {
                $"[1/13] {player.Name} : Salute Princess of the Kingdom\n",
                $"[2/13] {player.Name} : Sorry to spoil your manners with the princess.\n",
                "[3/13] Irene : There is no need to pay great respects.\n",
                "[4/13] Irene : Keep your head up\n",
                $"[5/13] {player.Name} : Princess, why are you here?\n",
                "[6/13] Irene : I don't like the atmosphere in the palace. So I went out for a walk.\n",
                "[7/13] Irene : Accidentally wandered into the forest So I had to stop walking Otherwise I would have been lost in the deep forest.\n",
                $"[8/13] {player.Name} : Princess, you shouldn't be here.\n",
                $"[9/13] {player.Name} : This forest was inhabited by goblins. They are also very dangerous.\n",
                $"[10/13] {player.Name} : You should hurry out of here.\n",
                $"[11/13] {player.Name} : Let me protect you until you return to the palace?\n",
                "[12/13] Irene : It's okay, I can remember the way back.\n",
                $"[13/13] Irene : Have a safe journey. {player.Name}\n"
            });
            Scene scene1_3 = new Scene(1.3, 10, new[]
            {
                "[1/3] Narrator : Princess Irene said goodbye to you and returned to the way she came.\n",
                "[2/3] ??? : Ahhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh. Help me!!\n",
                "[3/3] Narrator : Someone is crying for help. Will you help me?\n"
            });
            Scene scene1_3C1 = new Scene(1.3, 10, new[]
            {
                "\n",
                //skip to scene2
            });
            Scene scene1_3C2 = new Scene(1.3, 10, new[]
            {
                "[1/4] Ending1 - Developer Frame\n",
                "[2/4] Narrator : You walked backwards from the cry for help. After that\n",
                "[3/4] Narrator : a loud scream rang out in the forest following behind him.\n",
                "[4/4] Narrator :  and the cry for help was silenced.\n"
            });
            Scene scene2_1 = new Scene(2.1, 10, new[]
            {
                "[1/4] Narrator: The goblins are besieging the princess.\n",
                "[2/4] Irene : Help me!!\n",
                $"[3/4] {player.Name} : There are too many of them. If I break in without a weapon, I'm sure I will lose.\n",
                $"[4/4] {player.Name} : (Equitable Item Set) must be prepared first.\n"
            });
            Scene scene2_2 = new Scene(2.2, 10, new[]
            {
                $"[1/5] {player.Name} : Oh hey! Where has the princess gone?\n",
                $"[2/5] {player.Name} : Where has the princess gone? I haven't shown off my coolness yet.\n",
                $"[3/5] {player.Name} : If I had to guess, they would have taken the princess to the Goblin Castle. in order to bring the princess to their king\n",
                $"[4/5] {player.Name} : Wait, which way is Goblin Castle?\n",
                $"[5/5] {player.Name} : Ah crap. After getting cool, I don't know the way anymore. If someone can guide me that would be great.\n"
            });
            Scene scene3_1 = new Scene(3.1, 10, new[]
            {
                "[1/30] {on the way}\n",
                "[2/30] ??? : Hey! \n",
                $"[3/30] {player.Name} : What!\n",
                "[4/30] ??? : I'm here walk carefully.\n",
                $"[5/30] {player.Name} : Are you a Fairy?\n",
                "[6/30] Fairy : How do you see it otherwise?\n",
                $"[7/30] {player.Name} : Does the fairy live here? Everywhere I looked, I saw only goblins.\n",
                "[8/30] Fairy : Don't you think there are other living beings in the forest!\n",
                "[9/30] Fairy : And my name is not Fairy, Anemone is my name. Or you can call it Annie.\n",
                $"[10/30] {player.Name} : Alright Annie, I'm leaving.\n",
                "[11/30] (Annie) : Wait!!\n",
                "[12/30] (Annie) : You haven't introduced yourself yet. Just had to talk a few sentences, where are you going to hurry?\n",
                $"[13/30] {player.Name} : I am {player.Name} I Just passing through an event that must be involved in the inevitable.\n",
                "[14/30] Narrator  You have told Annie about the previous incident.\n",
                "[15/30] Annie : ok i get it.\n",
                "[16/30] Annie : Goblin again? Do they think they own the forest?\n",
                "[17/30] Annie : It's not just humans that are hurt by them. The goblins also attacked my friends. Everyone panicked and ran away.\n",
                "[18/30] Annie : So now I have to be alone. And I don't even know where the other fairies are.\n",
                $"[19/30] {player.Name} : If so, would you like to go with me?\n",
                "[20/30] Annie : Why should I go with you!\n",
                $"[21/30] {player.Name} : I don't know. Maybe during the journey to save the princess. I might even meet another fairy.\n",
                $"[22/30] {player.Name} : But as you wish, I'll leaving now\n",
                "[23/30] Annie : Wait! I'll go with you.\n",
                "[24/30] Annie : Where do you want to go? I'm an expert in this forest. Wherever it is, I know it all!\n",
                $"[25/30] {player.Name} : Okay, so where's the Goblin Castle?\n",
                "[26/30] Annie : Just go left! Or on the right! Maybe.... I don't know, who wants to go for a walk around the Goblin Castle!\n",
                $"[27/30] {player.Name} : Be quiet! Behind you have a goblin.\n",
                "[28/30] Annie : Come on!! Who's afraid?!!\n",
                "[29/30] Goblin : Hokpip!?\n",
                $"[30/30] {player.Name} : Wait! The fighter is me!\n",


                // fight
            });
            Scene scene4_1 = new Scene(4.1, 10, new[]
            {
                $"[1/20] {player.Name} : You are the one who challenged them. But why do I have to fight instead!\n",
                "[2/20] Annie : I don't know, I'm probably too cute.\n",
                $"[3/20] {player.Name} : Then I'd better take her as a hostage instead of the princess. Hmm..interesting.\n",
                "[4/20] Annie : Sorry!! I won't be loud anymore.\n",
                "[5/20] Annie : Let's go find the Goblin Castle!\n",
                "[6/20] {see grandma and grandpa}\n",
                "[7/20] Annie : There are people over there.\n",
                "[8/20] player.Name} : Grandfather and grandmother? Are there human beings here?\n",
                "[9/20] Annie : Don't forget that this forest It's not just the goblins. Those two might be some creatures living in this forest.\n",
                "10/20] Annie : We'd better go in and ask for directions.\n",
                "[11/20] {Go and talk to Grandpa and Grandma.}\n",
                "[12/20] Annie : Hello, we are looking for the Goblin Castle. Do you guys know where it is?\n",
                "[13/20] granny : We know, it's deep in the woods. You guys have to go left and walk a little deeper into the forest.\n",
                "[14/20] grandpa : Don't listen to old grandma. That's not the way to Goblin Castle. It's the way to the Tiger Cave.\n",
                "[15/20] grandpa : The correct way to the Goblin Castle is On the right?\n",
                "[16/20] granny : Don't be foolish Forgetful and still want to come and tell you the way again. The castle must go to the left separately.\n",
                $"[17/20] {player.Name} : Who can I believe?\n",
                "[18/20] Annie : Excuse me. So, where exactly do we have to go?\n",
                "[19/20] granny : On the left\n",
                "[20/20] grandpa : On the right\n",
            });
            Scene scene4_1C1 = new Scene(4.1, 10, new[]
            {
                "\n"
                //go to scene 5
            });
            Scene scene4_1C2 = new Scene(4.1, 10, new[]
            {
                "[1/12] Annie : I think the way is weird. Can we really trust Grandpa?\n",
                $"[2/12] {player.Name}: What cave is that?\n",
                "[3/12] ???: Rrrrrr.\n",
                $"[4/12] {player.Name}: Goblin Castle?. This is clearly a tiger's cave.\n",
                "[5/12] Annie : Runnnn!!\n",
                "[6/12] {Come out and talk to Grandma again}\n",
                "[7/12] Grandfather : How is the Goblin Castle?\n",
                $"[8/12] {player.Name} : Yeah i Found a big goblin ==.\n",
                "[9/12] Annie : I think I only see tigers.\n",
                $"[10/12] {player.Name} : Shhhh Annie\n",
                "[11/12] Grandma : You see, old man? Forgetful and still want to tell others the way\n",
                "[12/12] {Go back to choose a new way} \n"
            });
            Scene scene4_2 = new Scene(4.1, 10, new[]
            {
                "[1/3] Annie : hmm wait is that a goblin?\n",
                "[2/3] Annie : that goblin is blocking our way\n",
                $"[3/3] {player.Name} : yea let kill them!\n"
            });
            
            
            Scene scene5_1 = new Scene(5.1, 10, new[]
            {
                "[1/20] Annie : That's the goblin castle.\n",
                $"[2/20] {player.Name} : Be careful, it's full of goblins outside.\n",
                $"[3/20] {player.Name} : Let's go in!\n",
                "[4/20] Goblin1 : I smell a strange smell.\n",
                "[5/20] Goblin2 : I don't fart, idiot.\n",
                "[6/20] Goblin1 : No, I mean I smell human.\n",
                "[7/20] Goblin2 : Just had a human coming in.\n",
                "[8/20] Goblin1 : Not that princess I smelled a new, unfamiliar scent.\n",
                "[9/20] Goblin2 : Are you crazy?\n",
                "[10/20] Goblin1 : I'm not crazy I really smell it\n",
                "[11/20] Annie : They look like they can smell you.\n",
                $"[12/20] {player.Name} : We will not be careless.\n",
                "[13/20] Irene : Help me!!!\n",
                $"[14/20] {player.Name} : Princess voice! she is here\n",
                "[15/20] Annie : It seems that there are many floors here. And there are still a lot of rooms.\n",
                "[16/20] Annie : How do we know where she is?\n",
                $"[17/20] {player.Name} : I guess the princess must be in the Goblin King's room.\n",
                "[18/20] Annie : And where is it?\n",
                $"[19/20] {player.Name} : I came in with you How could I know!\n",
                "[20/20] Annie : That's right, let's go find the princess. Perhaps she was at the top of the castle.\n",


                //fight
            });
            Scene scene6_1 = new Scene(6.1, 10, new[]
            {
                "[1/10] Annie : Finally got to the 2nd floor\n",
                $"[2/10] {player.Name} : The goblins were not weak at all.\n",
                "[3/10] Irene : Don't touch me!!\n",
                $"[4/10] {player.Name} : A loud noise came from upstairs.\n",
                $"[5/10] {player.Name} : We have to hurry\n",
                "[6/10] [Last Floor : King's Room]\n",
                "[7/10] Irene : Let me out now!!\n",
                $"[8/10] {player.Name} : Princess!!\n",
                $"[9/10] Irene : {player.Name} with a fairy?\n",
                $"[10/10] {player.Name} : We have come to save the princess.\n",
                //fight
            });
          

            Scene scene6_2 = new Scene(6.2, 10, new[]
            {
                "[1/30] Irene : Thank you very much I don't know who the other fairy is.\n",
                $"[2/30] {player.Name} : This is Anemone, or you can call it Annie for short.\n",
                $"[3/30] {player.Name} : We met on our way out to find the princess.\n",
                "[4/30] Irene : during the capture As if I could see that other fairies were trapped. If I'm not mistaken, it's probably on the second floor.\n",
                $"[5/30] Annie : Really! They must be my friends. Let's go help them. {player.Name}\n",
                "[6/30] {Help the other fairies come out}\n",
                "[7/30] Lily : Look at that, Annie, we're here!!\n",
                "[8/30] Daisy : She came with two humans too.\n",
                "[9/30] Peony : It seems like the other person is the princess of the Feri City Kingdom.\n",
                "[10/30] Daisy : Do you know her? Peony\n",
                "[11/30] Peony : This kingdom is not far from our forest. There must be only you who do not know each other.\n",
                "[12/30] Lily : I could see that the goblins took her to the top floor here.\n",
                "[13/30] Peony : Maybe another human can help.\n",
                "[14/30] Annie : Hey!! Lily Daisy Peony, I'm here to help.\n",
                $"[15/30] {player.Name} : Three more fairies?\n",
                "[16/30] Irene : It's the name of every flower.\n",
                $"[17/30] Annie : Lliy Daisy Peony  This person is a {player.Name} is a man who has come across an incident that must be involved inevitably.\n",
                "[18/30] Irene : What does inevitable involvement mean?\n",
                $"[19/30] {player.Name} : Forget it...\n",
                "[20/30] Annie : This person is Princess Irene de Felicity\n",
                $"[21/30] Annie : This {player.Name} Irene, these three are my friends. They are name...\n",
                $"[22/30] {player.Name} : We've all heard her call. nice to meet you.\n",
                "[23/30] Irene : Nice to meet you\n",
                "[24/30] Peony : H.. Hello, Princess\n",
                "[25/30] Lily : Peony really likes princesses. She always secretly flew out to the palace gardens.\n",
                "[26/30] Daisy : Yes\n",
                "[27/30] Irene : You can come and live in the gardens of the palace.\n",
                "[28/30] Peony : Really?!!\n",
                "[29/30] Annie : Let's talk about that later. Let's hurry out of here.\n",
                "[30/30] {leave the castle}\n",
            });
            Scene scene7_1 = new Scene(7.1, 10, new[]
            {
                "[1/9] {back in the forest}\n",
                $"[2/9] {player.Name} : Be careful There were still some goblins outside.\n",
                "[3/9] Irene : I remember that on the way out of the forest to the palace, there were Goblin Warriors.\n",
                "[4/9] Irene : Be careful everyone\n",
                "[5/9] Lily : they are there\n",
                "[6/9] Daisy : I don't want to be taken back there again.\n",
                "[7/9] Peony : Be careful princess\n",
                "[8/9] Annie : Princess, please step back.\n",
                $"[9/9] {player.Name} : Hey! I'm a fighter Aren't you worried about me?\n",
                //fight
            });
            Scene scene7_2 = new Scene(7.2, 10, new[]
                {
                "[1/34] Irene : “The fighting skills are excellent. This must be notified to Father to consider.(thinking in her mind)\n",
                "[2/34] Annie : Wow! Finally got out of the forest\n",
                "[3/34] Peony : Princess, be careful to stumble across the grass!!\n",
                "[4/34] Daisy : It's like this outside of the forest!!\n",
                "[5/34] Lily : There are lots of flowers there!!\n",
                $"[6/34] {player.Name} : Nobody really cares about me!\n",
                "[7/34] {go to the palace}\n",
                "[8/34] Irene : Father!\n",
                "[9/34] King Valdus : Where have you been, daughter? Everyone in the palace was chaotic looking for you.\n",
                "[10/34] Irene : I thought I would never come back to see you again.\n",
                $"[11/34] {player.Name} : Do I have to pay respects?  (Think in his mind)\n",
                "[12/34] King Valdus : What happened to you?\n",
                "[13/34] Narrato You have told the king all the story.\n",
                "[14/34] King Valdus : Hmm...do you have any hesitation in helping her?\n",
                $"[15/34] {player.Name} : No, I didn't hesitate one bit.\n",
                $"[16/34] {player.Name} : Fortunately, the princess was saved. (thinking in your head)\n",
                "[17/34] Annie : hey what are you Your face doesn't look good at all?\n",
                "[18/34] King Valdus : I am deeply grateful to you.\n",
                "[19/34] King Valdus : If I had to lose her I will surely die.\n",
                $"[20/34] Irene : Father {player.Name} has excellent fighting skills.\n",
                "[21/34] King Valdus : Hmm, I can feel that this person is truly extraordinary.\n",
                "[22/34] King Valdus : He was just a (professional) passerby, but was able to fight adept at fighting strong and ferocious goblins.\n",
                "[23/34] King Valdus :  And survived and rescued others back.\n",
                "[24/34] King Valdus : Such a person that can't be seen in general.\n",
                "[25/34] King Valdus : Well, since you have created goodness I have to pay back\n",
                "[26/34] King Valdus : I appoint you as a passing knight, the highest rank above all soldiers.\n",
                $"[27/34] {player.Name} : What kind of knight is that?!\n",
                "[28/34] Irene : It's such a beautiful name, Father.\n",
                $"[29/34] Annie : Wow!! The highest rank too {player.Name}!!\n",
                "[30/34] Peony : The princess is beautiful, too.\n",
                "[31/34] Daisy : I want to fly outside now.\n",
                "[32/34] Lily : So can we stay here, princess?\n",
                $"[33/34] {player.Name} : Hey! Wait, why is it? What about the passing knight?\n",
                $"[34/34] {player.Name} : I just killed 10 goblins.\n",
            });

            Scene credit = new Scene(8, 50, new[]
            {
                "Good Ending!\n" +
                "\n" +
                "Thank you for playing our game.\n",
                "We have put a lot of effort into this game to make it as perfect as possible\n" +
                "thank you for your support and your feedback\n" +
                "It will definitely improve our game\n" +
                "\n" +
                "- Mashed Potato Group\n" +
                "\n" +
                "Game Design\n" +
                "- Puree Pangma\n" +
                "\n" +
                "Character & Item Design\n" +
                "- Puree Pangma\n" +
                "- Pongsapas Siriwong\n" +
                "- Pitcha Hutajuta\n" +
                "\n" +
                "Story Design\n" +
                "- Narapat Moungsree\n" +
                "- Pathitta Khanathikul\n" +
                "\n" +
                "Programming\n" +
                "- 95% Puree Pangma\n" +
                "- 5% Pitcha Hutajuta\n" +
                "\n" +
                "Translation and Decoration\n" +
                "- Puree Pangma\n" +
                "- Pongsapas Siriwong\n" +
                "- Pitcha Hutajuta\n"
            });
                
            
            //Debug
            //player.Stats();
            //Scene1
            Console.Clear();
            scene1_1.DisplayScene();
            //Scene1 Choice1
            var userInput = gameController.ChoiceSelector(scene1_1.SceneIndex);
            switch (userInput)
            {
                case 1:
                    scene1_1C1.DisplayScene();
                    break;
                case 2:
                    scene1_1C2.DisplayScene();
                    break;
            }
            scene1_2.DisplayScene();
            
            userInput = gameController.ChoiceSelector(scene1_2.SceneIndex);
            switch (userInput)
            {
                case 1:
                    scene1_2C1.DisplayScene();
                    break;
                case 2:
                    scene1_2C2.DisplayScene();
                    break;
            }
            scene1_3.DisplayScene();
            
            userInput = gameController.ChoiceSelector(scene1_3.SceneIndex);
            switch (userInput)
            {
                case 1:
                    scene1_3C1.DisplayScene();
                    break;
                case 2:
                    scene1_3C2.DisplayScene();
                    goto Ending1;
            }
            
            
            //Scene2
            scene2_1.DisplayScene();
            //picking item
            gameController.SelectSet(player, atkSet, mpSet, hpSet, balanceSet);
            scene2_2.DisplayScene();
            
            
            //Scene3
            scene3_1.DisplayScene();
            //fight
            gameController.CombatPhase(player, goblinGuard, inventory.Items, allSkill, fullInventory.Items, combat);
            gameController.RandomStage1(inventory,inventory.Items, stage1.Items);
            //Scene4
            scene4_1.DisplayScene();
            userInput = gameController.ChoiceSelector(scene4_1.SceneIndex);
            switch (userInput)
            {
                case 1:
                    scene4_1C1.DisplayScene();
                    break;
                case 2:
                    scene4_1C2.DisplayScene();
                    break;
            }
            scene4_2.DisplayScene();
            //fight
            gameController.CombatPhase(player, goblinWarrior, inventory.Items, allSkill,fullInventory.Items, combat);
            gameController.RandomStage2(inventory,inventory.Items, stage2.Items);
            
            //Scene5
            scene5_1.DisplayScene();
            //fight
            gameController.CombatPhase(player, poisonGoblin, inventory.Items, allSkill,fullInventory.Items, combat);
            gameController.RandomStage3(inventory,inventory.Items, stage3.Items);
            //Scene6
            scene6_1.DisplayScene();
            //fight
            gameController.CombatPhase(player, muscularGoblin, inventory.Items, allSkill,fullInventory.Items, combat);
            gameController.RandomStage4(inventory,inventory.Items, stage4.Items);
            scene6_2.DisplayScene();
            
            //Scene7
            scene7_1.DisplayScene();
            //fight
            gameController.CombatPhase(player, kingGoblin, inventory.Items, allSkill,fullInventory.Items, combat);
            scene7_2.DisplayScene();
            credit.DisplayScene();

        Ending1:
        Console.WriteLine("Bad Ending!\n" +
                          "Thanks for Playing!");
        
        }
        
    }
}