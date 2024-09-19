
//Improved tamagotchi where the user is too lazy to see be able to see the stats 
// game does not end bc why would u want your tamagotchi to die? Meanie >:|




Console.WriteLine("Welcome to tamagotchi");
Console.WriteLine("Please type the name of your tamagotchi");
Pet pet = new Pet(Console.ReadLine());
Console.WriteLine(pet.name);
Console.Clear();

void Prompts(){
Console.WriteLine("What do you want your pet to do?: ");
Console.WriteLine("1:   Say a word");
Console.WriteLine("2:   Eat");
Console.WriteLine("3:   Teach a word");
Console.WriteLine("4:   Show stats");
Console.WriteLine("5:   Check alive");
}
void checkinput(string numb){
    if(numb == "1"){
        pet.Hi();
    }
    if(numb=="2"){
        pet.Feed();
    }
    if(numb=="3"){
        Console.WriteLine("what word");
        string word = Console.ReadLine();
    }
    if(numb == "4"){
       pet.PrintStats(); 
    }
    if(numb == "5"){
        pet.GetAlive();
    }

}




while(true){
pet.Tick();
Thread.Sleep(1500);
Prompts();

string input = Console.ReadLine();





}