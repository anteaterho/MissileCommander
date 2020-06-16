using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseGameController : IGameController
{
    public bool FirebuttonPressed()
    {
        return Input.GetMouseButtonDown(0);
    }
}
