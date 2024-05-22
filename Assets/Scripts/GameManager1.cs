using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public List<GameObject> enemiesInScreen;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            DestroyEnemiesInScreen();
        }
    }

    public void DestroyEnemiesInScreen()
    {
        foreach (GameObject enemy in enemiesInScreen)
        {
            Destroy(enemy);
        }
    }
}

