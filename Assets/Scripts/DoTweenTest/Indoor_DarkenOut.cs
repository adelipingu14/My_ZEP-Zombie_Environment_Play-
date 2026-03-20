using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Indoor_DarkenOut : MonoBehaviour
{
    [SerializeField] private List<Tilemap> outdoorGrounds; //

    [SerializeField] private Color darkColor = new Color(0f, 0f, 0f, 1f);

    private int playerLayer;
    private List<Color> originalColors = new List<Color>();

    private void Awake()
    {
        playerLayer = LayerMask.NameToLayer("Player");

        foreach (var ground in outdoorGrounds)
        {
            if (ground != null)
                originalColors.Add(ground.color);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer != playerLayer) return;
        DarkenGrounds();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer != playerLayer) return;
        RestoreGrounds();
    }

    private void DarkenGrounds()
    {
        foreach (var ground in outdoorGrounds)
        {
            if (ground == null) continue;
            ground.color = darkColor;
        }
    }

    private void RestoreGrounds()
    {
        for (int i = 0; i < outdoorGrounds.Count; i++)
        {
            if (outdoorGrounds[i] == null) continue;
            outdoorGrounds[i].color = originalColors[i];
        }
    }
}