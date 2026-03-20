using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Button_dotween : MonoBehaviour,
    IPointerEnterHandler,
    IPointerDownHandler,
    IPointerUpHandler,
    IPointerExitHandler // 총 3개의 인터페이스를 상속받으며, 이것들은 모두 유니티에서 제공하는 마우스행동에 대한 인터페이스들
{
    private RectTransform rectTransform;
    private Tween pressTween;

    private Vector3 originalScale;  //버튼이 눌리면 크기가 작아지는 연출을해야해서 눌리기전의 스케일(크기)를 저장해야함
    private bool isHovered; //마우스가 올라가면 스크립트가 달린 버튼이 커지게 하는 기능 추가

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        originalScale = rectTransform.localScale;   //Awake로 버튼이 가지던 원래크기를 캐싱
    }

    public void OnPointerDown(PointerEventData eventData)   //마우스가 눌렸을때의 매서드 IPointerDownHandler 인터페이스 매서드
    {
        pressTween?.Kill(); // 진행중인 OnpointerUP(원래크기인 상태)를 끝내고

        pressTween = rectTransform
            .DOScale(originalScale * 0.9f, 0.08f) // scale을 0.9 크기로 줄인다 (0.08f는 걸리는시간 즉, 거의즉시)
            .SetEase(Ease.OutQuad)               // 눌렸다 멈추는 느낌이 들게 하는 연출용코드
            .SetLink(gameObject);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Release();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovered = true;
        Hover();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovered = false;
        Release();
    }

    private void Release()  // 마우스가 때어졌을때의 매서드 즉 버튼이 안눌렸을때의 오리지널 크기를 유지하게끔하는 매서드
    {
        pressTween?.Kill(); // OnpointerDown 두트윈을 끝내고


        Vector3 targetScale = isHovered
            ? originalScale * 1.1f
            : originalScale;

        pressTween = rectTransform
            .DOScale(originalScale, 0.12f)  // 캐싱해둔 오리지널 크기로 다시 원상복구 시킴
            .SetEase(Ease.OutBack)         // Ease.OutQuad 보다 더 탄성있는 연출용 코드
            .SetLink(gameObject);
    }

    private void Hover()
    {
        pressTween?.Kill();

        pressTween = rectTransform
            .DOScale(originalScale * 1.1f, 0.12f)
            .SetEase(Ease.OutQuad)
            .SetLink(gameObject);
    }

    private void OnDisable()
    {
        pressTween?.Kill();
    }
}