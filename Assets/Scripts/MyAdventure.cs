using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro,
        introduction,
        sit,
        runaway,
        pickaclass,
        smartass,
        magicclass,
        meleeclass,
        paladin,
        darkknight,
        whitemage,
        blackmage,
        fight1,
        fight2,
        fight3,
        fight4,
        pldchoice,
        drkchoice,
        whmchoice,
        blmchoice,
        defend,
        attack,
        killorkill,
        heal,
        abandon,
        goback,
        mercy,
        kill,
        blmending1,
        whmending1,
        drkending,
        pldnending1,
        blmending2,
        whmending2,
        pldnending2,
        whmending3,

        

    }

    private States currentState = States.start;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void OnUserInput(string input)
    {
        if (currentState == States.start)
        {
                    if (input == "start")
            {
            StartIntro();
        }else if(input == "I wanna be a hero!")
            {
            Terminal.WriteLine("Sorry but you can't be a hero that easily.");
        }else if(input == "DSWE")
            {
            Terminal.WriteLine ("I am sorry but your certificates as a professor hold no merrit in this new world");
            }
        else
            {
            Terminal.WriteLine("You have to type start to play the game sir.");
            }
        }else if(currentState == States.intro) 
        {
            if (input == "continiue")
            {
                introduction();
            }
        }
        else if(currentState == States.introduction)
    {
        if (input == "sit")
        {
            sit();
        }
   
    if (input == "run")
    {
        runaway();
    }
    }


    else if(currentState == States.sit)
    {
        if (input == "class")
        {
            pickaclass();
        }
        if (input == "smartass")
        {
            smartass();
        }
    }
    else if(currentState == States.smartass)
    {
        if (input == "continiue")
        {
        Terminal.ClearScreen();
        Terminal.WriteLine("Looking around you you notice that you are in the sky!");
        Terminal.WriteLine("And to make matters worse, you're falling to your death!");
        Terminal.WriteLine("Yet all of a sudden... You wake up.. Was it all a dream?");
        Terminal.WriteLine("GAMEOVER, BAD ENDING 1, FALLING TO YOUR OWN WORLD.");
        Terminal.WriteLine("Type restart to go back to the main menu");
        }
        if (input == "restart")
        {
            ShowMainMenu();
        }
    }
    else if(currentState == States.pickaclass)
    {
        if (input == "Melee")
        {
            meleeclass();
        }
        if (input == "Magic")
        {
            magicclass();
        }
    }

    else if (currentState == States.meleeclass)
    {
        if (input == "DRK")
        {
            fight2();
        }
        else if (input == "PLD")
        {
            fight1();
        }
    }
else if(currentState == States.magicclass)
{
    if (input == "continiue")
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("But do not fret, for every path you take there will always be a fate in which you live.");
        Terminal.WriteLine("Now then have you decided which path you wish to take my young subject?");
        Terminal.WriteLine("To follow the path of a Black Mage type BLM or type WHM to follow the path of a White Mage.");
    }
    if (input == "BLM")
    {
        blackmage();
    }
    if (input == "WHM")
    {
        whitemage();
    }
}
else if(currentState == States.blackmage)
    {
        if (input == "who are you")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("The woman smiles and places a reassuring hand on your shoulder before speaking.");
            Terminal.WriteLine("Oh don't kid around, I am your fellow adventurer, remember? We are suppos--");
            Terminal.WriteLine("Yet before she can finish her sentence a loud explosion is heard outside, the windows shatter infront of the two of you.");
            Terminal.WriteLine("Type continiue to go further.");
        }

    else if (input == "continiue")
    {
         Terminal.ClearScreen();
         Terminal.WriteLine("The two of you go outside and find that one of the White Mages from the neighbouring village has started to attack your village.");
         Terminal.WriteLine("Confused the two of you rush to the chaos to repel it but in the midst of the chaos your friend is hit by a Thundera IV spell.");
         Terminal.WriteLine("Enraged you rush towards the White Mage, intending to kill him. But you can hear a weakened voice coming from your Sending Stone.");
         Terminal.WriteLine("type proceed to go further.");
    }
    
    else if (input == "proceed")
    {
    fight4();
    }
    }
