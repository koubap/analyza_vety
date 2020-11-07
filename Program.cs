﻿/*
 * Created by SharpDevelop.
 * User: petrkou
 * Date: 06.11.2020
 * Time: 9:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace statistikaVety
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			Console.WriteLine(">>>STATISTIKA VETY<<<");	
			
			// větu, kterou chci analyzovat
			string s = "Není nic jednoduššího než vyřešený problém.";
			Console.WriteLine(s);
			s = s.ToLower();
			
			// 
			int pocetSamohlasek = 0;
			int pocetSouhlasek = 0;
			
			string samohlasky = "aeiouyáéěíóúůý";
			string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
			
			
			// hlavní cyklus
			foreach (char c in s)
			{
				if (samohlasky.Contains(c))
					pocetSamohlasek++;
				else
				if (souhlasky.Contains(c)) 
					pocetSouhlasek++;
			
			}
			
			Console.WriteLine("samohlasek: {0}", pocetSamohlasek);
			Console.WriteLine("souhlasek: {0}", pocetSouhlasek);
			Console.WriteLine("ostatnich znaku: {0}", s.Length - (pocetSamohlasek + pocetSouhlasek));
			Console.WriteLine("znaků celkem: {0}", s.Length);
			
				
			Console.Write("\nKlávesou pokračuj . . . ");
			Console.ReadKey(true);
		}
	}
}