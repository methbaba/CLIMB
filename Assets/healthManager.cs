using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManager : MonoBehaviour
{
    [SerializeField] HealthManager instance;

    private void Start()
    {
        if (instance == null)
        {
            instance = new HealthManager();
        }
    }




}
