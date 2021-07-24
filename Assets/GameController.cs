using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // telas do cenário principal
    public GameObject TelaMenu;
    public GameObject TelaSelectFase;
    public GameObject TelaSelectMode;
    public GameObject TelaVisulizeFase;
    public GameObject TelaConstructDiagram;
    public GameObject TelaTestFase;
    public GameObject TelaRanking;
    // popups usados nas fases
    public GameObject PopErro;
    public GameObject PopHelp;
    public GameObject PopFinish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // oculta todas as telas e mostra somente o menu
    public void ReturnMenu(){
        TelaMenu.SetActive(true);
        TelaSelectFase.SetActive(false);
        TelaSelectMode.SetActive(false);
        TelaVisulizeFase.SetActive(false);
        TelaConstructDiagram.SetActive(false);
        TelaTestFase.SetActive(false);
        TelaRanking.SetActive(false);
        PopErro.SetActive(false);
        PopHelp.SetActive(false);
        PopFinish.SetActive(false);
    }

    public void showTelaSelectFase(){
        TelaMenu.SetActive(false);
        TelaSelectFase.SetActive(true);
    }

    public void showTelaRank(){
        TelaMenu.SetActive(false);
        TelaRanking.SetActive(true);
    }

    public void showTelaSelectMode(){
        TelaSelectMode.SetActive(true);
    }

    // esconde todos os popup
    public void hidePopup(){
        TelaSelectMode.SetActive(false);
        PopErro.SetActive(false);
        PopHelp.SetActive(false);
    }

    public void showTelaVisualizeFase(){
        // alguns dos setactive(false) vem de outras funções que usam essa
        TelaSelectMode.SetActive(false);
        TelaSelectFase.SetActive(false);
        PopFinish.SetActive(false);
        TelaTestFase.SetActive(false);
        TelaConstructDiagram.SetActive(false);
        TelaVisulizeFase.SetActive(true);
    }

    public void showTelaConstructDiagram(){
        TelaVisulizeFase.SetActive(false);
        TelaConstructDiagram.SetActive(true);
    }

    public void showPopHelp(){
        PopHelp.SetActive(true);
    }

    public void showPopFinish(){
        PopFinish.SetActive(true);
    }

    public void nextFase(){
        // completar a função showTelaVisualizeFase para chamar a fase seguinte
        showTelaVisualizeFase();
    }

    public void restartFase(){
        // completar a função showTelaVisualizeFase para chamar a mesma fase
        showTelaVisualizeFase();
    }

    public void showTelaTestFase(){
        PopFinish.SetActive(false);
        TelaConstructDiagram.SetActive(false);
        TelaTestFase.SetActive(true);
    }

}
