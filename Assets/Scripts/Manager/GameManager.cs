using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : Singleton<GameManager>
{
    public int intNum1;
    public int intNum2;
    public int intNum3;

    protected override void Awake()
    {
        base.Awake();
    }
}
