using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    [SerializeField] attackManager attackReceiver;
    [SerializeField] health_SO healthCurr;


    private void OnEnable()
    {
        attackReceiver.damageEvent.AddListener(decrese);
    }

    void decrese(float damage )
    {
        float temp = healthCurr.getHealth();
        temp-=damage;

        if (temp <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
