using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsClass : MonoBehaviour {
    private float num = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //屏幕类
		if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("高度：" + Screen.height);
            Debug.Log("宽度：" + Screen.width);
        }
        //时间类
        //Debug.Log("时间" +Time.time);
       // Debug.Log("时间" + Time.deltaTime);
        Time.timeScale = 1;


        //数学类 Abs() Max() Min() Round() Lerp()
        num = Mathf.Lerp(num, 10, Time.deltaTime);

        Debug.Log(num);
    }
}

