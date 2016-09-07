using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {
    public bool isActive = true;
    public bool hasTimer = false;
    public float interval;
    public Transform source;
    public float width;
    public bool isHorizontal = false;
    public Vector3 endPoint = new Vector3(0, -5, 0);
    public bool useWorldSpace = false;
    
    private LineRenderer ln;
    private BoxCollider2D col;


    // Use this for initialization
    void Start() {
        ln = gameObject.AddComponent<LineRenderer>();
        col = gameObject.AddComponent<BoxCollider2D>();

        ln.useWorldSpace = useWorldSpace;
        ln.SetWidth(width, width);
        ln.SetVertexCount(2);
        ln.SetPositions(new Vector3[] {
            new Vector3(0, 0, 0),
            endPoint
        });

        col.isTrigger = true;

        if (isHorizontal)
        {
            col.size = new Vector2(Mathf.Abs(endPoint.x), width);
            col.offset = new Vector2(endPoint.x / 2, 0);
        }
        else
        {
            col.size = new Vector2(width, Mathf.Abs(endPoint.y));
            col.offset = new Vector2(0, endPoint.y / 2);
        }

        if (hasTimer) InvokeRepeating("toggleActive", 0, interval);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //TODO: Possibly move laser here   
    }

    void OnTriggerEnter2D(Collider2D source) {
        //TODO: Damage the player
        if (source.name == "Player" && isActive)
        {
            Debug.Log("damage");
        }
    }

    void toggleActive()
    {
        isActive = !isActive;

        if (isActive)
        {
            ln.SetColors(new Color(255, 0, 0, 255), new Color(255, 0, 0, 255));
        }
        else
        {
            ln.SetColors(new Color(0,255, 0, 255), new Color(0, 255, 0, 255));
        }
    }
}
