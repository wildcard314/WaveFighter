using UnityEngine;


// we will have one instance of this class
// it will be a singleton which wil allow it to be accsessed 
// from all scritps in the projct
// This Script will keep track of the following:
// - time (paused playeing, time left
//- score (player & GUI SCORE)
//-levels what level we are on and when to start new wave
public class GameManager : MonoBehaviour
{
    public static GameManager instance {  get; private set; }

    private void Awake()
    {
        //check if there was one made already
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            //In all other cases make an instance of gamemanager
            instance = this;
        }
    }

    private int score = 23;

    public int getScore()
    {
        return score;
    }

    public void setScore(int s)
    {
        score = s;
    }




}
