using System;
using UnityEngine;


[RequireComponent(typeof(BoxCollider))]
//[ExecuteInEditMode]
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

        Debug.Log(Vector3.Dot(new Vector3(15, 0, 20), new Vector3(1, 1, 1)));
        Debug.Log(new Vector3(150, 15.3f, 20).magnitude);
        Debug.Log(Time.deltaTime);
    }


    Vector3 transPos = Vector3.zero;
    private void Update()
    {
        var targetPosition = new Vector3(10, 10, 10);
        //transform.position = Vector3.Lerp(transform.position, targetPosition, 0.5f);
        //transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 5f);
    }

}
