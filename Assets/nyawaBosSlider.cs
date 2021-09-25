using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class nyawaBosSlider : MonoBehaviour
{
    public NyawaBos nyawabos;
    public float nyawa;
    public Image img;
    float a;
    // Start is called before the first frame update
    void Start()
    {
        nyawa = nyawabos.nyawaBos;
        a = nyawabos.nyawaBos;

    }

    // Update is called once per frame
    void Update()
    {
        a = nyawabos.nyawaBos;
        float b = nyawa;
        float c = a / b;
        img.fillAmount = c;
    }
}
