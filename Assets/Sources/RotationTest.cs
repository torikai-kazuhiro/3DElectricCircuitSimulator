using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTest : MonoBehaviour
{
    float click;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.Euler(click, 90.0f, 0.0f);
        

    }
    void OnMouseOver()
    {
        //オブジェクトの上に右クリックを受け付ける
        if (Input.GetMouseButtonDown(1))   click += 90;
    }
}
