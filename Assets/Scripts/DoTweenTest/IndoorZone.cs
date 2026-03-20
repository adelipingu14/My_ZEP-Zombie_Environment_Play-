using DG.Tweening;
using UnityEngine;
using UnityEngine.Tilemaps;

public class IndoorZone : MonoBehaviour
{
    [SerializeField] private Tilemap buildingTilemap;   // 건물내부로 여겨질 istrigger가 켜진 콜라이더 타일맵을 따로 만들생각
    [SerializeField] private float fadeDuration = 0.25f;    // Dotween 설정으로 가려질 그리드를 서서히 사라지게 하는 연출용 두트윈 필드
    [Range(0f, 1f)][SerializeField] private float hiddenAlpha = 0f;

    private int playerLayer;    
    private Color originalColor;    //등록한 타일맵의 오리지널 알파값을 저장하기위한 변수
    private Tween fadeTween;        //두트윈 핸들러

    private void Awake()
    {
        playerLayer = LayerMask.NameToLayer("Player");

        if (buildingTilemap != null)
            originalColor = buildingTilemap.color;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer != playerLayer) return;
        FadeOutBuilding();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer != playerLayer) return;
        FadeInBuilding();
    }

    private void FadeOutBuilding()  // 게터 세터를 이해하고 GPT를 통해 완성한 코드
    {
        if (buildingTilemap == null) return;

        fadeTween?.Kill();

        Color target = originalColor;
        target.a = hiddenAlpha;

        fadeTween = DOTween.To(
            () => buildingTilemap.color,          // 현재 값 getter
            x => buildingTilemap.color = x,       // setter
            target,                               // 목표 값
            fadeDuration
        ).SetEase(Ease.OutQuad);
    }

    private void FadeInBuilding()
    {
        if (buildingTilemap == null) return;

        fadeTween?.Kill();

        fadeTween = DOTween.To(
            () => buildingTilemap.color,
            x => buildingTilemap.color = x,
            originalColor,
            fadeDuration
        ).SetEase(Ease.OutQuad);
    }    
}