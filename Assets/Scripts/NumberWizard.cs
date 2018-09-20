using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {

    // Serialized field for guess range and guess text
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    // Int for guess, should be between min and max
    int guess;
    

    // Use this for initialization
    void Start ()
    {
        StartGame();
    }

    // initiallizes the first guess of the game
    void StartGame()
    {
        NextGuess();
    }

    // when the guess is higher than the number 
    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    // when the guess is lower than the number
    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }


    // Function that picks a random number between min and max then prints to string.
    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
