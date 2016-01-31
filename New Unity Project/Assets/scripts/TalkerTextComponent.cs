using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TalkerTextComponent : MonoBehaviour
{
    public Talker[] talkers;

    bool m_areTalkersActive = false;
    bool m_isTalking = false;

    Text m_text;

    // Use this for initialization
    void Start()
    {
        m_text = GetComponentInChildren<Text>();
        m_text.text = string.Empty;

        GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }

    IEnumerator talk(Talker p_talker)
    {
        while (m_isTalking)
        {
            yield return new WaitForSeconds(0.5f);
        }

        m_isTalking = true;

        if (p_talker.lines.Length > 0)
        {
            GetComponent<Image>().color = new Color(1, 1, 1, 0.4f);

            foreach (string line in p_talker.lines)
            {
                m_text.text = line;
                yield return new WaitForSeconds(1.5f);
            }

            m_text.text = string.Empty;
            GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }

        m_isTalking = false;

        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Talker talker in talkers)
        {
            if (talker.isTalking)
            {
                StartCoroutine(talk(talker));
                talker.isTalking = false;
            }
        }
    }
}
