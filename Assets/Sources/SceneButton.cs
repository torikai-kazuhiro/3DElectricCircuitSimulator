using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit))
            {
                string objectName = hit.collider.gameObject.name;
                
                //3DButtonが押されたらSimulatSceneに移動
                if(objectName == "3DButton") SceneManager.LoadScene("SimulatScene");

                //2DButtonが押されたらEditSceneに移動
                if (objectName == "2DButton") SceneManager.LoadScene("EditScene");
            }
        }
    }
}
