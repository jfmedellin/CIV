Console.WriteLine("ingrese el valor de renta del primer semestre");
int valor1 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese el valor de renta del segundo semestre");
int valor2 = int.Parse(Console.ReadLine());
int Renta = (valor1 + valor2);
Console.WriteLine($"su renta total es : {Renta}");


if (Renta < 10000)
{

    Console.WriteLine("Tipo impositivo 5%");
    Console.WriteLine($"su impuesto es de : {Renta * 0.05}");
    

}else
{
    if(Renta >= 10000 && Renta <= 20000){
        Console.WriteLine("Tipo impositivo 15%");
        Console.WriteLine($"su impuesto es de : {Renta * 0.15}");
    }
}
    if(Renta > 20000 && Renta <= 35000){
        Console.WriteLine("Tipo impositivo 20%");
        Console.WriteLine($"su impuesto es de : {Renta * 0.2}");
    }
 else{
    if(Renta > 35000 && Renta <= 45000){
        Console.WriteLine("Tipo impositivo 35%");
        Console.WriteLine($"su impuesto es de : {Renta * 0.35}");
    }
 }
 if (Renta>45000){
    Console.WriteLine("Tipo impositivo 45%");
    Console.WriteLine($"su impuesto es de : {Renta * 0.45}");
 }   