using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolitaireMy : MonoBehaviour
{



    public Sprite[] cardFaces;
    public GameObject CardPrefab;


    public static string[] suits = new string[] {"C" ,"D" ,"H" ,"S" };
    public static string[] values = new string[] {"A","2","3","4","5","6","7","8","9","10","J","Q","K"};


    public List<string> deck;

    // Start is called before the first frame update
    void Start()
    {
        PlayCards();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//main function to do everything
    public void PlayCards(){
        deck = GenerateDeck();
        Shuffle(deck);
        //test the cards in the deck
    
        foreach(string card in deck){
            print(card);
        }

        SolitaireDeal();

    
    }

// This is to make the cards
    public static List<string> GenerateDeck(){

        List<string> newDeck = new List<string>();

        foreach (string s in suits){
            foreach(string v in values){
                newDeck.Add(s+v);
            }   
        }
    return newDeck;
    }



// This is to shuffle the cards

    void Shuffle<T>(List<T> list){
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1){
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }




    void SolitaireDeal(){
        float yOffset = 0;
        float zOffset = 0.03f;
        foreach(string card in deck){
            GameObject newCard = Instantiate(CardPrefab, new Vector3(transform.position.x, transform.position.y + yOffset,  transform.position.z + zOffset), Quaternion.identity);
            newCard.name = card;


            yOffset += 0.1f;
            zOffset += 0.03f;
        }


    }


}
