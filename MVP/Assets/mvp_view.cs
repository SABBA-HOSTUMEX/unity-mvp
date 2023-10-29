using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mvp_view : MonoBehaviour
{
    public event System.Action IncreaseHealthEvent; // 用于通知 Presenter 增加健康值的事件
    public event System.Action DecreaseHealthEvent; // 用于通知 Presenter 减少健康值的事件

    public Button btninc; // "Increase" 按钮
    public Button btndec; // "Decrease" 按钮
    public Text textshow; // 用于显示信息的 Text 组件

    // Start is called before the first frame update
    void Start()
    {
        // 当按钮被点击时，触发相应的事件
        btninc.onClick.AddListener(OnIncreaseHealthClicked);
        btndec.onClick.AddListener(OnDecreaseHealthClicked);
    }

    // Method to handle "Increase" button click
    private void OnIncreaseHealthClicked()
    {
        IncreaseHealthEvent?.Invoke(); // 触发增加健康值事件
    }

    // Method to handle "Decrease" button click
    private void OnDecreaseHealthClicked()
    {
        DecreaseHealthEvent?.Invoke(); // 触发减少健康值事件
    }

    // Method to update the displayed health value
    public void UpdateHealth(int Health)
    {
        textshow.text = "Health: " + Health;
    }
}
