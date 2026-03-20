using UnityEngine;

public class BuildingVisibilityManager : MonoBehaviour
{
    [SerializeField] private GameObject floor01;
    [SerializeField] private GameObject lowerStair;
    [SerializeField] private GameObject landing;
    [SerializeField] private GameObject upperStair;
    [SerializeField] private GameObject floor02;

    private void Start()
    {
        ChangeSection(BuildingSection.Floor1Side);
    }

    public void ChangeSection(BuildingSection section)
    {
        switch (section)
        {
            case BuildingSection.Floor1Side:
                SetActiveGroup(true, true, false, false, false);
                break;

            case BuildingSection.Landing:
                SetActiveGroup(false, true, true, true, false);
                break;

            case BuildingSection.Floor2Side:
                SetActiveGroup(false, false, true, true, true);
                break;
        }
    }

    private void SetActiveGroup(bool floor01On, bool lowerStairOn, bool landingOn, bool upperStairOn, bool floor02On)
    {
        floor01.SetActive(floor01On);
        lowerStair.SetActive(lowerStairOn);
        landing.SetActive(landingOn);
        upperStair.SetActive(upperStairOn);
        floor02.SetActive(floor02On);
    }
}