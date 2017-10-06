using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarCharger : MonoBehaviour {
    public Transform BarWaiting;
    public Transform TextProgress;
    public Transform TextCharger;

    [SerializeField]
    private float currentAmount;
    [SerializeField]
    private float speed;
	
	void Update ()
    {
        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
            TextProgress.GetComponent<Text>().text = ((int)currentAmount).ToString() + "%";
            TextCharger.gameObject.SetActive(true);
        }
        else
        {
            TextCharger.gameObject.SetActive(false);
            TextProgress.GetComponent<Text>().text = "Listo!";
            SceneManager.LoadScene("003_level_001");
        }
        BarWaiting.GetComponent<Image>().fillAmount = currentAmount / 100;
    }
}
