using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabtest : MonoBehaviour
{
    //itemをいれる
    public GameObject obj;

    //itemのstartpositionを入れる
    Vector3 objstartpos;
    Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        objstartpos = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
         

        if (Input.GetMouseButtonDown(0))
        {
            
        }

    }
    private void OnMouseDown()
    {
        temp = objstartpos;

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hit))
        {
            if (objstartpos == temp)
            {
                GameObject instance = (GameObject)Instantiate(obj,
                                     new Vector3(temp.x, temp.y, 0.0f),
                                     Quaternion.identity);
            }
        }
    }
}
