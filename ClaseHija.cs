using System;
using System.Globalization;

public class ClaseHija:ClaseBase
{
   public double Peso{get;set;}

   public double CalculaPeso(int peso)
   {
	 int factorPeso = 2;
       return Peso*factorPeso;
   }
}
