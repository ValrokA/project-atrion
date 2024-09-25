using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skins", menuName = "ScriptableObjects/Create Skin")]
public class Skins : ScriptableObject
{
    [SerializeField] Sprite[] skins;

    public Sprite GetSkin(int index)
    {
        return skins[index];
    }
}
