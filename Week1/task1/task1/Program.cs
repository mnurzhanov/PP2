﻿using System;

namespace project1
{
	class MainClass 
	{ 
		public static void Main (string[] args) 		//Функция main
		{
			int n;
			string[] s = new string[256];			//Строка для считывания
			int[] a = new int[100000];			//Массив для чисел будущих
			n = Convert.ToInt32 (Console.ReadLine ());		//Считал количество чисел
			s = Console.ReadLine().Split();				//Не знаю зачем, но сплитить надо

			for (int i = 0; i < n; i++) {
				a [i] = int.Parse (s [i]);				//Парс Целых чисел и закидывание в массив
			}
			for (int i = 0; i < n; i++) {
				if (Simple(a[i]) == true) 				//Чек на простоту числа в функции
					Console.Write (a[i]+" ");			//Вывод соответственно
			}
		}
		public static bool Simple (int n){			//Сама функция проверки на простоту
			if (n == 1)									//Единица не простое число 
				return false;
			for (int i = 2; i <= Math.Sqrt (n); i++) {	
				if (n % i == 0)							//проверка на простоту путем деления
					return false;
			}
			return true;
		}

	}
}