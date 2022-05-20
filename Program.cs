using System;
using System.Collections.Generic;
using System.Linq;

Main();

void Main()
{
    int compScore = 0;
    int userScore = 0;
    RPSGenerator(null, null, compScore, userScore);
}

void whoWon (int compSelected, int userSelected, int userScore, int compScore)
{
    Console.Write($"{compSelected}, {userSelected}");
    if (compSelected == userSelected)
        Console.WriteLine("tie");
    else if (compSelected == 0){
        if(userSelected == 2){
            userScore++;
        }else{
            compScore++;
        }

    }else if (compSelected == 1){
         if(userSelected == 0){
            userScore++;
        }else{
            compScore++;
        }
    }
       
    else if (compSelected == 2){
         if(userSelected == 1){
            userScore++;
        }else{
            compScore++;
        }
    }
     RPSGenerator(null, null, userScore, compScore);
}





void RPSGenerator(Nullable<int> compSelected, Nullable<int> userSelected, int userScore, int compScore)
{
    
    Console.WriteLine("---------------------");
    Console.WriteLine($"| Player : {userScore}  | Computer: {compScore}");
    Console.WriteLine("---------------------");
    Console.WriteLine("");
    Console.WriteLine("What would you like to throw?");
    Console.WriteLine("1 Rock");
    Console.WriteLine("2 Paper");
    Console.WriteLine("3 Scissors");
    Console.WriteLine();
    int answer = Int32.Parse(Console.ReadLine());
    answer = answer -1;
    Random r = new Random();
    int genRand = r.Next(0, 2);
    List<string> answers = new List<string>()
    {
$@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
",
        $@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
",
$@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
"
    };
    string compAttack = answers[genRand];
    Console.WriteLine($"{compAttack}     vs    ");
    if (answer == 0 )
        Paper();
    else if ( answer == 1 )
        Rock();
     else if ( answer == 2)
        Scissors();
     else if ( answer == 9)
     Environment.Exit(-1);
    
    
    whoWon(genRand, answer, userScore, compScore);
    
    
}

void Rock()
{
    Console.WriteLine($@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");

}
void Paper()
{
    Console.WriteLine($@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
");

}
void Scissors()
{
    Console.WriteLine($@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
");

}


