using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptAnimalia2 : MonoBehaviour
{
    public GameObject a, b, c, d, e,f,g,h,i,j,k,l,m,n/*,o*/, aBlack, bBlack, cBlack, dBlack, eBlack, fBlack, gBlack, hBlack, iBlack, JBlack, KBlack, lBlack, mBlack, nBlack/*, oBlack*/, yewwMenang,soal,Next;

    Vector2 aInitialPos, bInitialPos, cInitialPos, dInitialPos, eInitialPos, fInitialPos, gInitialPos, hInitialPos, iInitialPos, jInitialPos, kInitialPos,lInitialPos, mInitialPos, nInitialPos/*, oInitialPos*/;

    float penghitunganmundur = 30;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    int JumlahBenar = 0;

    public Text timerUI, Nnilai;

    //bool acorrect, bcorrect, ccorrect, dcorrect, ecorrect = false;


    void Start()
    {
        aInitialPos = a.transform.position;
        bInitialPos = b.transform.position;
        cInitialPos = c.transform.position;
        dInitialPos = d.transform.position;
        eInitialPos = e.transform.position;
        fInitialPos = f.transform.position;
        gInitialPos = g.transform.position;
        hInitialPos = h.transform.position;
        iInitialPos = i.transform.position;
        jInitialPos = j.transform.position;
        kInitialPos = k.transform.position;
        lInitialPos = l.transform.position;
        mInitialPos = m.transform.position;
        nInitialPos = n.transform.position;
       // nInitialPos = o.transform.position;
        PlayerPrefs.SetInt("JumlahBenar", 0);
    }

    public void DragA()
    {
        a.transform.position = Input.mousePosition;
    }

    public void DragB()
    {
        b.transform.position = Input.mousePosition;
    }

    public void DragC()
    {
        c.transform.position = Input.mousePosition;
    }

    public void DragD()
    {
        d.transform.position = Input.mousePosition;
    }

    public void DragE()
    {
        e.transform.position = Input.mousePosition;
    }

    public void DragF()
    {
        f.transform.position = Input.mousePosition;
    }
    public void DragG()
    {
        g.transform.position = Input.mousePosition;
    }
    public void DragH()
    {
        h.transform.position = Input.mousePosition;
    }
    public void DragI()
    {
        i.transform.position = Input.mousePosition;
    }
    public void DragJ()
    {
        j.transform.position = Input.mousePosition;
    }
    public void DragK()
    {
        k.transform.position = Input.mousePosition;
    }
    public void DragL()
    {
        l.transform.position = Input.mousePosition;
    }
    public void DragM()
    {
        m.transform.position = Input.mousePosition;
    }
    public void DragN()
    {
        n.transform.position = Input.mousePosition;
    }
   /* public void DragO()
    {
        o.transform.position = Input.mousePosition;
    }*/

    //DROPPPPPP


    public void DropA()
    {
        float Distance = Vector3.Distance(a.transform.position, aBlack.transform.position);

        if (Distance < 100)
        {
            a.transform.position = aBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //acorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            a.transform.position = aInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropB()
    {
        float Distance = Vector3.Distance(b.transform.position, bBlack.transform.position);

        if (Distance < 50)
        {
            b.transform.position = bBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //bcorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            b.transform.position = bInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropC()
    {
        float Distance = Vector3.Distance(c.transform.position, cBlack.transform.position);

        if (Distance < 50)
        {
            c.transform.position = cBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //   ccorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            c.transform.position = cInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropD()
    {
        float Distance = Vector3.Distance(d.transform.position, dBlack.transform.position);

        if (Distance < 50)
        {
            d.transform.position = dBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //    dcorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            d.transform.position = dInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropE()
    {
        float Distance = Vector3.Distance(e.transform.position, eBlack.transform.position);

        if (Distance < 50)
        {
            e.transform.position = eBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //     ecorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            e.transform.position = eInitialPos;
            source.clip = incorrect;
            source.Play();
        }



    }

    public void DropF()
    {
        float Distance = Vector3.Distance(f.transform.position, fBlack.transform.position);

        if (Distance < 100)
        {
            f.transform.position = fBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //acorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            f.transform.position = fInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropG()
    {
        float Distance = Vector3.Distance(g.transform.position, gBlack.transform.position);

        if (Distance < 100)
        {
            g.transform.position = gBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //acorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            
            g.transform.position = gInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropH()
    {
        float Distance = Vector3.Distance(h.transform.position, hBlack.transform.position);

        if (Distance < 100)
        {
            h.transform.position = hBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //acorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            h.transform.position = hInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropI()
    {
        float Distance = Vector3.Distance(i.transform.position, iBlack.transform.position);

        if (Distance < 100)
        {
            i.transform.position = iBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //acorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            i.transform.position = iInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropJ()
    {
        float Distance = Vector3.Distance(j.transform.position, JBlack.transform.position);

        if (Distance < 100)
        {
            j.transform.position = JBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //acorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            j.transform.position = jInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropK()
    {
        float Distance = Vector3.Distance(k.transform.position, KBlack.transform.position);

        if (Distance < 100)
        {
            k.transform.position = KBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //acorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            k.transform.position = kInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropL()
    {
        float Distance = Vector3.Distance(l.transform.position, lBlack.transform.position);

        if (Distance < 100)
        {
            l.transform.position = lBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //acorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            l.transform.position = lInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropM()
    {
        float Distance = Vector3.Distance(m.transform.position, mBlack.transform.position);

        if (Distance < 100)
        {
            m.transform.position = mBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //acorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            m.transform.position = mInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropN()
    {
        float Distance = Vector3.Distance(n.transform.position, nBlack.transform.position);

        if (Distance < 100)
        {
            n.transform.position = nBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //acorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            n.transform.position = nInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }

  /*  public void DropO()
    {
        float Distance = Vector3.Distance(o.transform.position, oBlack.transform.position);

        if (Distance < 100)
        {
            o.transform.position = oBlack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            //acorrect = true;
            JumlahBenar = PlayerPrefs.GetInt("JumlahBenar") + 1;
            PlayerPrefs.SetInt("JumlahBenar", JumlahBenar);
        }
        else
        {
            o.transform.position = oInitialPos;
            source.clip = incorrect;
            source.Play();
        }

    }*/

    public void ResetNilai()
    {
        PlayerPrefs.SetInt("JumlahBenar", 0);
        penghitunganmundur = 30;
        a.transform.position = aInitialPos;
        b.transform.position = bInitialPos;
        c.transform.position = cInitialPos;
        d.transform.position = dInitialPos;
        e.transform.position = eInitialPos;
        f.transform.position = fInitialPos;
        g.transform.position = gInitialPos;
        h.transform.position = hInitialPos;
        i.transform.position = iInitialPos;
        j.transform.position = jInitialPos;
        k.transform.position = kInitialPos;
        l.transform.position = lInitialPos;
        m.transform.position = mInitialPos;
        n.transform.position = nInitialPos;
       // o.transform.position = oInitialPos;
        


    }

    void Update()
    {
      Nnilai.text = PlayerPrefs.GetInt("JumlahBenar").ToString(); 
        if (penghitunganmundur > 0)
        {
            timerUI.text = "Timer : " + penghitunganmundur.ToString("F0");
            //PlayerPrefs.SetInt("Timer",CountDownStartValue)
            //CountDownStartValue--;

            //Next.SetActive(false);
        }
        else
        {
            //SceneManager.LoadScene(SceneIndex);
            //timerUI.text = "GameOver";
            soal.SetActive(false);
            Next.SetActive(true);
            penghitunganmundur = 30;
            //CounterDownTimer();


            //soal.SetActive(false);


        }

        penghitunganmundur -= Time.deltaTime;



        if(PlayerPrefs.GetInt("JumlahBenar")==7)
        {
            yewwMenang.SetActive(true);
            soal.SetActive(false);
        }
    }
}
