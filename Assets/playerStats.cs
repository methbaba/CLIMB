using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    [SerializeField] playerStats playerstats;

    private void Start()
    {
        playerstats = GetComponent<playerStats>();
    }


}