else if (currentState == States.blmending1)
{
    if (input == "continiue")
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("No it isn't fair! You can't allow this... Yet you can't do anything about it, a life cursed... Is it truly worth living?");
        Terminal.WriteLine("Would death be a better option? To just end it all now...? No that would be cowardish.. You caused this and you must watch it till the bards finally end its ballad of time.");
        Terminal.WriteLine("BLM ENDING 1 A BROKEN MAGE. BAD ENDING.");
        Terminal.WriteLine("Type Restart to go back to the main menu.");
    }
    else if (input == "Restart")
    {
        ShowMainMenu();
    }
}
    else if (currentState == States.blmending2)
    {
        if (input == "Continiue")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Yes for when you walk the village you can see the younger mages play around, a serene picture worthy of a painting.");
            Terminal.WriteLine("It doesn't matter that you don't have your friend with you anymore, the joy of seeing the future generation live a happy and safe life is more than enough for you.");
            Terminal.WriteLine("BLM ENDING 2 A FULLFILLED MAGE. GOOD ENDING.");
            Terminal.WriteLine("Type Restart to go back to the main menu.");
        }
        else if (input == "Restart")
        {
            ShowMainMenu();
        }
    }


    else if (currentState == States.kill)
    {
        if (input == "continiue")
        {
            blmending1();
        }
      
    }

    else if (currentState == States.mercy)
    {
        if (input == "continiue")
        {
            blmending2();
        }
    }
else if (currentState == States.fight4)
{
    if (input == "kill")
    {
        kill();
    }

    else if (input == "mercy" )
    {
        mercy();
    }
}
else if (currentState == States.whitemage)
{
    if (input == "surroundings")
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You notice you are not the only one here, there is a man, injured albeit alive.");
        Terminal.WriteLine("You remember being a White Mage, but this man.. He has never done anything for you. Will you save him or leave him?");
        Terminal.WriteLine("Write decision to make a decision.");
    }
    else if (input == "decision")
    {
        fight3();

    }
}
else if (currentState == States.fight3)
{
    if (input == "Abandon")
    {
        abandon();
    }
    else if (input == "safe")
    {
        heal();
    }
}
    else if (currentState == States.abandon)
    {
        if (input == "continiue")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("A choice, to return or fully commit to your earlier choice... Which path do you take?");
            Terminal.WriteLine("Type Return to return to the dying man or type Commit to abandon him.");
        }
        else if (input == "Return")
        {
            whmending2();
        }
        else if (input == "Commit")
        {
            whmending3();
        }
    }
    else if (currentState == States.heal)
    {
        if (input == "continiue")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("You smile soothingly, you're soft hand stroking the wound as you reassure him that all will be alright.");
            Terminal.WriteLine("While he is still shocked he seems to calm down as the wound starts to close thanks to your efforts, yet no words are spoken between the two of you.");
            Terminal.WriteLine("Instead once you are done you stand up and walk away.");
            Terminal.WriteLine("Type the end to see your ending.");
        }
        else if (input == "the end")
        {
            whmending1();
        }
    }

    else if (currentState == States.whmending1)
    {
        if (input == "proceed")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("And so it is that you become a legend, one that nobody knows is truth or mere stories... Yet the people you helped will always remember that ghostly visage.");
            Terminal.WriteLine("That image of you.. The one who Healed them.");
            Terminal.WriteLine("WHM ENDING 1. WHISPERS OF THE WHITE. GOOD ENDING.");
            Terminal.WriteLine("Type Restart to return to the main menu.");
        }
        else if (input == "Restart")
        {
            ShowMainMenu();
        }

    }
    else if (currentState == States.whmending2)
    {
        if (input == "learn")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("The man is astonished but doesn't say anything to you, leaving the other way you headed. But to the people of his village he tells his story.");
            Terminal.WriteLine("While you left him to die at first, you returned. And while he expected you to kill him you healed him... For a Price. So unbefitting of a White Mage.");
            Terminal.WriteLine("He spoke of how you saved him but at the cost of his wealth... And so a Legend was born. That of the White Mage dressed in Gray garbs.");
            Terminal.WriteLine("WHM ENDING 2. THE GRAYSCALE MAGE. GRAY ENDING.");
            Terminal.WriteLine("Type Restart to return to the main menu.");
        }
        else if (input == "Restart")
        {
            ShowMainMenu();
        }

    }
    else if (currentState == States.fight1)
    {
        if (input == "atk")
        {
            pldnending2();
        }
        else if (input == "def")
        {
            pldnending1();
        }
    }

    else if (currentState == States.fight2)
    {
        if (input == "my end")
        {
            drkending();
        }
    }
    else if (currentState == States.pldnending1)
    {
        if (input == "rebirth")
        {
            ShowMainMenu();
        }
    }
    else if (currentState == States.pldnending2)
    {
        if (input == "rebirth")
        {
            ShowMainMenu();
        }
    }
    else if (currentState == States.drkending)
    {
        if (input == "rebirth")
        {
            ShowMainMenu();
        }
    }
    else if (currentState == States.whmending3)
    {
        if (input == "run")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("You ran away, forever to leave your forest. You shunned your duties, a truly dispicable act... But why did you have to be so selfless as a White Mage?");
            Terminal.WriteLine("After all you performed miracles, saving lifes! Why can't YOU decide who LIVES or DIES?! Why do you have to heal EVERYONE!?");
            Terminal.WriteLine("It is truly an unjust fate... One you decided to abandon....");
            Terminal.WriteLine("WHM ENDING 3. THE ONE WHO REFUSED. BAD ENDING.");
            Terminal.WriteLine("Type Restart to return to the main menu.");
        }
        else if (input == "Restart")
        {
            ShowMainMenu();
        }
    }
    else if(currentState == States.runaway)
    {
        if (input == "continiue")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Too afraid to turn around you can feel it's teeth sinking into your neck");
            Terminal.WriteLine("The pain too much to bear for your nervoussystem causes it to shut down, a numb feeling now going over you.");
            Terminal.WriteLine("The last thing you hear is the demon's its tongue clacking against your back.");
            Terminal.WriteLine("GAME OVER, DEATHSCENE 1. DEMON FOOD.");
            Terminal.WriteLine("Type restart to go back to the main menu");
        }
    }
    if (input =="restart")
    {
        ShowMainMenu();
    }
    }
    
