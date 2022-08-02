using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    bool gameIng;
    public GameObject ObstaclePrefab;

    // Start is called before the first frame update

    void Start()
    {
        gameIng = true;
    }

    public void setGoing( bool a)
    {

        this.gameIng = a;
    }

    public bool getGoing()
    {

        return this.gameIng;
    }

    public void Spawn()
    {
        Vector3 Pos = new Vector3(15, -1.5f, 0);
        GameObject sp = Instantiate(ObstaclePrefab);
        sp.transform.position = Pos;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
