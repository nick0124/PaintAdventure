using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class LevelInfo{

    public int LevelID = 0;
    public bool IsFinishedLevel = false;

    List<object[]> levelsInfo = new List<object[]>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        for (int i = 0; i < levelsInfo.Capacity; i++)//проверка существует ли ионформация об уровне
        {
            //распаковка из листа с информацией о уровнях
            object[] array;
            array = levelsInfo[i];

            if ((int)array[0] == LevelID)//проверка, существует ли такая информаця обуровне
            {
                levelsInfo[i] = new object[] { LevelID, IsFinishedLevel };//если существует обновляем информацию
            }
            else
            {
                AddInfo(LevelID, IsFinishedLevel);//если не существует добавляем информацию
            }
        }
    }

    //метод добавляющий массив с id уровня и информацией продет\нет, в лист с информацией об уровнях
    private void AddInfo(int levelID,bool isFinished)
    {
        levelsInfo.Add(new object[] { levelID, isFinished });
    }
 

}
