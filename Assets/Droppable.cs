using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Droppable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    // ドロップエリアに表示しているアイコン
    [SerializeField] private Image iconImage;
    // ドロップエリアに表示しているアイコンのハイライト色
    [SerializeField] private Color highlightedColor;
    // ドロップエリア表示のアイコンの元の色を保持
    private Color normalColor;


    // インスタンスのドーロ時Awakeメソッドの後に呼ばれる
    void Start()
    {
        // ドロップエリアに表示しているアイコンの元の色を保持しておく
        normalColor = iconImage.color;
    }

    // マウスカーソルが領域に入ったときに呼ばれる
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        if (pointerEventData.dragging)
        {
            //ドラッグ中だったら、ドロップエリアに表示しているアイコンの色をハイライト色に変更する
            iconImage.color = highlightedColor;
        }
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        if (pointerEventData.dragging)
        {
            // ドラッグ中だったら、ドロップエリアに表示しているアイコンの色を元に戻す
            iconImage.color = normalColor;
        }
    }

    public void OnDrop(PointerEventData pointerEventData)
    {
        // ドラッグしていたアイコンのImageコンポーネントを取得する
        Image droppedImage = pointerEventData.pointerDrag.GetComponent<Image>();
        // ドロップエリアに表示しているアイコンのスプライトを
        // ドロップされたアイコンと同じスプライトに変更して、色を元の色に戻す
        iconImage.sprite = droppedImage.sprite;
        iconImage.color = normalColor;
    }
}
