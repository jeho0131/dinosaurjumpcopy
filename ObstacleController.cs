using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    int[] produceL = new int[] {6, -2, -10 };
    float speed = -0.05f;
    int random = 0;
    int spawn = 0;
    private GameDirector script;

    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(0, 3);
        script = GameObject.Find("GameDirector").GetComponent<GameDirector>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (this.transform.position.x <= produceL[random] && spawn == 0) {
            script.Spawn();
            spawn = 1;
        }

        if (this.transform.position.x < -15)
        {
            Destroy(gameObject);
        } 
        else if(script.getGoing())
        {
            transform.Translate(speed, 0, 0);
        }
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.name == "player")
        {
            Time.timeScale = 0f;
            script.setGoing(false);
            Destroy(this);
        }
    }
}
