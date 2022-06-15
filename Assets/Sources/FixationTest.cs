using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixationTest : MonoBehaviour
{

    float right = -4.7f;
    float left = -4.5f;
    float top = 0.3f;
    float lowest = 0.1f;
    float centerX = -4.71039f;
    float centerY = 0.25351f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tmp = this.transform.position;
        if(right< tmp.x && tmp.x < left)//rightとleftの間に来た時
        {
            if(lowest < tmp.y && tmp.y < top)//topとlowestの間に来た時
            {
                this.transform.position = new Vector3(centerX, centerY, 0);
            }
        }
    }
}
