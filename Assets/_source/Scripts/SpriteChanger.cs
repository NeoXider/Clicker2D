using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer targetRenderer;
    public Sprite newSprite;
    public Button triggerButton;

    void Start()
    {
        // Подписываемся на событие нажатия кнопки
        triggerButton.onClick.AddListener(ChangeSprite);
    }

    public void ChangeSprite()
    {
        // Меняем на новый спрайт
        targetRenderer.sprite = newSprite;
    }

    void OnDestroy()
    {
        // Отписываемся, чтобы избежать ошибок
        triggerButton.onClick.RemoveListener(ChangeSprite);
    }
}