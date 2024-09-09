
double baseCost=0.0;

double totalSandwhichCost=0.0;

double totalToppingCost=0.0;

int numberOfSandwhiches=0;
int numberOfToppings=0;
double tip=0.0;


double COST_OF_SANDWHICH=4.75;

double COST_OF_TOPPING=0.50;
double DISCOUNT_AMOUNT=.10;



Console.WriteLine("Please Enter Number of Sandwhiches: ");

numberOfSandwhiches=int.Parse(Console.ReadLine());

Console.WriteLine("Please enter number of Toppings: ");

numberOfToppings=int.Parse(Console.ReadLine());

Console.WriteLine("Please enter tip amount: ");

tip=double.Parse(Console.ReadLine());

totalSandwhichCost=COST_OF_SANDWHICH*numberOfSandwhiches;

totalToppingCost=COST_OF_TOPPING*numberOfToppings;

baseCost=totalSandwhichCost+totalToppingCost;


double orderCost=tip+baseCost;

Console.WriteLine("The total cost of your order is: "+orderCost);
