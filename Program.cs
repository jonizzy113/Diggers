using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers
{
    class Program
    {
        static void Main(string[] args)
        {
            Ant ant = new Ant();
            ant.WillWalkOnGround = true;
            ant.LegCount = 2;

            BettaFish bettafish = new BettaFish();
            bettafish.WillSwim = true;
            bettafish.IsCute = true;

            CopperHeadSnake copperheadsnake = new CopperHeadSnake();
            copperheadsnake.WillWalkOnGround = true;
            copperheadsnake.Size = "7";

            EarthWorm earthworm = new EarthWorm();
            earthworm.WillDig = true;
            earthworm.SizeInInches = 5;

            Finches finche = new Finches();
            finche.WillFly = true;
            finche.LastName = "Jim";

            Gerbils gerbil = new Gerbils();
            gerbil.WillWalkOnGround = true;
            gerbil.FluffLevel = "average";

            Mice mice = new Mice();
            mice.WillWalkOnGround = true;
            mice.CuteLevel = "huge";

            Parakeets parakeet = new Parakeets();
            parakeet.WillFly = true;
            parakeet.NumberOfWings = 5;

            Terrapins terrapin = new Terrapins();
            terrapin.WillWalkOnGround = true;
            terrapin.Name = "Jon";

            TimberRattleSnake timberrattlesnake = new TimberRattleSnake();
            timberrattlesnake.WillWalkOnGround = true;
            timberrattlesnake.Color = "brown";

            FlyContainer flycontainer = new FlyContainer();
            flycontainer.FlyBox.Add(parakeet);
            flycontainer.FlyBox.Add(finche);

            SwimContainer swimcontainer = new SwimContainer();
            swimcontainer.SwimBox.Add(bettafish);

            DigContainer digcontainer = new DigContainer();
            digcontainer.DigBox.Add(earthworm);

            WalkContainer walkcontainer = new WalkContainer();
            walkcontainer.WalkBox.Add(timberrattlesnake);
            walkcontainer.WalkBox.Add(terrapin);
            walkcontainer.WalkBox.Add(mice);
            walkcontainer.WalkBox.Add(gerbil);
            walkcontainer.WalkBox.Add(copperheadsnake);
            walkcontainer.WalkBox.Add(ant);
        }
    }
}
