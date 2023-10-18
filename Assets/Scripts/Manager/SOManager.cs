using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOManager : MonoBehaviour
{
    public Data_SO test_SO;


    [ContextMenu("TestFun")]
    public void TestFun()
    {
        Debug.Log(test_SO.field1);
        Debug.Log(test_SO.field2);
        Debug.Log(test_SO.field3);
    }
}
