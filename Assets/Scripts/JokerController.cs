using TMPro;
using UnityEngine;
using UnityEngine.UI;
/*********************
 * 创建人:打错字的奶茶鼠 *
 * 功能说明:
 *********************/
public class JokerController : MonoBehaviour
{
    private void Awake()
    {
        transform.GetComponent<Button>().onClick.AddListener(() =>
        {
            GetComponentInChildren<TextMeshProUGUI>().color =
                GetComponentInChildren<TextMeshProUGUI>().color == Color.clear ? Color.black : Color.clear;
        });
    }
}
