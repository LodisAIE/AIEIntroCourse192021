using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    //This game object's total health
    private float _health;
    //Whether or not this game object is alive
    public bool isAlive;

    // Use this for initialization
    void Start()
    {
        isAlive = true;
    }

    /// <summary>
    /// Decrements the object's health by the given value.
    /// </summary>
    /// <param name="damageAmount">The amount of damage to do to this game object</param>
    public void TakeDamage(float damageAmount)
    {
        _health -= damageAmount;
        if (_health <= 0)
        {
            isAlive = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Check to see if the game object is dead.
        if (isAlive == false)
        {
            //If the game object is dead, call the destroy function to remove it from the scene.
            Destroy(gameObject);
        }
    }
}
