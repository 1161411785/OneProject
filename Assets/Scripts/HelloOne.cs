using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SelectionBase]
public class HelloOne : MonoBehaviour
{
    [Header("attack")]
    public int attack;

    [HideInInspector]

    public int defense;

    [Space]
    public int space;

    [ContextMenuItem("attack", "TestFun")]
    public int defense11;


    // Start is called before the first frame update
    void Start()
    {
        attack = 0;
        Debug.Log("hello world");
        //TODO:ÐÞ¸Ä²ÎÊý
        TestFun();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("TestFun111")]
    public void TestFun()
    {
        print("TestFun");
    }


    [ContextMenuItem("Reset", "ResetBiography")]
    [Multiline(8)]
    public string playerBiography = "";

    void ResetBiography()
    {
        Debug.Log(1111);
        playerBiography = "";
    }
}
