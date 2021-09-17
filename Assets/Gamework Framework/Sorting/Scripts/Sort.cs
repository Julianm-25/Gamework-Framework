using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace GameworkFramework.Sorting
{
    /// <summary>
    /// Creates a random array and sorts it
    /// </summary>
    public class Sort : MonoBehaviour
    {
        /// <summary>
        /// The random array to be sorted
        /// </summary>
        public int[] randomArray;
        /// <summary>
        /// The finished sorted array
        /// </summary>
        public int[] sortedArray;
        /// <summary>
        /// The UI text showing the numbers in the array
        /// </summary>
        public Text text;
        /// <summary>
        /// Creates a random array to be sorted
        /// </summary>
        public void CreateRandomArray()
        {
            // Adds 10 random numbers between 1 and 100 to the random array
            for (int i = 0; i < 10; i++)
            {
                randomArray[i] = Random.Range(1, 100);
            }
        }
        /// <summary>
        /// Sorts the random array
        /// </summary>
        public void Sorter()
        {
            // Loop through the random array
            for (int i = 0; i < randomArray.Length; i++)
            {
                
            }
        }

        
        private void Start()
        {
            
        }
    }
}