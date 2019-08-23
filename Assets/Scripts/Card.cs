using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite cardArt;
    public Sprite charClass;


    public int damage;
    public int cost;
    public CardType cardType;

    public void Update()
    {
        
    }

}


public enum CardType
{
    ATTACK = 0,
    SKILL = 1,
    POWER = 2
}