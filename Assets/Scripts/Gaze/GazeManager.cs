using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeManager : Singleton<GazeManager>
{




    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this);
    }
}
