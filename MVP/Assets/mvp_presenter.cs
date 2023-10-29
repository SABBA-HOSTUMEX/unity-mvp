using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mvp_presenter : MonoBehaviour
{
    private mvp_view mvpview;
    private mvp_model mvpmodel;

    // Start is called before the first frame update
    void Start()
    {
        mvpview = GetComponent<mvp_view>(); // 获取视图组件

        // 订阅视图的事件
        mvpview.IncreaseHealthEvent += IncreaseHealth;
        mvpview.DecreaseHealthEvent += DecreaseHealth;

        // Initialize the model and update the UI with the initial health value
        mvpmodel = new mvp_model(); // 你需要实现 mvp_model 类
        mvpview.UpdateHealth(mvpmodel.Health);
    }

    // Update is called once per frame
    void Update()
    {
        // 这里可以处理其他逻辑
    }

    // Method to handle an increase in health
    private void IncreaseHealth()
    {
        mvpmodel.Health += 10;
        mvpview.UpdateHealth(mvpmodel.Health);
    }

    // Method to handle a decrease in health
    private void DecreaseHealth()
    {
        mvpmodel.Health -= 10;
        mvpview.UpdateHealth(mvpmodel.Health);
    }
}
