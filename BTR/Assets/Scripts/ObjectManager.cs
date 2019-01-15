using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    // Singleton of ObjectManager script for out of class acess
    private static ObjectManager instance;
    public static ObjectManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    #region SPAWNABLES
    [Header("OBJECT MANAGER")]
    [Tooltip("Spawnable player with fps controls.")]
    public GameObject player;
    #endregion
}
