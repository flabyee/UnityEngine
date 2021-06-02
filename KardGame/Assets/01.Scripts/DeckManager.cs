using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public GameObject cardPrefab;

    public Deck initialDeck;
    private Deck playerDeck;

    public List<CardHandler> cardsInHand;

    public Canvas canvas;

    public void Start()
    {
        // Initial Deck���� player Deck���� Clone
        playerDeck = initialDeck.Clone();
    }

    public void Draw()
    {
        // Draw ȣ�� �Ǹ� InstantiateCardObject ����
        InstantiateCardObject(playerDeck.Draw());
    }

    public void InstantiateCardObject(Card cardData)
    {
        var cardObject = Instantiate(cardPrefab, canvas.transform);
        // cardInHand�� �ְ�, CardHandler���� initialize ����
        CardHandler cardHandler = cardObject.GetComponent<CardHandler>();
        cardHandler.card = cardData;
        cardsInHand.Add(cardHandler);
        cardHandler.Init();
    }
}
