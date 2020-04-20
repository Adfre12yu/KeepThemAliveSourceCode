using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlowerScript2 : MonoBehaviour
{
    public Sprite[] thinkSprites;
    public GameObject think;
    public bool letCoroutineStart = true;
    public bool needsSomething = false;
    public GameObject healthBarPrefab;
    public Canvas canvas;
    public int timerTime = 30;
    public int timerMin = 8;
    GameObject healthBar;
    SpriteRenderer spriteRenderer;
    

    private void Start()
    {
        spriteRenderer = think.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = null;
    }

    private void Update()
    {
        if (letCoroutineStart)
        {
            StartCoroutine(WantSomething());
        }

    }

    IEnumerator WantSomething()
    {
        letCoroutineStart = false;
        yield return new WaitForSeconds(Random.Range(2f, 5f));
        needsSomething = true;
        spriteRenderer.sprite = thinkSprites[Random.Range(0, thinkSprites.Length)];
        healthBar = Instantiate(healthBarPrefab, canvas.transform, false);
        healthBar.GetComponent<Slider>().maxValue = timerTime;
    }

    void Supplied()
    {
        letCoroutineStart = true;
        needsSomething = false;
        spriteRenderer.sprite = null;
        Destroy(healthBar);
        if (timerTime > timerMin)
        {
            timerTime -= 2;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (needsSomething & collision.gameObject.tag == spriteRenderer.sprite.name)
        {
            Supplied();
        }
    }
}