void StartIntro()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("Welcome to my laboratory");
    Terminal.WriteLine("Please do take a seat");
    Terminal.WriteLine("Type continiue to go further");
    currentState = States.intro;
}

    void introduction()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("The old man asks you to take a seat");
        Terminal.WriteLine("at the desk infront of him, do you sit down?");
        Terminal.WriteLine("Type SIT to sit down");
        Terminal.WriteLine("Type Run away to leave the room");
        currentState = States.introduction;
    }


void sit()
{
Terminal.ClearScreen();
Terminal.WriteLine("Ah very good, now then. You wish to be an adventurer, correct?");
Terminal.WriteLine("Well no need to answer, the fact you sat down says enough. Now then what class do you wish to be?");
Terminal.WriteLine("Please pick one of the four following classes: White Mage, Paladin,Dark Knight or Black Mage.");
Terminal.WriteLine("Type class to continiue to next scene");
currentState = States.sit;


}

void runaway()
{
Terminal.ClearScreen();
Terminal.WriteLine("You turn around and run away, however as you pass through the door");
Terminal.WriteLine("you feel a strange unease, a wicked shadow having formed behind you.");
Terminal.WriteLine("It speaks in a sluggish and demonic voice, yet it reminds you of the Professor from earlier.");
Terminal.WriteLine("Type continiue to go further.");
currentState = States.runaway;
}

void pickaclass()
{
Terminal.ClearScreen();
Terminal.WriteLine("Ah so you decided to not be a smartass, splendid!");
Terminal.WriteLine("Now then please do pick a class");
Terminal.WriteLine("Please type Melee for PLD/DRK or Magic for WHM/BLM.");
currentState = States.pickaclass;
}

void meleeclass()
{
Terminal.ClearScreen();
Terminal.WriteLine("So you decided to walk the path of Finesse and Brute Strength... Very well.");
Terminal.WriteLine("Well then you may pick between the following two classes. Be quick about it.");
Terminal.WriteLine("Will you be a self rightieous Paladin or a Self Absorbed Dark Knight? Choice... Now.");
Terminal.WriteLine("Type PLD for the path of a Paladin or type DRK for the road down the Abyss as a Dark Knight.");
currentState = States.meleeclass;
}

void magicclass()
{
Terminal.ClearScreen();
Terminal.WriteLine("My oh my, you have chosen the path of the Aetherflow, splendid!");
Terminal.WriteLine("Now then, there still remains the question. What path will you take?");
Terminal.WriteLine("Will you take the path of the Black Mage.. One filled with Discoveries and Adversaries?");
Terminal.WriteLine("Or will you take the path of the White Mage... One of selfessness and Sacrifice?");
Terminal.WriteLine("Please type continiue.");
currentState = States.magicclass;
}

void blackmage()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("You feel dizzy and your vision becomes blurry, yet before long you seemingly wake up in a bed.");
    Terminal.WriteLine("You are in a small room, there is a Lalafel sitting next of you asleep, she seemed to have been taking care of you.");
    Terminal.WriteLine("To ask what happened type, who are you?");
    currentState = States.blackmage;
}

