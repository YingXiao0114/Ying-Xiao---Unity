using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class myClass { };

public class VectorDrawer : MonoBehaviour
{

    // Declare variables here that are global to this script / class / GameObject
    //public Vector3 from = new Vector3(0, 0, 0);
    //public Vector3 to = new Vector3(1,10,1);
    public Vector3 direction = new Vector3(1, 10, 1);
    [Range(0,10)]
    public float scale = 1;
	public Color lineColor = new Vector4(1f, 1f, 0.016f, 1f);
//	public Color xColor = new Vector4(1f,0f,0f,1f);
//	public Color yColor = new Vector4(0f,1f,0f,1f);


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnDrawGizmos()
    {
		DrawVector(transform.position, Vector3.right, Color.red);
		DrawVector(transform.position, Vector3.up, Color.green);
        DrawVector(transform.position, Vector3.forward, Color.blue);

        //DrawVector(transform.position, transform.rotation*direction.normalized * scale, Color.white);
        DrawVector(transform.position, direction.normalized*scale, lineColor);
    }

    void DrawVector(Vector3 start, Vector3 direction, Color color )
    {
        Gizmos.color = color;
        Gizmos.DrawLine(start,start+direction);
    }
    
}

