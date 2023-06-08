using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject objects;
    void Start()
    {
        InvokeRepeating("CreateObjects",1,1);
    }

    // Update is called once per frame
    void CreateObjects()
    {
        Instantiate(objects, new Vector3(3.43f,2.83f,0),Quaternion.identity);
    }
}
