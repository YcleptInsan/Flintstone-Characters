using System; 

namespace FlintstoneCharacters 
{
    public class FlintstoneCharacters
    {
        public static void Main(string[] args)    
        {
         // FlintstoneCharacter character_construct = new FlintstoneCharacter();
         // character_construct.HusbandWife = "fred flintsone";
         // character_construct.ReturnInstance();
            
            Pets petsLoop = new Pets();
            
            petsLoop.ReturnInstance();
            petsLoop.returnNames();
            
            
        }
    }

    // FIXME: without taking out the word 'abstract'.
    // Go back to lesson 1 and define Encapsulation and Abstraction.
    public abstract class FlintstoneCharacter
    {
        private string _fred; 
        private string _wilma; 


        protected internal string HusbandWife
        {
            
        
            get
            {
                return string.Format($"The husband {0} and wifes name is {1}", this._fred, this._wilma);
            }
            set
            {
                 this._fred= "Fred Flintstone";
                 this._wilma= "Wilma Flintstone";
            }
        }

        

        public FlintstoneCharacter() {} 
        public FlintstoneCharacter(string husband, string wife)
        {
            this._fred = husband; 
            this._wilma = wife; 
        }

        public void ReturnInstance()
        {
             Console.WriteLine(this.HusbandWife);
        }

        public abstract void returnNames();
    }

    class Pets : FlintstoneCharacter
    {
        private string _barney, _betty, _dino;
        
        // Created string array 
        protected internal string[] Names = new string[] { "Barney", "Betty", "Dino" };

        
        public Pets() {}

        public Pets(string husband, string wife, string animal) : base(husband, wife) 
        { 
            _barney = husband;
            _betty = wife;
            _dino = animal;
        }

        public override void returnNames()
        {
            Console.WriteLine(string.Format("Hi bish {0} {1} {2}. Pleasure to meet you.", this.Names));
        }

        

    }
 

}
