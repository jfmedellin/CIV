Console.WriteLine("¿Que pizza desea? (vegetariana/no vegetariana)");
string input = Console.ReadLine();
switch(input.ToLower())
{
    case "vegetariana":
    Console.WriteLine("eliga un ingrediente (pimiento / champiñones)");
    string Ingrediente = Console.ReadLine();
    Ingrediente.ToLower();
       if (Ingrediente.ToLower() == "pimiento")
       {
             Console.WriteLine($"Tu pizza es vegetariana y lleva tomate,mozarella y {Ingrediente}");
       }
       else if (Ingrediente == "champiñones")
       {
            Console.WriteLine($"Tu pizza es vegetariana y lleva tomate,mozarella y {Ingrediente}");
       }else{
        Console.WriteLine("elija un ingrediente correcto!");
       }
        
  
    break;
    case "no vegetariana":
    Console.WriteLine("eliga un ingrediente (pepperoni / salami / pollo)");
    string Ingrediente1 = Console.ReadLine();
    Ingrediente1.ToLower();
        if (Ingrediente1 == "pepperoni")
       {
             Console.WriteLine($"Tu pizza es vegetariana y lleva tomate,mozarella y {Ingrediente1}");
       }
       else if (Ingrediente1 == "salami")
       {
            Console.WriteLine($"Tu pizza es vegetariana y lleva tomate,mozarella y {Ingrediente1}");
       }else if(Ingrediente1 == "pollo")
       {
        Console.WriteLine($"Tu pizza es vegetariana y lleva tomate,mozarella y {Ingrediente1}");
       }
       else
       {
        Console.WriteLine("elija un ingrediente correcto!");
       }
 
       
    break;
    default:
    Console.WriteLine("ingresa una pizza correcta!");
    break;
}