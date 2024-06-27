using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform shootPoint;
    [SerializeField] GameObject bulletPrefab;

    
    


    void Update()
    {

        if ( Input.GetKeyDown(KeyCode.F))
        {
            GameObject bullet = ObjectPooling.instance.getGameObject();

            if (bullet != null)
            {
                bullet.transform.position=transform.position;
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
            }
           
        }
    
    }
}
