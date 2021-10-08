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
        /// Center of the object
        /// </summary>
        public Vector3 center = Vector3.zero;
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
        private void OnDrawGizmos()
        {
            // Store the original Gizmos Matrix
            Matrix4x4 original = Gizmos.matrix;
            
            // Make the gizmos use the current objects transform (matrix)
            Gizmos.matrix = transform.localToWorldMatrix;
            
            // Draw a blue cube 
            Gizmos.color = new Color(0, 0, 0.25f);
            Gizmos.DrawCube(center, scale);
            
            // Reset the Gizmos matrix to the original one
            Gizmos.matrix = original;
        }
    }
}