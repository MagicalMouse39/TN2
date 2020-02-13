using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronPlayerController : MonoBehaviour
{

    public Rigidbody2D rigidbody2D;
    public int speed;
    public KeyCode w;
    public KeyCode a;
    public KeyCode s;
    public KeyCode d;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int y = 0;
        int x = 0;
        y += Input.GetKey(w) ? 1 : 0;
        y += Input.GetKey(s) ? -1 : 0;
        x += Input.GetKey(d) ? 1 : 0;
        x += Input.GetKey(a) ? -1 : 0;
        if (x != 0 || y != 0)
        {
            Vector2 vector2 = new Vector2(x, y);
            Move(vector2);
        }
    }

    public void Move(Vector2 vector)
    {
        vector.Scale(new Vector2(speed*Time.deltaTime, speed*Time.deltaTime));
        rigidbody2D.AddForce(vector,ForceMode2D.Impulse);
    }
}
