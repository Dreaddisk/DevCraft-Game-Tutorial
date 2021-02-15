using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Variables
    private bool isJumping = false;
    private bool isPunching = false;
    private bool isBuilding = false;
    #endregion

    public bool IsJumping
    {
        get
        {
            return isJumping;
        }
        set
        {
            isJumping = value;
        }
    }

    public bool IsPunching
    {
        get
        {
            return isPunching;
        }
        set
        {
            isPunching = value;
        }
    }

    public bool IsBuilding
    {
        get
        {
            return isBuilding;
        }
        set
        {
            isBuilding = value;
        }
    }

    public void jumpBtnPressed()
    {
        IsJumping = true;
    }

    public void punchBtnPressed()
    {
        IsPunching = true;
    }

    public void buildBtnPressed()
    {
        IsBuilding = true;
    }


} // GameManager class
