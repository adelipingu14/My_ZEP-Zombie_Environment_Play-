using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float highPosY = 1f;
    public float lowPosY = -1f;

    public float holeSizeMin = 1f;
    public float holeSizeMax = 3f;

    public Transform zombie;


    public float widthPadding = 4f;

    MiniGameManager miniGameManager;

    public Vector3 SetZombieSpawn(Vector3 lastPosition, int obstacleCount)
    {
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float zomebieSpawn = Random.Range(2, 9);
        float halfHoleSize = holeSize / 2f;
        transform.position = new Vector3(0, holeSize);



        Vector3 placePosition = lastPosition + new Vector3(widthPadding, 0);
        placePosition.y = Random.Range(lowPosY, highPosY);

        transform.position = placePosition;

        return placePosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            MiniGameManager.instance.AddScore(1);
            Debug.Log("점수 +1");


            Vector3 newPos = transform.position + new Vector3(10f, 0f, 0f);
            newPos.y = Random.Range(lowPosY, highPosY);
            transform.position = newPos;
        }
    }
}