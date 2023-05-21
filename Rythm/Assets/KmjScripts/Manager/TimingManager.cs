using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{
    public List<GameObject> boxNoteList = new List<GameObject>();

    [SerializeField] Transform Center = null;
    [SerializeField] RectTransform[] timingRect = null;
    Vector2[] timingBoxs = null;

    void Start()
    {
        timingBoxs = new Vector2[timingRect.Length];

        for(int i=0;i<timingRect.Length;i++)
        {
            timingBoxs[i].Set(Center.localPosition.x - timingRect[i].rect.width / 2, Center.localPosition.x + timingRect[i].rect.width / 2);
        }
    }

    public void CheckTiming()
    {
        for(int i = 0; i < boxNoteList.Count; i++)
        {
            float t_notePosX = boxNoteList[i].transform.localPosition.x;

            for(int x=0;x<timingBoxs.Length;x++)
            {
                if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                {
                    boxNoteList[i].GetComponent<Note>().HideNote();
                    boxNoteList[i].GetComponent<Note>().isHit = true;
                    boxNoteList.RemoveAt(i);
                    switch (x)
                    {
                        case 0:
                            GameManager.instance.hp += 20;
                            break;
                        case 1:
                            GameManager.instance.hp -= 10;
                            break;
                    }
                    return;
                }
            }
        }
    }
}
