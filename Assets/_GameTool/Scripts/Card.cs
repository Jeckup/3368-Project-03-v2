using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    public bool hasBeenPlayed;

    public int handIndex;

    private DeckManager dManager;

    private void Start()
    {
        dManager = FindObjectOfType<DeckManager>();
    }

    private void OnMouseDown()
    {
        if(hasBeenPlayed == false)
        {
            transform.position += Vector3.up * 4;
            hasBeenPlayed = true;
            dManager.availableCardSlots[handIndex] = true;
            Invoke("MoveToDiscardPile", 2f);
        }
    }

    void MoveToDiscardPile()
    {
        dManager.discardPile.Add(this);
        gameObject.SetActive(false);
    }
}
