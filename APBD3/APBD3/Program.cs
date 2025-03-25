using APBD3;

//Container Ships:
ContainerShip containerShip1 = new ContainerShip(25, 10, 10.5);
ContainerShip containerShip2 = new ContainerShip(27.5, 11, 11.55); //+10%

//----------------------------------------------------------------------------------------------------------------------
//Liquid Containers:
LiquidContainer liquidContainer1 = new LiquidContainer(1000, 100, 90, 10000);
LiquidContainer liquidContainer2 = new LiquidContainer(1000, 100, 90, 10000);

Cargo cargo1 = new Cargo("Fuel",Cargo.Type.Liquid,666,true);
Cargo cargo2 = new Cargo("Milk",Cargo.Type.Liquid,538,false);

liquidContainer1.Load(cargo1);
liquidContainer2.Load(cargo2);

containerShip1.Load(liquidContainer1);
containerShip2.Load(liquidContainer2);

//----------------------------------------------------------------------------------------------------------------------
//Gas Containers:
GasContainer gasContainer1 = new GasContainer(1000, 100, 90 ,10000,101.3);
GasContainer gasContainer2 = new GasContainer(1000, 100, 90, 10000,101.3);

Cargo cargo3 = new Cargo("Gas", Cargo.Type.Gas,999, true);
Cargo cargo4 = new Cargo("NonToxicGas", Cargo.Type.Gas,543, false);

gasContainer1.Load(cargo3);
gasContainer2.Load(cargo4);

containerShip1.Load(gasContainer1);
containerShip2.Load(gasContainer2);

//----------------------------------------------------------------------------------------------------------------------
//Cooling Containers:
CoolingContainer coolingContainer1 = new CoolingContainer(1000, 100, 90, 10000,15);
CoolingContainer coolingContainer2 = new CoolingContainer(1000, 100, 90, 10000, 15);

Cargo cargo5 = new Cargo("Bananas",Cargo.Type.Cool,333,false,13.3);
Cargo cargo6 = new Cargo("ExpiredMeat",Cargo.Type.Cool,250,true,-15);

coolingContainer1.Load(cargo5);
coolingContainer2.Load(cargo6);

containerShip1.Load(coolingContainer1);
containerShip2.Load(coolingContainer2);

//----------------------------------------------------------------------------------------------------------------------

Console.WriteLine(containerShip1);
Console.WriteLine(containerShip2);