using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameworkFramework.Core
{
    /// <summary>
    /// Stores the values used by the CustomInspector
    /// </summary>
    [ExecuteInEditMode]
    public class ObjectDimensions : MonoBehaviour
    {
        /// <summary>
        /// Position of the object
        /// </summary>
        public Vector3 position = Vector3.one;
        /// <summary>
        /// Rotation of the object
        /// </summary>
        public Vector3 rotation = Vector3.one;
        /// <summary>
        /// Scale of the object
        /// </summary>
        public Vector3 scale = Vector3.one;

        // Update is called once per frame
        void Update()
        {
            // Sets the position, scale, and rotation of the object to what was selected through CustomInspector
            transform.position = position;
            transform.localScale = scale;
            transform.rotation = Quaternion.Euler(rotation);
        }
    }
}