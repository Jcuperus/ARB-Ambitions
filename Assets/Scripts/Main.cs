using UnityEngine;
using System.Collections;

public static class Main {

	public static int score;
	public static int lives;
	public static bool playing;

	public static void InitGame () {
		
		score = 0;
		lives = 3;
		playing = true;
	}

}
