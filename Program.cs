//Comentario de una sola línea
/* Comentario para una o más líneas
    XDDDDDDDD   
*/
Console.WriteLine("Hello, World!");
Console.WriteLine("Soy Samuel");
Console.Write("Hola, ");
Console.WriteLine("Cómo estás");
Console.WriteLine();
Console.WriteLine("-----------");
int edad=23; 
float estatura=1.6f; //La f ayuda a que sea aplicado el número decimal dentro de float.
double peso=60.5;
bool esEstudiante=true;
string nombre="Sam";
double pesoIdeal=70;
int peso2=(int)pesoIdeal;
Console.WriteLine("Ingrese nombre del jugador: ");
string player=Console.ReadLine();
Console.WriteLine("El jugador es: " + player);
System.Console.WriteLine("Ingrese nivel del jugador: ");
int nivel=int.Parse(Console.ReadLine());
Console.WriteLine("El nivel del jugador es {0} y su nombre es {1}",nivel,player);

if (edad>=18)
{
    Console.WriteLine("Eres mayor de edad");
        Console.WriteLine(" por lo tanto puedes entrar al juego");
}else if (edad>=15 && edad<18) // && es y, se deben cumplir ambas condiciones || es o
{
    Console.WriteLine("Puedes entrar pero con restricciones");
}
else
{
    Console.WriteLine("No puedes entrar al juego");
}
//a++ , le agrega 1 a la variable a, a-- le resta 1 a la variable a
// i=i+i, i++ son equivalentes, le suman 1 a la variable i
int tabla=5;
Console.WriteLine("-------While--------");
for (int i=1; i<10; i++)
{
    Console.WriteLine(tabla+" x "+ i +" = "+(tabla*i));
}
Console.WriteLine("----------While---------");
tabla=7;
int cont=1;
while (cont <= 10)
{
    Console.WriteLine(tabla+" x "+ cont +" = "+(tabla*cont));
    cont++;
}
Console.WriteLine("-----------Do-While----------");
tabla=9;
cont=1;
do
{
    Console.WriteLine(tabla+" X "+ cont +" = "+(tabla*cont));
    cont++;
}while (cont <= 10);

Console.WriteLine("-----------switch----------");
int opcion=2;
switch (opcion)
{
    case 1:
        Console.WriteLine("Opcion 1");
        break;
    case 2: 
        Console.WriteLine("Opcion 2");
        break;
    case 3:
        Console.WriteLine("Opcion 3");
        break;
    default:
        Console.WriteLine("Opcion no valida");
        break;
}


Jugador j=new Jugador("Sam", 24);
Console.WriteLine(j);
j.Name="Jere";
j.Edad=32;
System.Console.WriteLine(j);