void fight4()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("P-please do not kill him... It could cause endless misery for the two villages... Please my friend.");
    Terminal.WriteLine("You recognize the voice as that of the woman that helped you, yet you are still filled with rage. A choice has come to you.");
    Terminal.WriteLine("Do you kill the White mage or do you spare him...? Type Kill to kill him or Mercy to spare him.");
    currentState = States.fight4;
}

void kill()
{
Terminal.ClearScreen();
Terminal.WriteLine("Unable to control the anger inside of you you decide to end this man's life. Casting Fira V you scorch his body into the aetherflow. Forever to be gone.");
Terminal.WriteLine("Yet this choice had unforseen results, a war that would terrorize the world of Eorzea for years... And you?");
Terminal.WriteLine("You are scorned and cast out of the village... Forever to be remembered as a traitor and murderer... Even though you protected the village.");
Terminal.WriteLine("Type continiue to see the end results of your path.");
currentState = States.kill;
}

void mercy()
{
Terminal.ClearScreen();
Terminal.WriteLine("The voice seemingly calmed your nerves, able to think more clearly you decide to incapicitate the man but not kill him, he will be trialed for his sins.");
Terminal.WriteLine("the man is scared beyond belief but as you restrain him he calms down, the people that survived the attack are grateful. Tensions between the villages were already high enough.");
Terminal.WriteLine("type continiue to see the end results of your path.");
currentState = States.mercy;
}

void blmending1()
{
Terminal.ClearScreen();
Terminal.WriteLine("Thanks to your lineage as a Black Mage you can live for very long, but in your case this seems more like a curse. Forced to witness a hundred year war you caused.");
Terminal.WriteLine("Yet unable to do anything about it, a life of misery and dispair... Was this what you truly wanted? Was this what you deserved? You only wanted to avenge your friend after all!");
Terminal.WriteLine("This truly wasn't fair...");
Terminal.WriteLine("Type continiue to go further.");
currentState = States.blmending1;
}

void blmending2()
{
Terminal.ClearScreen();
Terminal.WriteLine("It is now that you can look back in peace, your friend while dead was in a better place... And your village? Not in an endless war, nay even you were regarded as a hero.");
Terminal.WriteLine("Yet sometimes you wonder, was this truly the right course? Was this truly what your friend wanted..? Should you have killed him after all?");
Terminal.WriteLine("But none of that matters now, the people live and that is what matters.");
Terminal.WriteLine("Type continiue to learn the full end of your journey.");
currentState = States.blmending2;
}
void whitemage()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("A sense of inner peace and equilibrium befalls over you and for a moment you close your eyes... Yet when you open them you are not in the office anymore.");
    Terminal.WriteLine("Instead you are in a forest, it's mystical and the roots seem to move at irregular intervals. Where are you?");
    Terminal.WriteLine("To look around type surroundings.");
    currentState = States.whitemage;
}

void fight3()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("It really isn't a hassle to heal him but... What is it worth to you? It's still not someone you care for.");
    Terminal.WriteLine("Do you decide to leave him or do you help him? Type Abandon to abandon him or type safe to save him.");
    currentState = States.fight3;
}
void abandon()
{
Terminal.ClearScreen();
Terminal.WriteLine("You walk away deciding it is not for you to heal him, yet after about ten minutes you stop. What about your oath?");
Terminal.WriteLine("You swore an oath to save the people of Twinwoods and this man is in your domain, as a White Mage it is your duty after all...");
Terminal.WriteLine("However.. If you go back you want to make it worth your while. A decision, one that will alter your future forever.");
Terminal.WriteLine("Type continiue to learn more.");
currentState = States.abandon;
}

void heal()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("Deciding it is your duty you walk over to the man, his wounds are more severe than you expected. Luckily you're in time to heal him, even with some time to spare!");
    Terminal.WriteLine("Kneeling down to his left side you begin to remove the bloodied top garb of his body, carefully and gently.");
    Terminal.WriteLine("The man opens his eyes and looks confused, it is now that you realize he's a Black Mage... One of your sworn enemies.");
    Terminal.WriteLine("Type continiue to learn more.");
    currentState = States.heal;
}

