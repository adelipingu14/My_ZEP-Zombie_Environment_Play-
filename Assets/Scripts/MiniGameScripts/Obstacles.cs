using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float highPosY = 4f;
    public float lowPosY = -4f;

    public float holeSizeMin = 1f;
    public float holeSizeMax = 3f;

    public Transform Carstacle01;
    public Transform Carstacle02;
    public Transform Carstacle03;


    public float widthPadding = 4f;

    MiniGameManager minigameManager;

    private void Start()
    {
        minigameManager = MiniGameManager.instance;
    }

    public Vector3 SetRandomPlace(Vector3 lastPosition, int obstaclecount)
    {
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float halfHoleSize = holeSize / 4;

        Carstacle01.localPosition = new Vector3(0, halfHoleSize);
        Carstacle02.localPosition = new Vector3(0, -halfHoleSize);
        Carstacle03.localPosition = new Vector3(0, halfHoleSize);


        Vector3 placePosition = lastPosition + new Vector3(widthPadding, 0);
        placePosition.y = Random.Range(lowPosY, highPosY);

        transform.position = placePosition;

        return placePosition;
    }
}