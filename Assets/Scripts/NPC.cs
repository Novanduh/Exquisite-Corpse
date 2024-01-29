using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject loveMeter;
    bool loveStatus;

    void OnTriggerEnter(Collider other)
    {
        loveStatus = true;
        loveMeter.SetActive(true);
    }

    void Start()
    {
        loveStatus = false;
        loveMeter.SetActive(false);
    }

    public void LoveStatus(bool newLoveStatus){
        this.loveStatus = newLoveStatus;
    }

    public bool GetLoveStatus(){
        return loveStatus;
    }
}
