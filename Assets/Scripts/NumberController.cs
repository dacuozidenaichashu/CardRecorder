using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
/*********************
 * 创建人:打错字的奶茶鼠 *
 * 功能说明:
 *********************/
public class NumberController : MonoBehaviour, IPointerClickHandler // 实现点击接口
{
    private TextMeshProUGUI mCountText;
    private int mCount = 4;

    private void Awake()
    {
        mCountText = transform.Find("CountText").GetComponent<TextMeshProUGUI>();
        UpdateCountText(); // 初始化文本显示
    }
    
    // 实现鼠标点击接口
    public void OnPointerClick(PointerEventData eventData)
    {
        mCount = eventData.button switch
        {
            PointerEventData.InputButton.Left => Mathf.Max(0, mCount - 1),
            PointerEventData.InputButton.Right => Mathf.Min(4, mCount + 1),
            _ => mCount
        };

        UpdateCountText(); // 更新文本
    }

    private void UpdateCountText()
    {
        mCountText.text = mCount.ToString();
    }
}
