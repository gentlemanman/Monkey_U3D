using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour {
    private Ray ray;
    private RaycastHit hit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    //
	void Update () {
        CameraSendRay();
	}

    /// <summary>
    /// 主摄像机发射射线
    /// </summary>
    void CameraSendRay() {
        //鼠标左键发射
        if (Input.GetMouseButtonDown(0))
        {
            //主摄像机发射
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //检查碰撞并销毁

            if (Physics.Raycast(ray, out hit))
            {
                GameObject.Destroy(hit.collider.gameObject);
            }
        }
    }

}
