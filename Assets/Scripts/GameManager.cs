using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<GameObject> loveInterests = new List<GameObject>();
    public GameObject player;

    void Awake()
    {
        if(Instance==null && Instance!=this){
            Destroy(this);
        }
        else{
            Instance = this;
        }
    }
}
