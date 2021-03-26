using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hooker : MonoBehaviour
{
    public GameObject enemy;
    public float hookerRate;

    private float nextHooker = 0f;

    void Update()
    {
        if (Time.time > nextHooker)
        {
            nextHooker = Time.time + hookerRate;

            Instantiate(enemy, transform.position, enemy.transform.rotation);
        }
    }
}
