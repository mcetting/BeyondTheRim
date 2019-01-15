using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton of GameManger script for out of class acess
    private static GameManager instance;
    public static GameManager Instance { get; private set; }

    [SerializeField]private int numberOfPlayers;
    private List<GameObject> players = new List<GameObject>();

    // for script value initializing because it runs before start
    private void Awake()
    {
        Instance = this;
    }
    
    // runs after awake but before update and only on scene load
    private void Start()
    {
        SpawnPlayers(numberOfPlayers);
    }

    // first iteration of spawning an object in the gameworld
    public GameObject SpawnObjectAtPosition(GameObject obj, Vector3 position)
    {
        GameObject newObj = Instantiate(obj);
        newObj.transform.position = position;
        return newObj;
    }

    private void SpawnPlayers(int num)
    {
        for (int i = 0; i < num; i++)
        {
            Vector3 possiblePosition = new Vector3(Random.Range(-50, 50), 0, Random.Range(-50, 50));
            GameObject newObj = SpawnObjectAtPosition(ObjectManager.Instance.player, possiblePosition);
            players.Add(newObj);
        }
    }
}
