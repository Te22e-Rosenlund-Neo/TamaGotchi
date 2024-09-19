class Pet{

    private int hunger = 0;
    private int boredom = 0;
    private List<string> knownWords;
    private bool isAlive =  true;
    public string name = "Default";
    
    public Pet(string name) {

        this.name = name;

    }  

    public void Feed(){
        hunger -= 2;
        if(hunger < 0){
            hunger = 0;
        }
    }
    public void Hi(){
        if(knownWords.Count == 0){
            Console.WriteLine("Your friend doesnt know any words!");
        }else{
            Console.Write($"{name} says:    ");
            Console.WriteLine(knownWords[Random.Shared.Next(0, knownWords.Count)]);
            ReduceBoreDom();
        }
    }
    public void Teach(string word){
        knownWords.Add(word);

    }
    public void Tick(){

        hunger += Random.Shared.Next(1,2);
        boredom += Random.Shared.Next(0,2);

        if(hunger == 10 || boredom == 10){
            isAlive = false;
            GetAlive();
        }

        Console.Clear();
        Console.WriteLine("Time has passed");
        Thread.Sleep(1500);
        Console.Clear();
    }
    public void PrintStats(){
        Console.WriteLine($"Tamagotch: {name}"); 
        Console.WriteLine($"Boredom: {boredom}"); 
        Console.WriteLine($"Hunger: {hunger}"); 
    }
    public void GetAlive(){
        Console.WriteLine($"Your {name} is {isAlive}");
    }
    private void ReduceBoreDom(){
         boredom -= 1;
            if(boredom < 0){
                boredom = 0;
            }
    }

}





