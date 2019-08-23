using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TextMeshProUGUI cardName;
    public TextMeshProUGUI descriptionText;

    public Image artworkImage;
    public RawImage cardClassImage;
    public RawImage background;
    public CardType cardType;

    public Text costText;

    // Start is called before the first frame update
    void Start()
    {
        cardName.text = card.name;
        descriptionText.text = card.description;

        artworkImage.sprite = card.cardArt;
        //cardClassImage.sprite = card.charClass;

        switch (cardType)
        {
            case CardType.ATTACK:
                background.color = Color.red;
                break;
            case CardType.SKILL:
                background.color = Color.green;
                break;
            case CardType.POWER:
                background.color = Color.blue;
                break;
            default:
                background.color = new Color(0.4156f, 0.4f, .4156f);
                break;
        }

        costText.text = card.cost.ToString();
    }
}