void whmending1()
{
Terminal.ClearScreen();
Terminal.WriteLine("Having healed a man who in very essence is your polar opposite, you have created a future in which wars might not be necessary. You follow your oath properly.");
Terminal.WriteLine("Yet despite the control you had in this situation there was no choice or control from you about the legend that formed around you...");
Terminal.WriteLine("People spread rumours about a White Mage Healing the wounded no matter their origin or affiliation... A ghostly image of you always fitting this story.");
Terminal.WriteLine("Type proceed to find out the rest.");
currentState = States.whmending1;
}
void whmending2()
{
Terminal.ClearScreen();
Terminal.WriteLine("You decided to return and heal the man, but when you arrived you told him he had to pay you afterwards, even more than the usual fee cause he was a Black Mage.");
Terminal.WriteLine("The man unable to speak merely nods as you heal him, your soft hand stroking the wound and closing it.");
Terminal.WriteLine("Having finished healing him you stand up and rummage through his belongings, taking all but one gil from it. Your payment.");
Terminal.WriteLine("Type learn to discover your fate.");
currentState = States.whmending2;
}
void whmending3()
{
Terminal.ClearScreen();
Terminal.WriteLine("Having decided to leave him to his fate you have in turn abandoned your duty as a White Mage.");
Terminal.WriteLine("But who could blame you, he was a Black Mage... Why should YOU heal HIM? He was your ENEMY after all!");
Terminal.WriteLine("Trying to justify it to yourself you hear a pair of voices from the place you came, other White Mages.. They found him.");
Terminal.WriteLine("You had to run, type run to leave the Twinwoods.");
currentState = States.whmending3;
}

void fight1()
{
Terminal.ClearScreen();
Terminal.WriteLine("You awaken in a chair, looking down a strategy map, it appears the city you woke up in is being besieged.");
Terminal.WriteLine("A group of other Paladins look at you expectingly. Finally one speaks up. 'So what path will we take? Defend or Attack sir?'");
Terminal.WriteLine("Which road will you go down... To attack or Defend? Type atk to march foreward or type def to prepare for a long siege.");
currentState = States.fight1;
}

void fight2()
{
Terminal.ClearScreen();
Terminal.WriteLine("You wake up in a dark cave, you remember your goal. To defeat the Lich in the cave you are in... Only one way this ends.");
Terminal.WriteLine("You know there is no other choice, you go down");
Terminal.WriteLine("You arrive infront of the lich, a battle ensues that you barely win... You know there is no other way... And so you pull down your blade at it's defenseless body.");
Terminal.WriteLine("Type my end to see your ending.");
currentState = States.fight2;
}

void drkending()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("You slayed the Lich, your duty fuffilled but you notice a path going further down. There was more to this tale that you did not know of yet.");
    Terminal.WriteLine("You walk down this dark path... Forever to dissapear, but not to die.");
    Terminal.WriteLine("DRK ENDING 1. A DARK PATH ENDING. GRAY ENDING.");
    Terminal.WriteLine("Type rebirth to return to the main menu.");
    currentState = States.drkending;
}

void pldnending1()
{
Terminal.ClearScreen();
Terminal.WriteLine("You decided to defend the city and not go out, this proved to be the best course of action. For not only your people but you yourself survived.");
Terminal.WriteLine("You got honoured as a hero and rewarded for your tactful mind, you became the hero you dreamed to be. How Wonderful.");
Terminal.WriteLine("PLD ENDING 1. GLORY IN LIFE. GOOD ENDING.");
Terminal.WriteLine("Type rebirth to return to the main menu.");
currentState = States.pldnending1;
}

void pldnending2()
{
Terminal.ClearScreen();
Terminal.WriteLine("You decided to attack the ones besieging your city, while heroic and couragous you did not survive, but your people did and they won the war thanks to your efforts.");
Terminal.WriteLine("You were honoured as a hero and your Sacrifical was sung about for many centuries, a hero in death... How truly pathetic.");
Terminal.WriteLine("PLD ENDING 2. HONOUR AFTER DEATH. GRAY ENDING.");
Terminal.WriteLine("Type rebirth to return to the main menu.");
currentState = States.pldnending2;
}
void smartass()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("So you're a Smartass type eh? Very well then our business here is done, Good day sir.");
    Terminal.WriteLine("I said Good Day Sir!");
    Terminal.WriteLine("As he says it for one second time the professor vanishes... Or is it you that vanished?");
    Terminal.WriteLine("Type continiue to go further");
    currentState = States.smartass;
}

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to Eorzea");
        Terminal.WriteLine("This story is based on events that may or may not be real.");
        Terminal.WriteLine("Type START to play the game.");
    }

    // Update is called once per frame
    void Update()
    {
        print(currentState);
    }
}
