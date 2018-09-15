using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMenu : MonoBehaviour {

	// Text fields
	public Text levelText, hitPointText, goldText, upgradeCostText, xpText;

	// Logic
	private int currentCharacterSelection = 0;
	public Image characterSelectionSprite, weaponSprite;
	public RectTransform xpBar;

	// Character selection
	public void OnArrowClick(bool right){
		if (right){
			currentCharacterSelection++;

			// If we went out of bounds
			if (currentCharacterSelection == GameManager.instance.playerSprites.Count){
				currentCharacterSelection = 0;
			}

			OnSelectionChanged();
		}
		else {
			currentCharacterSelection--;

			if (currentCharacterSelection < 0){
				currentCharacterSelection = GameManager.instance.playerSprites.Count - 1;
			}

			OnSelectionChanged();
		}
	}

	private void OnSelectionChanged(){
		characterSelectionSprite.sprite = GameManager.instance.playerSprites[currentCharacterSelection];
	}

	// Weapon Upgrade
	public void OnUpgradeClick(){
	}

	// Update character information
	public void UpdateMenu(){
		// Weapon
		weaponSprite.sprite = GameManager.instance.weaponSprites[0];
		upgradeCostText.text = "NOT IMPLEMENTED";

		// Meta
		hitPointText.text = GameManager.instance.player.hitpoint.ToString();
		levelText.text = "NOT IMPLEMENTED";
		goldText.text = GameManager.instance.gold.ToString();

		// XP Bar
		xpText.text = "NOT IMPLEMENTED";
		xpBar.localScale = new Vector3(0.5f, 0, 0);
	}
}
