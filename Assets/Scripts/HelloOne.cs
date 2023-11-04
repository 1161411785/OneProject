using System;

using Unity.VisualScripting;

using UnityEditor.VersionControl;

using UnityEngine;
using UnityEngine.ProBuilder.Shapes;


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


    private void Start()
    {
        Fun1();
        Application.targetFrameRate = -1;
        //Debug.Log(Application.targetFrameRate);

    }

    Vector3 transPos = Vector3.zero;
    private void Update()
    {
        //Debug.Log($"Update :{ Application.targetFrameRate}");
        var targetPosition = new Vector3(10, 10, 10);
        //transform.position = Vector3.Lerp(transform.position, targetPosition, 0.5f);
        //transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 5f);
        Debug.Log($"num:{Time.time}");
    }

    int num = 0;
    private void FixedUpdate()
    {
        //Debug.Log($"Application.targetFrameRate{Time.deltaTime} num:{Time.time }");
    }

    private void OnDisable()
    {
        
    }

    private void OnApplicationPause(bool pause)
    {
        Debug.Log($"OnApplicationPause pause: {pause}");
    }

    private void OnApplicationFocus(bool focus)
    {
        Debug.Log($"OnApplicationFocus focus: {focus}");
    }

    private void OnApplicationQuit()
    {
        Debug.Log($"OnApplicationQuit");
    }
}

