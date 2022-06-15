using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    public GameObject obj;
    public GameObject cube;

    Vector3 startpos;
    Vector3 tmp;


    // Start is called before the first frame update
    void Start()
    {
        startpos = cube.transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        tmp = cube.transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit))
            {
                if (startpos == tmp)
                {
                    GameObject instance = (GameObject)Instantiate(cube,
                                         new Vector3(tmp.x, tmp.y, 0.0f),
                                         Quaternion.identity);
                }
            }
        }

    }
}
