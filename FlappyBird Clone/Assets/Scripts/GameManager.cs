using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform Walls;
    public Transform Player;

    public bool creatingWall;
    void Start()
    {
        creatingWall = false;
        Instantiate(Walls, new Vector3(Player.transform.position.x + 10, Random.Range(-2.5f, 3f), 0), Quaternion.identity);
        StartCoroutine(CreateTime());
    }

    void FixedUpdate()
    {
        if (creatingWall == true)
        {
            creatingWall = false;
            Instantiate(Walls, new Vector3(Player.transform.position.x + 10, Random.Range(-2.5f, 3f), 0), Quaternion.identity);
            StartCoroutine(CreateTime());
        }
    }

    IEnumerator CreateTime()
    {
        yield return new WaitForSeconds(3f);
        creatingWall = true;
    }

    
}
