using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameworkFramework.Search
{
    /// <summary>
    /// This script takes user input through an InputField and searches for any matches in a randomised array
    /// </summary>
    public class SimpleSearch : MonoBehaviour
    {
        /// <summary>
        /// The array to be randomised
        /// </summary>
        public int[] randomArray;
        /// <summary>
        /// The InputField that the user types their value to be searched into
        /// </summary>
        public InputField userInput;
        /// <summary>
        /// The text that displays the result of the search
        /// </summary>
        public Text resultText;
        /// <summary>
        /// Start is used to randomise the array
        /// </summary>
        void Start()
        {
            randomArray = new int[20];
            // Adds 20 random numbers between 1 and 100 to the random array
            for (int i = 0; i < 20; i++)
            {
                randomArray[i] = Random.Range(1,100);
                Debug.Log(randomArray[i]);
            }
        }
        /// <summary>
        /// Checks every number in the array for a match
        /// </summary>
        public void Search()
        {
            // If the user has inputted text in the InputField
            if (userInput.text != null)
            {
                // Convert that text into an int
                int userNumber = int.Parse(userInput.text);
                // For every number in the random array
                for (int i = 0; i < randomArray.Length; i++)
                {
                    // If the number searched by the user is found in the array
                    if (userNumber == randomArray[i])
                    {
                        // Change the result text to indicate that a match was found
                        resultText.text = "Your number matches a number in the random array!";
                        // Stop searching
                        break;
                    }
                    // If no matches are found
                    else
                    {
                        // Change the result text to indicate there were no matches
                        resultText.text = "No matches found :(";
                    }
                }
            }
        }
    }
}