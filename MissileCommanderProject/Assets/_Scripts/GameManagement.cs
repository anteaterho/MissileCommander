using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    [SerializeField]
    BulletLauncher launcherPrefab;
    BulletLauncher launcher;

    // Start is called before the first frame update
    void Start()
    {
        launcher = Instantiate(launcherPrefab);
        //launcher.SetGameController(new MouseGameController());
        launcher.SetGameController(new KeyGameController());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
