﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Cheat
{
    class Loader : MonoBehaviour
    {
		// call auth Globals.Auth to load. This is for obfuscation reasons and to establish authenticity.
		public static void Init()
		{


			if (Globals.LoggedIn)
			{
				Loader.hackObject.AddComponent<Cheat.Esp.Zombie>();
				Loader.hackObject.AddComponent<Cheat.Esp.Animal>();
				Loader.hackObject.AddComponent<Cheat.Esp.Player>();
				Loader.hackObject.AddComponent<Globals>();
				Loader.hackObject.AddComponent<Menu.Main>();
				Loader.hackObject.AddComponent<Misc>();
				Loader.hackObject.AddComponent<Aimbot>(); 	
				UnityEngine.Object.DontDestroyOnLoad(hackObject);
			}

		}
		public static GameObject hackObject = new GameObject(); // make bool in a public static class and check if its true constantly as extra auth shit
	}
}
