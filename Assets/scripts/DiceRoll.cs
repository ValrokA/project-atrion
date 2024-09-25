using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoll : MonoBehaviour
{
    int diceRoll;
    [SerializeField] Image diceImage;
    [SerializeField] Skins diceSkins;

    public void Roll()
    {
        diceRoll = Random.Range(0, 6);
        Animation(diceSkins.GetSkin(diceRoll));
    }

    private void Animation(Sprite skin)
    {
        diceImage.sprite = skin;
    }

}
