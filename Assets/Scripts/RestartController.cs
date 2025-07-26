using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/*********************
 * 创建人:打错字的奶茶鼠 *
 * 功能说明:
 *********************/
public class RestartController : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            SceneManager.LoadScene("SampleScene");
        });
    }
}
