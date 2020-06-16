using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGameController : IGameController
{
    public bool FirebuttonPressed()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
