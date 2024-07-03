// Console.Write("Ingresa tu edad por favor =>");
// byte age = Convert.ToByte(Console.ReadLine());

// conditional simple
// if (age >= 18) 
// {
//     Console.WriteLine($"Eres mayor de edad");
// }

// normal conditional
// if (age >= 18) 
// {
//     Console.WriteLine($"Eres mayor de edad");
// }
// else
// {
//     Console.WriteLine($"Eres menor de edad"); 
// }

// conditional compounded
// if (age >= 18) 
// {
//     Console.WriteLine($"Eres mayor de edad");
// }
// else if (age >= 12 && age <18)
// {
//     Console.WriteLine($"Eres un adolescente");    
// }
// else
// {
//     Console.WriteLine($"Eres menor de edad"); 
// }

//ternari operator
// Console.WriteLine(age >= 18 ? "Eres mayor de edad" : "Eres menor de edad");

//Switch cases
// Console.Write("Ingresa tu numero del 1 al 7 por favor =>");

// byte number = Convert.ToByte(Console.ReadLine());

// switch (number)
// {
//     case 1:
//         Console.WriteLine("Elegiste el Lunes");
//         break;
//     case 2:
//         Console.WriteLine("Elegiste el Martes");
//         break;
//     case 3:
//         Console.WriteLine("Elegiste el Miercoles");
//         break;
//     case 4:
//         Console.WriteLine("Elegiste el Jueves");
//         break;
//     case 5:
//         Console.WriteLine("Elegiste el Viernes");
//         break;
//     case 6:
//         Console.WriteLine("Elegiste el Sabado");
//         break;
//     case 7:
//         Console.WriteLine("Elegiste el Domingo");
//         break;
//     default:
//         Console.WriteLine("Numero invalido");
//         break;
// }

// Workshop

//1. Escribe un programa que pida al usuario un número y muestre si es par o impar usando una condición if.
// Console.Write("Escribe un numero =>");
// int userNumber = Convert.ToInt32(Console.ReadLine());
// if ((userNumber % 2) == 0)
// {
//     Console.WriteLine("El numero que ingresaste es par");
// }
// else
// {
//     Console.WriteLine("El numero que ingresaste es inpar");
// }
// Console.WriteLine((userNumber % 2) == 0 ? "El numero es par" : "El numero es impar");

//2. Escribe un programa que pida al usuario que ingrese su nombre. Luego, verifica si el nombre ingresado no es nulo ni está vacío. Si el nombre es válido, muestra un mensaje de bienvenida; de lo contrario, muestra un mensaje de error.
// Console.Write("Escribe tu nombre por favor => ");
// string? userName = Console.ReadLine();
// if (userName != null && userName?.Length != 0)
// {
//     Console.WriteLine($"Bienvenido {userName} !");
// }
// else
// {
//     Console.WriteLine("Ingresaste un valor nulo o vacio");
// }
// Console.WriteLine (userName != null && userName?.Length != 0 ? $"Bienvenido {userName} " : "Ingresaste un valor nulo o vacio" );

// 3. Escribe un programa que pida al usuario su edad y muestre si es mayor o menor de edad usando if-else.
// Console.Write("Escribe tu edad por favor => ");
// int age = Convert.ToByte(Console.ReadLine());

// if (age >= 18) 
// {
//     Console.WriteLine($"Eres mayor de edad");
// }
// else
// {
//     Console.WriteLine($"Eres menor de edad"); 
// }

// Console.WriteLine(age >= 18 ? "Eres mayor de edad" : "Eres menor de edad" );

//4. Escribe un programa que pida al usuario un día de la semana (como número del 1 al 7) y muestre el nombre del día correspondiente usando switch.
// Console.Write("Escribe un numero del 1 al 7 => ");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// switch (userNumber)
// {
//     case 1:
//         Console.WriteLine("Elegiste el dia Lunes");
//         break;
//     case 2:
//         Console.WriteLine("Elegiste el dia Martes");
//         break;
//     case 3:
//         Console.WriteLine("Elegiste el dia Miercoles");
//         break;
//     case 4:
//         Console.WriteLine("Elegiste el dia Jueves");
//         break;
//     case 5:
//         Console.WriteLine("Elegiste el dia Viernes");
//         break;
//     case 6:
//         Console.WriteLine("Elegiste el dia Sabado");
//         break;
//     case 7:
//         Console.WriteLine("Elegiste el dia Domingo");
//         break;
//     default:
//         Console.WriteLine("Escoge un numero valido");
//         break;
// }

//5. Escribe un programa que pida al usuario su nacionalidad. Si es colombiana, debe decirle que es nativo del país; si no lo es, debe decir que es extranjero (usando operador ternario).
// Console.Write("Ingresa tu pais de origen => ");
// string? userCountry = Console.ReadLine();

// Console.WriteLine(userCountry == "Colombia" ? "Eres Colombiano" : "Eres extranjero");

//6. Escribe un programa que pida al usuario tres números y muestre cuál es el mayor usando if-else.
// Console.Write("Ingresa el primer numero => ");
// int userNumber1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// Console.Write("Ingresa el segundo numero => ");
// int userNumber2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// Console.Write("Ingresa el tercer numero => ");
// int userNumber3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// if ((userNumber1 > userNumber2) && (userNumber2 > userNumber3))
// {
//     Console.WriteLine($"El numero mayor es {userNumber1}");
// }
// else if (userNumber2 > userNumber3 )
// {
//     Console.WriteLine($"El numero mayor es {userNumber2}");
// }
// else if (userNumber2 < userNumber3 )
// {
//     Console.WriteLine($"El numero mayor es {userNumber3}");
// }
// else
// {
//     Console.WriteLine($"Los numeros son iguales");
// }

