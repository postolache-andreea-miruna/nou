using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    [SerializeField]
    private GameObject[] limite;
    private int limitaCurenta = 0;

    [SerializeField]
    private float vitezaPlatforma = 1.5f;

    private void Start()
    {
        Debug.Log("aici");
        GameObject.Find("Platforma").transform.position = new Vector3(1, 1, -2);
        
        
           
    }

    private void Update()
    {
        GameObject.Find("Platforma").transform.position = new Vector3(transform.position.x, transform.position.y, -2);
        if (Vector2.Distance(limite[limitaCurenta].transform.position, transform.position) < .1f) // daca se duce intr-un capat o ia invers
        {
            limitaCurenta = limitaCurenta + 1;
            if(limitaCurenta >= limite.Length)
            {
                limitaCurenta = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, limite[limitaCurenta].transform.position, Time.deltaTime * vitezaPlatforma);
        
    }
}
