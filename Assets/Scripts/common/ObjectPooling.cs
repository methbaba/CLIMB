using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling instance;

    List<GameObject> poolingObjects = new List<GameObject>();
    [SerializeField] GameObject poolingObject;
    int poolCount = 20;  

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        for(int i = 0; i < poolCount; i++)
        {
            GameObject obj = Instantiate(poolingObject);
            poolingObject.SetActive(false);
            poolingObjects.Add(obj);
        }
    }


    public GameObject getGameObject()
    {
        for (int i = 0; i < poolingObjects.Count; i++)
        {
            if (!poolingObjects[i].activeInHierarchy)
            {
                return poolingObjects[i];
            }
        }

        return null;
    }
}
