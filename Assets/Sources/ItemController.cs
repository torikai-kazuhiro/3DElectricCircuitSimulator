using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    //クリックしたときに足してく変数
    float click; 


    void Start()
    {
        
    }

    void Update()
    {
        //クリックしたら回転する
        this.transform.rotation = Quaternion.Euler(click, 90.0f, 0.0f);
    }

    void OnMouseOver()
    {
        //オブジェクトの上に右クリックを受け付ける
        if (Input.GetMouseButtonDown(1)) click += 90;
    }


    Vector3 pointWorld; //object座標入れる
    void OnMouseDrag()
    {
        //objectの位置をワールド座標からスクリーン座標に変換して、objectPointに格納
        Vector3 objectPoint
            = Camera.main.WorldToScreenPoint(transform.position);


        //objectの現在位置(マウス位置)を、pointScreenに格納
        Vector3 pointScreen
            = new Vector3(Input.mousePosition.x,
                          Input.mousePosition.y,
                          objectPoint.z);

        //objectの現在位置を、スクリーン座標からワールド座標に変換して、pointWorldに格納
        pointWorld = Camera.main.ScreenToWorldPoint(pointScreen);
        pointWorld.z = -1f; //objectを前にする

        //objectの位置を、pointWorldにする
        transform.position = pointWorld;

    }

    void OnMouseUp()
    {
        //objectを後ろに戻す
        pointWorld.z = 0f;
        transform.position = pointWorld;
    }
}
