
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu (fileName ="Scripted OBJ" , menuName ="SO/systems/health manager") ]
public class HealthManager :ScriptableObject
{
    [SerializeField] int currHealth = 100;
    [SerializeField] int maxHealth = 100;
    [System.NonSerialized]
    public UnityEvent<int> healthChange;

    private void OnEnable()
    {
        currHealth = maxHealth;
        if (healthChange == null)
        {
            healthChange = new UnityEvent<int>();
        }
    }


    public void decreaseHealth(int damage)
    {
        currHealth -= damage;
        healthChange.Invoke(currHealth);
    }


}
