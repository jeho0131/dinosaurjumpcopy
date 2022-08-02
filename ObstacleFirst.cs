using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFirst : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ObstaclePrefab);
    }
}
