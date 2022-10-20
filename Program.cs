//N. Harrison Wilkins
//10-19-2022
//GitHub Project Part 4 - ODD OR EVEN
//This console project will tell the user if they entered an odd or even number
//console will give user a message if they enter a value that is not viewed as a number



Console.Clear();

//VARIABLES ARE DEFINED BELOW
int userNumber;
userNumber = 0;

bool boolNumber = false;
bool parseNum = false;
bool isNum;

string defaultNumber;

//INTRO SEQUENCE OF GAME
    Console.Write("GREETINGS! ");
do{
isNum = false;
while(!isNum){
    Console.WriteLine("ENTER A NUMBER PLEASE! ANY NUMBER!");
//BEGINNING OF NUMBER VALIDATION
    defaultNumber = Console.ReadLine();
    isNum = Int32.TryParse(defaultNumber, out userNumber);

if(isNum == false){
    Console.Write("THAT'S NOT A NUMBER! TRY AGAIN. ");
}

//NUMBER HAS BEEN VALIDATED OR REJECTED BY THIS POINT
}
    if(userNumber % 2 == 0){
        Console.Write("THAT IS AN EVEN NUMBER! ");
    }
    else{
        Console.Write("THAT IS AN ODD NUMBER! ");
    }

//GAME IS FINISHED,    PRESS   Y   TO PLAY AGAIN
    Console.Write("ENTER \"Y\" TO PLAY AGAIN! ");
}while(Console.ReadLine().ToUpper() == "Y");
    Console.WriteLine("THANKS FOR PLAYING! ");