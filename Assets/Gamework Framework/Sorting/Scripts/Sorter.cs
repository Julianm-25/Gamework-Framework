using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameworkFramework.Sorting
{
    /// <summary>
    /// Creates a random array and then sorts it
    /// </summary>
    public class Sorter : MonoBehaviour
    {
        /// <summary>
        /// The array to be sorted
        /// </summary>
        public int[] array;
        /// <summary>
        /// A temporary value to hold a number from the array when swapping two numbers
        /// </summary>
        public int tempValue;
        /// <summary>
        /// The text that displays the unsorted array
        /// </summary>
        public Text randomArrayText;
        /// <summary>
        /// The text that displays the sorted array
        /// </summary>
        public Text sortedArrayText;
        /// <summary>
        /// The comparator used to compare two values in the array
        /// </summary>
        Comparator comparator = new Comparator();
        // Start is called before the first frame update
        void Start()
        {
            // Sets comparator as a new Comparator
            
            // Sets array as a new int array with 20 values
            array = new int[20];
            // Adds 20 random numbers between 1 and 100 to the random array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Random.Range(1,100);
                Debug.Log(array[i]);
                // Adds each value in the array to the random array text
                randomArrayText.text += array[i].ToString();
                // with a space between each value
                randomArrayText.text += " ";
            }
        }
        /// <summary>
        /// Sorts the random array using the returned value of the comparator
        /// </summary>
        public void SortArray()
        {
            // Compares all values in the array except for the last 10 with the value 10 values ahead of it
            // and swaps the values if the value at i is bigger than the value 10 values ahead of it
            for (int i = 0; i < array.Length - 10; i++)
            {
                if (comparator.Compare(array[i], array[i + 10]) == 1)
                {
                    tempValue = array[i];
                    array[i] = array[i + 10];
                    array[i + 10] = tempValue;
                }
            }
            // Repeated with a distance of 9
            for (int i = 0; i < array.Length - 9; i++)
            {
                if (comparator.Compare(array[i], array[i + 9]) == 1)
                {
                    tempValue = array[i];
                    array[i] = array[i + 9];
                    array[i + 9] = tempValue;
                }
            }
            // Repeated with a distance of 8
            for (int i = 0; i < array.Length - 8; i++)
            {
                if (comparator.Compare(array[i], array[i + 8]) == 1)
                {
                    tempValue = array[i];
                    array[i] = array[i + 8];
                    array[i + 8] = tempValue;
                }
            }
            // Repeated with a distance of 7
            for (int i = 0; i < array.Length - 7; i++)
            {
                if (comparator.Compare(array[i], array[i + 7]) == 1)
                {
                    tempValue = array[i];
                    array[i] = array[i + 7];
                    array[i + 7] = tempValue;
                }
            }
            // Repeated with a distance of 6
            for (int i = 0; i < array.Length - 6; i++)
            {
                if (comparator.Compare(array[i], array[i + 6]) == 1)
                {
                    tempValue = array[i];
                    array[i] = array[i + 6];
                    array[i + 6] = tempValue;
                }
            }
            // Repeated with a distance of 5
            for (int i = 0; i < array.Length - 5; i++)
            {
                if (comparator.Compare(array[i], array[i + 5]) == 1)
                {
                    tempValue = array[i];
                    array[i] = array[i + 5];
                    array[i + 5] = tempValue;
                }
            }
            // Repeated with a distance of 4
            for (int i = 0; i < array.Length - 4; i++)
            {
                if (comparator.Compare(array[i], array[i + 4]) == 1)
                {
                    tempValue = array[i];
                    array[i] = array[i + 4];
                    array[i + 4] = tempValue;
                }
            }
            // Repeated with a distance of 3
            for (int i = 0; i < array.Length - 3; i++)
            {
                if (comparator.Compare(array[i], array[i + 3]) == 1)
                {
                    tempValue = array[i];
                    array[i] = array[i + 3];
                    array[i + 3] = tempValue;
                }
            }
            // Repeated with a distance of 2
            for (int i = 0; i < array.Length - 2; i++)
            {
                if (comparator.Compare(array[i], array[i + 2]) == 1)
                {
                    tempValue = array[i];
                    array[i] = array[i + 2];
                    array[i + 2] = tempValue;
                }
            }
            // Repeated with a distance of 1
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (comparator.Compare(array[i], array[i + 1]) == 1)
                {
                    tempValue = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = tempValue;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                // Adds each value of the sorted array to the sorted array text
                sortedArrayText.text += array[i].ToString();
                // with a space between each value
                sortedArrayText.text += " ";
            }
        }
    }
}