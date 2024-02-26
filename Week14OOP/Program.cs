//class 

Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);          //myDog and neighborDog are objects
Dog neighborDog = new Dog("Woofer");

Console.WriteLine($"My dog's name is {myDog.Name}. {neighborDog.Name} isn't mine.");

myDog.Rename("Baddie");

while(myDog.HappyLevel != 5)
{
    myDog.Bark();
}

myDog.WagTail();

class Dog
{
    private string _name;       //field; private protects from edit unless specific method Rename (below) is used 
    private int _happyLevel;

    //constructor
    public Dog(string name)     //public means it's accessible outside of class; name - lets user name a dog
    {
        _name = name;
        _happyLevel = 0;
    }

    //getter - needed to return values protected by private
    public string Name      //only returns value _name as Name
    { 
    get { return _name; }
    }

    public int HappyLevel       //getter has to start with capital letter
    {
        get { return _happyLevel; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"Dog renamed to {newName}.");
    }

    public void Bark()
    {
        Console.WriteLine("~Wooooof!");
        _happyLevel++;
    }

    public void WagTail()
    {
        Console.WriteLine("~wiggles commence~");
    }
}