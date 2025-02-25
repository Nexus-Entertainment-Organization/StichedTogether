using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject selectedCard;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectCard(GameObject card)
    {
        selectedCard = card;
    }
}
