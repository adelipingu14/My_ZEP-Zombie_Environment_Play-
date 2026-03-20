using UnityEngine;

public class BuildingZoneTrigger : MonoBehaviour
{
    [SerializeField] private BuildingSection section;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        BuildingVisibilityManager manager = FindObjectOfType<BuildingVisibilityManager>();
        if (manager != null)
        {
            manager.ChangeSection(section);
        }
    }
}