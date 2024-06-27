using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName ="Scripted OBJ" , menuName ="SO/stats/health")]
public class health_SO : ScriptableObject
{
    [SerializeField] float health = 100f;
    [SerializeField] float attackVal = 10f;


    public float getHealth()
    {
        return health;
    }
}
