using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider))]
[ExecuteInEditMode]
[SelectionBase]
[Serializable]
public class HelloOne : MonoBehaviour
{

    [Header("base info")]
    public int field1;

    [Space]
    [Range(0, 100)]
    public int field2;

    [Tooltip("Description hahahahha")]
    public int field3;

    [Multiline]
    public string field4;

    [TextArea]
    public string field5;

    [HideInInspector]
    public int field6;

    [SerializeField]
    private int field7;

    public int field8;

    [ContextMenuItem("field9", "Fun1")]
    public int field9;

    [ContextMenu("Fun1")]
    public void Fun1()
    {
        Debug.Log($"Fun1");
    }

}
