using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace GameworkFramework.Editor
{
    /// <summary>
    /// Creates a custom inspector that allows the user to edit the position, scale, and rotation of GameObjects
    /// </summary>
    [CustomEditor(typeof(CustomInspector))]
    [CanEditMultipleObjects]
    public class CustomInspector : UnityEditor.Editor
    {
        /// <summary>
        /// The position of the GameObject
        /// </summary>
        SerializedProperty position;
        /// <summary>
        /// The rotation of the GameObject
        /// </summary>
        SerializedProperty rotation;
        /// <summary>
        /// The scale of the GameObject
        /// </summary>
        SerializedProperty scale;
        /// <summary>
        /// OnEnable runs when the attached object is enabled
        /// </summary>
        void OnEnable()
        {
            // The references to the values of the variables is held in the script
            position = serializedObject.FindProperty("position");
            rotation = serializedObject.FindProperty("rotation");
            scale = serializedObject.FindProperty("scale");
        }
        /// <summary>
        /// This is where we draw the custom inspector window and render the scripts properties
        /// </summary>
        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(position);
            EditorGUILayout.PropertyField(rotation);
            EditorGUILayout.PropertyField(scale);
            serializedObject.ApplyModifiedProperties();
        }
    }
}