using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PopTest : MonoBehaviour
{

    IPopManager popManager;

    [Inject]
    public void SetupDI(IPopManager popManager)
    {
        this.popManager = popManager;
    }


    void Start()
    {
        popManager.PopMessage("Hi I am Zenject");
    }

}
