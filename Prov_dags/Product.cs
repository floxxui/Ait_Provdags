using System;

namespace Prov_dags
{
    public class Product
    {
        public Random generator = new Random();
        public int price;
        public string name;
        public int rarity;
        public string category;
        public int actualValue;
        public bool cursed;

        public Product(){
            actualValue = generator.Next(100);
            rarity = generator.Next(10);
            //Genererar random värden till actualValue och rarity
        }
        public void PrintInfo(){
            System.Console.WriteLine("Item info:\nName:" + name + "\nCategory:" + category + "\nRarity:" + rarity + "\nPrice:" + price);
            //Skriver ut värden på Name, Category, Rarity och Price
        }
        public int Evaluate(){
            int correctPrice = actualValue * rarity;
            //multiplicerar ihop actualValue och rarity för att få ett pris på föremålet

            int i = generator.Next(50, 150);
            price = correctPrice * i / 100;
            //Den slumpar ut ett värde mellan 50 och 150 för att avgöra hur mycket priset är på föremålet. Detta multipliceras ihop med det rätta priset och divideras sedan på 100
            //Dividera på hundra efteråt gjordes eftersom en int inte kan inehålla decimaltal, vilket skulle behövas här.

            return price;
            //Priset returneras
        }
        public string GetCategory(){
            System.Console.WriteLine("Which category is " + name + "?");
            string category = Console.ReadLine();
            if (category != ""){
                System.Console.WriteLine(name + " is in the category " + category);
            }
            //If-statement kommer inte spelas ifall category är tom
            return category;
            //Värdet returnas
            //Iden är att man ska kunna spela metoden i en loop som inte bryts så länge category är tom
        }
        public string GetName(){
            System.Console.WriteLine("What kind of item is it?");
            name = Console.ReadLine();
            if (name != ""){
                System.Console.WriteLine("The item is " + name);
            }
            //If-statement gör att texten endast syns ifall playerAnswer har ett innehåll.
            return name;
            //Metoden låter spelaren få ge ett namn på varan. Namnet returnas, och kan därmed användas mer i koden
        }
        //Jag valde att man ska få välja namn och kategori istället för att det inte finns tillräckligt med tid
        public bool IsCursed(){
            int i = generator.Next(2);
            int j = generator.Next(100);
            //Slumpar ut två tal. Första är ifall det är större chans att föremålet är cursed eller inte. Andra är ifall den är cursed eller inte
            if(i == 0){
                if(j <= 80){
                    cursed = true;
                }
                if(j >= 80){
                    cursed = false;
                }
            }
            //I denna if statement är det större chans att föremålet är cursed. Pga detta är det 80% chans att föremålet är cursed
            if(i == 1){
                if(j <= 80){
                    cursed = false;
                }
                if(j >= 80){
                    cursed = true;
                }
            }
            //I denna if-statement är det tvärt om

            return cursed;
            //värdet returnas sedan
        }
    }
}
