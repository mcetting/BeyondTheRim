using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton of GameManger script for out of class acess
    private static GameManager instance;
    public static GameManager Instance { get; private set; }

    // for script value initializing because it runs before start
    private void Awake()
    {
        Instance = this;
    }

    // first iteration of spawning an object in the gameworld
    public void SpawnObjectAtPosition(GameObject obj, Vector3 position)
    {
        GameObject newObj = Instantiate(obj);
        newObj.transform.position = position;
    }
}
