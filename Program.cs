using System;

namespace FoodRush
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor p = new Processor();

            Location l1 = new Location(new string[] { "QV" });                  //Adding locations
            Location l2 = new Location(new string[] { "Chadstone" });
            Location l3 = new Location(new string[] { "Glenferrie" });
            Location l4 = new Location(new string[] { "Flinders" });
            

            p.AddLocation(l1);
            p.AddLocation(l2);
            p.AddLocation(l3);
            p.AddLocation(l4);

            Restaurant r1 = new Restaurant(new string[] {"Hokkaido"});          //QV restaurants
            Restaurant r2 = new Restaurant(new string[] { "Grilld" });
            Restaurant r3 = new Restaurant(new string[] { "Aqua" });
            Restaurant r4 = new Restaurant(new string[] { "Hanaichi" });
            l1.AddRestaurant(r1);
            l1.AddRestaurant(r2);
            l1.AddRestaurant(r3);
            l1.AddRestaurant(r4);

            Restaurant r5 = new Restaurant(new string[] { "KFC" });             //Chadstone restaurants
            Restaurant r6 = new Restaurant(new string[] { "Breadtop" });
            Restaurant r7 = new Restaurant(new string[] { "Harajuku" });
            Restaurant r8 = new Restaurant(new string[] { "Starbucks" });
            l2.AddRestaurant(r5);
            l2.AddRestaurant(r6);
            l2.AddRestaurant(r7);
            l2.AddRestaurant(r8);

            Restaurant r9 = new Restaurant(new string[] { "GYG" });            //Glenferrie restaurants
            Restaurant r10 = new Restaurant(new string[] { "Dominos" });
            Restaurant r11 = new Restaurant(new string[] { "Kebabji" });
            Restaurant r12 = new Restaurant(new string[] { "Boost" });
            l3.AddRestaurant(r10);
            l3.AddRestaurant(r11);
            l3.AddRestaurant(r12);
            l3.AddRestaurant(r9);


            Restaurant r13 = new Restaurant(new string[] { "Nene" });
            Restaurant r14 = new Restaurant(new string[] { "Gyoza" });
            Restaurant r15 = new Restaurant(new string[] { "Gongcha" });
            l4.AddRestaurant(r13);
            l4.AddRestaurant(r14);
            l4.AddRestaurant(r15);

            AddOn a1 = new AddOn(new string[] { "Extra Sugar" }, "Food");       //AddOns for reuse
            AddOn a2 = new AddOn(new string[] { "No Sugar" }, "Drink");
            AddOn a3 = new AddOn(new string[] { "No Pickles" }, "Food");
            AddOn a4 = new AddOn(new string[] { "Candyfloss" }, "Food");
            AddOn a5 = new AddOn(new string[] { "Sprinkles" }, "Food");
            AddOn a6 = new AddOn(new string[] { "Tartar sauce" }, "Food");
            AddOn a7 = new AddOn(new string[] { "Extra Ice" }, "Drink");
            AddOn a8 = new AddOn(new string[] { "Salsa" }, "Food");
            AddOn a9 = new AddOn(new string[] { "Ketchup" }, "Food");


            Food f1 = new Food(new string[] {"Blueberry Tart"}, 4.5);           //Hokkaido menu
            Food f2 = new Food(new string[] {"Strawberry Tart" }, 7.0);
            Food f3 = new Food(new string[] { "Passionfruit Tart" }, 4.5);
            Food f4 = new Food(new string[] { "Mango Tart" }, 4.5);

            
            r1.AddItem(f1);
            r1.AddItem(f2);
            r1.AddItem(f3);
            r1.AddAddOn(a1);

            Food f5 = new Food(new string[] {"Cheeseburger"}, 8.2);             //Grilld menu
            Food f6 = new Food(new string[] {"Beef burger"}, 12.0);
            Food f7 = new Food(new string[] {"Fries"}, 4.8);
            Drink f8 = new Drink(new string[] { "Sprite" }, 3.0);


            r2.AddItem(f5);
            r2.AddItem(f6);
            r2.AddItem(f7);
            r2.AddItem(f8);
            r2.AddAddOn(a2);
            r2.AddAddOn(a3);


            Food f9 = new Food(new string[] {"Tarro"}, 4.5);              //Aqua menu
            Food f10 = new Food(new string[] {"Strawberry"}, 4.5);
            Food f11 = new Food(new string[] {"Seasalt"}, 5.5);

            r3.AddItem(f9);
            r3.AddItem(f10);
            r3.AddItem(f11);
            r3.AddAddOn(a4);
            r3.AddAddOn(a5);


            Food f12 = new Food(new string[] { "Teriyaki Chicken" }, 15.0);     //Hanaichi menu
            Food f13 = new Food(new string[] { "Karaage" }, 8.0);
            Food f14 = new Food(new string[] { "Wagyu Beef" }, 22.0);

            r4.AddItem(f12);
            r4.AddItem(f13);
            r4.AddItem(f14);
            r4.AddAddOn(a6);

            Drink f15 = new Drink(new string[] { "Caramel Frappucino" }, 7.0);     //Starbuck menu
            Drink f16 = new Drink(new string[] { "Matcha Latte" }, 8.0);
            Drink f17 = new Drink(new string[] { "Cappucino" }, 5.0);

            r8.AddItem(f15);
            r8.AddItem(f16);
            r8.AddItem(f17);
            r8.AddAddOn(a2);
            r8.AddAddOn(a7);

            Food f18 = new Food(new string[] {"Slider"}, 2.95);            //KFC menu
            Food f19 = new Food(new string[] {"Zinger Burger"}, 6.95);
            Food f20 = new Food(new string[] {"Softie"}, 1.00);
            Drink f21 = new Drink(new string[] { "Sprite" }, 3.0);
            Drink f22 = new Drink(new string[] { "Coke" }, 3.0);

            r5.AddItem(f18);
            r5.AddItem(f19);
            r5.AddItem(f20);
            r5.AddItem(f21);
            r5.AddItem(f22);
            r5.AddAddOn(a2);
            r5.AddAddOn(a3);
            r5.AddAddOn(a6);


            Food f23 = new Food(new string[] {"Chicken bun"}, 3.95);        //Breadtop menu
            Food f24 = new Food(new string[] {"Mango Sago"}, 6.85);
            Food f25 = new Food(new string[] {"Sponge Cake"}, 9.75);
            r6.AddItem(f23);
            r6.AddItem(f24);
            r6.AddItem(f25);
            r6.AddAddOn(a1);


            Food f26 = new Food(new string[] {"Strawberry Crepe"}, 8.8);    //Harajuke menu
            Food f27 = new Food(new string[] {"Pudding Crepe"}, 10.2);
            Food f28 = new Food(new string[] { "Chicken Crepe" }, 12.5);
            r7.AddItem(f26);
            r7.AddItem(f27);
            r7.AddItem(f28);
            r7.AddAddOn(a1);



            Food f29 = new Food(new string[] { "Tacos" }, 9.3);             //GYG menu
            Food f30 = new Food(new string[] { "Nachos" }, 12.0);
            Food f31 = new Food(new string[] { "Burrito" }, 10.5);
            Drink f32 = new Drink(new string[] { "Soda" }, 4.0);
            r9.AddItem(f29);
            r9.AddItem(f30);
            r9.AddItem(f31);
            r9.AddItem(f32);
            r9.AddAddOn(a8);


            Food f33 = new Food(new string[] { "BBQ Pizza" }, 12.5);        //Dominos menu
            Food f34 = new Food(new string[] { "Vegan Pizza" }, 15.0);
            Food f35 = new Food(new string[] { "Garlic Bread" }, 4.5);
            r10.AddItem(f33);
            r10.AddItem(f34);
            r10.AddItem(f35);
            r10.AddAddOn(a6);



            Food f36 = new Food(new string[] { "HSP" }, 13.0);              //Kebabji menu
            Food f37 = new Food(new string[] { "Beef Kebab" }, 10.0);
            Food f38 = new Food(new string[] { "Falafel" }, 4.0);
            r11.AddItem(f36);
            r11.AddItem(f37);
            r11.AddItem(f38);
            r11.AddAddOn(a8);

            Drink f39 = new Drink( new string[] { "Mango Magic" }, 6.80);       //Boost menu
            Drink f40 = new Drink ( new string[] { "Blue Honolulu" }, 7.00);
            Drink f41 = new Drink(new string[] { "Lychee Crush" }, 8.30);
            r12.AddItem(f39);
            r12.AddItem(f40);
            r12.AddItem(f41);
            r12.AddAddOn(a2);
            r12.AddAddOn(a7);


            Food f42 = new Food ( new string[] { "Wings" }, 9.20);              //Nene menu
            Food f43 = new Food(new string[] { "Drumettes" }, 6.80);
            Food f44 = new Food(new string[] { "Chicken" }, 12.40);
            Food f45 = new Food(new string[] { "Squid Rings" }, 8.70);

            r13.AddItem(f42);
            r13.AddItem(f43);
            r13.AddItem(f44);
            r13.AddItem(f45);
            r13.AddAddOn(a6);
            r13.AddAddOn(a9);


            Food f46 = new Food(new string[] { "Tuna Roll" }, 4.20);            //Gyoza menu
            Food f47 = new Food(new string[] { "Wontons" }, 9.60);
            Food f48 = new Food(new string[] { "Dumplings" }, 12.20);
            Drink f49 = new Drink(new string[] { "Soju" }, 6.70);
            r14.AddItem(f46);
            r14.AddItem(f47);
            r14.AddItem(f48);
            r14.AddItem(f49);
            r14.AddAddOn(a2);
            r14.AddAddOn(a6);


            Drink f50 = new Drink(new string[] { "Mango Burst" }, 6.70);        //Gongcha menu
            Drink f51 = new Drink(new string[] { "Passionfruit Cloud" }, 7.0);
            Drink f52 = new Drink(new string[] { "Jasmine Tea" }, 5.80);

            r15.AddItem(f50);
            r15.AddItem(f51);
            r15.AddItem(f52);
            r15.AddAddOn(a7);
            r15.AddAddOn(a2);



            Console.WriteLine("Welcome to FoodRush!");

            p.Execute();
        }
    }
}
