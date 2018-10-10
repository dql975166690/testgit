using UnityEngine;
using UnityEngine.UI;

public class control : MonoBehaviour {

    void Start ()
    {
        getName();

    }
	
	
	void Update ()
    {
		
	}

    public void getName()
    {
        Debug.Log(drop1.captionText.text);
      if(drop1.captionText.text== "单品套装")
        {
            Debug.Log(drop1.captionText.text);
            drop2.gameObject.SetActive(false);
            drop6.gameObject.SetActive(false);
        }
            
    }

    public void exit()
    {
        return null;
    }


}
