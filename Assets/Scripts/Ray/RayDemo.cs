using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDemo : MonoBehaviour {
    private int x=10;
    private int y=5;
    private Ray ray;

    private RaycastHit hit;
    public GameObject prefabBrick;

    public GameObject prefabBullet;

    private Transform m_Transform;
    // Use this for initialization
    void Start () {
        m_Transform = gameObject.GetComponent<Transform>();
        CreatWall();

    }
	
	// Update is called once per frame
	void Update () {
        SendBullet();

    }

    void CreatWall() {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                GameObject wall=GameObject.Instantiate(prefabBrick, new Vector3(i, j, 0), Quaternion.identity)as GameObject;
                //弄个出五颜六色的墙壁
                wall.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            }
        }
    }

    void SendBullet() {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                //计算方向
                Vector3 dir = hit.point - m_Transform.position;
                //绘制射线（只能在Scene视角查看,game视图想要看到可用LineRenderer）
                Debug.DrawRay(m_Transform.position,dir,Color.red);
                //实例化子弹
                GameObject go = GameObject.Instantiate(prefabBullet, m_Transform.position, Quaternion.identity) as GameObject;
                //发射子弹
                go.GetComponent<Rigidbody>().AddForce(dir * 200);
            }
        }
    }
}