// 7. Escribe un programa que pida al usuario que ingrese una contraseña. Verifica si la contraseña no es nula ni está vacía. Si la contraseña es válida, muestra un mensaje indicando que la contraseña es aceptada; de lo contrario, muestra un mensaje indicando que la contraseña no puede estar en blanco.
// Console.Write("Ingresa una contraseña => ");
// string? userPassword = Console.ReadLine();

// if (userPassword != null && userPassword?.Length != 0 )
// {
//     Console.WriteLine($"Tu contraseña es valida !");
// }
// else
// {
//     Console.WriteLine("La contraseña no puede estar en blanco");
// }

// Console.WriteLine (userPassword != null && userPassword?.Length != 0 ? $"Tu contraseña es valida !" : "La contraseña no puede estar en blanco" );

//8. Escribe un programa que pida al usuario un número del 1 al 12 y muestre el nombre del mes correspondiente usando switch.
// Console.WriteLine();
// Console.Write("Escribe un numero del 1 al 12 => ");
// int userNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// switch (userNumber)
// {
//     case 1:
//         Console.WriteLine("Elegiste ENERO");
//         break;
//     case 2:
//         Console.WriteLine("Elegiste FEBRERO");
//         break;
//     case 3:
//         Console.WriteLine("Elegiste MARZO");
//         break;
//     case 4:
//         Console.WriteLine("Elegiste ABRIL");
//         break;
//     case 5:
//         Console.WriteLine("Elegiste MAYO");
//         break;
//     case 6:
//         Console.WriteLine("Elegiste JUNIO");
//         break;
//     case 7:
//         Console.WriteLine("Elegiste JULIO");
//         break;
//     case 8:
//         Console.WriteLine("Elegiste AGOSTO");
//         break;
//     case 9:
//         Console.WriteLine("Elegiste SEPTIEMBRE");
//         break;
//     case 10:
//         Console.WriteLine("Elegiste OCTUBRE");
//         break;
//     case 11:
//         Console.WriteLine("Elegiste NOVIEMBRE");
//         break;
//     case 12:
//         Console.WriteLine("Elegiste DICIEMBRE");
//         break;
//     default:
//         Console.WriteLine("Escoge un numero valido");
//         break;
// }
// Console.WriteLine();

//9. Escribe un programa que pida al usuario una calificación numérica y muestre la letra correspondiente (A, B, C, D, F) usando if-else.
// Console.WriteLine();
// Console.Write("Escribe una calificacion del 1 al 5 => ");
// double userCalification = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine();

// if(userCalification <= 1)
// {
//     Console.WriteLine("Tu calificacion es F");
// }
// else if(userCalification <= 2)
// {
//     Console.WriteLine("Tu calificacion es D");
// }
// else if(userCalification <= 3)
// {
//     Console.WriteLine("Tu calificacion es C");
// }
// else if(userCalification <= 4)
// {
//     Console.WriteLine("Tu calificacion es B");
// }
// else if(userCalification <= 5)
// {
//     Console.WriteLine("Tu calificacion es A");
// }
// else
// {
//     Console.WriteLine("Ingresa una calificacion valida");
// }
// Console.WriteLine();

//10. Escribe un programa que pida al usuario un carácter y determine si es una vocal o una consonante usando switch.
// Console.WriteLine();
// Console.Write("Escribe un caracter para determinar si es vocal o consonante => ");
// char userCalification = Convert.ToChar(Console.ReadLine());
// Console.WriteLine();

// switch (char.ToLower(userCalification))
// {
//     case 'a':
//     case 'e':
//     case 'i':
//     case 'o':
//     case 'u':
//         Console.WriteLine("Es una vocal");
//         break;

//     default:
//     Console.WriteLine("Es una consonante");
//         break;
// }

// Console.WriteLine();

//11. Escribe un programa que pida al usuario dos números y muestre si son iguales o diferentes usando if-else.
// Console.WriteLine();

// Console.Write("Escribe el primer numero => ");
// byte userNumber1 = Convert.ToByte(Console.ReadLine());

// Console.Write("Escribe el segundo numero => ");
// byte userNumber2 = Convert.ToByte(Console.ReadLine());
// Console.WriteLine();

// if (userNumber1 == userNumber2)
// {
//     Console.WriteLine("Los numeros son iguales");
// }
// else
// {
//     Console.WriteLine("Los numeros son diferentes");
// }

// Console.WriteLine();

// Console.WriteLine(userNumber1 == userNumber2 ? "Los numeros son iguales" : "Los numeros son diferentes");

//12. Escribe un programa que solicite al usuario que ingrese su dirección. Verifica si la dirección no es nula, no está vacía y no consiste solo en espacios en blanco. Si la dirección es válida, muestra un mensaje de confirmación; de lo contrario, muestra un mensaje de error.

// Console.WriteLine();

// Console.Write("Escribe tu direccion => ");
// string? userAddress= Console.ReadLine();

// if (!string.IsNullOrWhiteSpace(userAddress))
// {
//     Console.WriteLine("La direccion es valida");
// }
// else
// {
//     Console.WriteLine("La direccion es nula, vacia o en solo espacios en blanco");
// }

// Console.WriteLine();