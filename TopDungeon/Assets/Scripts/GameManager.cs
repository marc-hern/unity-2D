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

	public void SaveState(){
		Debug.Log("SaveState");
	}

	public void LoadState(Scene s, LoadSceneMode mode){
		Debug.Log("LoadState");
	}
	
}
