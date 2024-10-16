using System;
class Program
{
    static void Main()
    {
        int MAT;
        float PRO, CAL1, CAL2, CAL3, CAL4, CAL5;
        // Mensaje de bienvenida
        cout("¡Hola! Este programa calcula el promedio de calificaciones");
        // Se pide la MATRICULA DEL ALUMNO
        cout("Por favor ingrese la matrícula del alumno:");
        MAT = cin<int>();
        // Se pide la primera calificación
        cout("Por favor ingrese la primera calificación:");
        CAL1 = cin<float>();
        // Se pide la segunda calificación
        cout("Por favor ingrese la segunda calificación:");
        CAL2 = cin<float>();
        // Se pide la tercera calificación
        cout("Por favor ingrese la tercera calificación:");
        CAL3 = cin<float>();
        // Se pide la cuarta calificación
        cout("Por favor ingrese la cuarta calificación:");
        CAL4 = cin<float>();
        // Se pide la quinta calificación
        cout("Por favor ingrese la quinta calificación:");
        CAL5 = cin<float>();
        // Se calcula el promedio
        PRO = (CAL1 + CAL2 + CAL3 + CAL4 + CAL5) / 5.0f;
        // Se muestra el resultado
        cout($"\nEl promedio del alumno con matrícula {MAT} es {PRO:F2}");
    }

    static void cout(string message)
    {
        Console.WriteLine(message);
    }

    static T cin<T>()
    {
        return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
    }
}