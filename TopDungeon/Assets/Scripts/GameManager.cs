using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public List<Sprite> playerSprites;
	public List<Sprite> weaponSprites;
	public List<int> weaponPrices;
	public List<int> xpTable;

	public Player player;
	public FloatingTextManager floatingTextManager;

	public int gold;
	public int experience;

	private void Awake(){
		if (GameManager.instance != null){
			Destroy(gameObject);
			return;
		}
		instance = this;
		SceneManager.sceneLoaded += LoadState;
		DontDestroyOnLoad(gameObject);
	}

	// Floating text
	public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration){
		floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
	}

	// SAVE STATE VARS
	/*
		INT preferedSkin
		INT gold
		INT experience
		INT weaponLevel
	*/
	public void SaveState(){
		string saving = "";

		saving += "0" + "|";
		saving += gold.ToString() + "|";
		saving += experience.ToString() + "|";
		saving += "1";

		PlayerPrefs.SetString("SaveState", saving);
	}

	public void LoadState(Scene s, LoadSceneMode mode){

		if (!PlayerPrefs.HasKey("SaveState")){
			return;
		}

		string[] data = PlayerPrefs.GetString("SaveState").Split('|');

		// preferedSkin
		gold = int.Parse(data[1]);
		experience = int.Parse(data[2]);
		// weaponLevel
	}
	
}
