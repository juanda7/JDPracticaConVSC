using System;
using System.Globalization;

public class ClaseBase
{
   public int Edad{get;set;}

   public int CalcularElDobleDeEdad(int restar)
   {
       int sumar;
       return (Edad-restar)*2;
   }
}
