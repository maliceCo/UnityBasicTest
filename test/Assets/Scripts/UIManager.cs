using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void Start()
    {
        Show(false);
    }

    public void Show(bool isShow)
    {
        gameObject.SetActive(isShow);
    }
}