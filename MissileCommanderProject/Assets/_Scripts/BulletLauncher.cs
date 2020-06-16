using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    IGameController controller;

    public void SetGameController(IGameController controller)
    {
        this.controller = controller;
    }

    private void Update()
    {
     
        if(controller != null)
        {
            if (controller.FirebuttonPressed())
            {
                Debug.Log("Fired a bullet!");
            }
        }
        else
        {
            Debug.LogError("Controller is null!");
        }
    }

}
