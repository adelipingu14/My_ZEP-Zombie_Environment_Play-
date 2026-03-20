using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CooldownSpin : MonoBehaviour
{
    [SerializeField] private Image cooldownImage;
    [SerializeField] private float duration;

    private bool isCoolingDown;
    private void Start()
    {
        PlayCooldown();
    }

    public void PlayCooldown()
    {
        if (isCoolingDown) return;

        isCoolingDown = true;

        cooldownImage.DOKill();
        cooldownImage.fillAmount = 0f;

        cooldownImage
            .DOFillAmount(1f, duration)
            .SetEase(Ease.Linear)
            .OnComplete(() =>
            {
                isCoolingDown = false;
            });
    }

    public void ResetCooldown()
    {
        cooldownImage.DOKill();
        cooldownImage.fillAmount = 0f;
    }
}