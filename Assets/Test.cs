using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];

        array[0] = 15;
        array[1] = 18;
        array[2] = 25;
        array[3] = 14;
        array[4] = 5;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for (int j = 4; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
