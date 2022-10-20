//N. Harrison Wilkins
//10-19-2022
//GitHub Project Part 4 - ODD OR EVEN
//This console project will tell the user if they entered an odd or even number
//console will give user a message if they enter a value that is not viewed as a number
//Peer Review By: Kenneth Fujimura -- Everything works. There's input validation that does its job. The TryParse is there and works. The program is clean and well organized. I really liked the comments throughout the program so that it explains what each part of the program does, it really helps other people read the code and follow your train of thought. The only thing I would change is to make sure you fill out your README file. I know that at the very least, we need to have a short description of the program in here. I would probably add all the other info that we have in the top comments of our vs code just to be safe as well. Great job, Harrison! 


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