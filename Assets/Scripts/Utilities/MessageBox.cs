using TMPro;
using UnityEngine;

public class MessageBox : MonoBehaviour
{
    public static MessageBox Instance { get; private set; }

    [SerializeField] public GameObject panel;   // MessagePanel
    [SerializeField] public TMP_Text text;      // MessageText

    void Awake()
    {
        Instance = this;
        text.text = "";
        panel.SetActive(false);
    }

    public void Show(string message)
    {
        text.text = message;
        panel.SetActive(true);
    }

    public void Hide() => panel.SetActive(false);
}
