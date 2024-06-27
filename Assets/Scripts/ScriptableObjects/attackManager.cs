using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu (fileName ="attack_type" , menuName ="SO/systems/attack Manager")]
public class attackManager : ScriptableObject
{
    [SerializeField]  float damage;

    [System.NonSerialized]
    public UnityEvent<float> damageEvent;
    private void OnEnable()
    {
        
        if (damageEvent==null)
        {
            damageEvent = new UnityEvent<float>();
        }
    }
    public void doDamage()
    {
        if (damageEvent != null) { 
        damageEvent.Invoke(damage);
        }
    }

}
