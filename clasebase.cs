using System;
using System.Globalization;

public class ClaseBase
{
   public int Edad{get;set;}

   public int CalcularElDobleDeEdad(int restar)
   {
       int sumar = 5;
       return (Edad-restar+sumar)*2;
   }
}
